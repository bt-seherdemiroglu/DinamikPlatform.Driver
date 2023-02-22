using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DinamikPlatformDriver
{
    public partial class FormTwoStageElevatedTilt : Form
    {
        private InverseKinematic invKinematic;
        public FormTwoStageElevatedTilt()
        {
            InitializeComponent();
        }
        int ascensionHeight;
        int ascensionVel;
        int ascensionAcc;
        int descensionVel;
        int descensionAcc;
        int tiltAngle;
        int tiltVelocity;
        int tiltAcc;
        int repetition;
        string startCode1 = "%0001";
        string startCode2 = $@"N1 G51 D0.001                        
N2 G38 O1 I0.004 J0.004            
N3 G17                             
N4 G90                             
N5 G75                             
N6 G53";
        string endCode = "M2";
        List<string> gCodeList = new List<string>();
        List<double[]> ikControlList;
        StringBuilder gbaseCode = new StringBuilder();
        int ikControlValue;
        string path = "C:\\Users\\seher\\OneDrive - Elondor\\Desktop\\G Codes\\gcode.txt";

        private void btnStart_Click(object sender, EventArgs e)
        {
            generateGCode();
            ikConrol();
            if (ikControlValue == 1)
            {
                MessageBox.Show("limitlerin dışına çıkıldı");
            }
            else
            {
                gbaseCode.Append(startCode1);
                gbaseCode.Append(Environment.NewLine);
                gbaseCode.Append(startCode2);
                gbaseCode.Append(Environment.NewLine);
                repetition = Convert.ToInt32(textBoxRepetition.Text);

                int k = 0;
                int n = 0;
                while (k < repetition)
                {
                    for (int j = 0; j < gCodeList.Count; j++)
                    {

                        gbaseCode.Append($"N{n + 7} ");
                        gbaseCode.Append(gCodeList[j]);
                        gbaseCode.Append(Environment.NewLine);
                        n++;
                    }
                    k++;
                }
                gbaseCode.Append(endCode);
                MessageBox.Show(gbaseCode.ToString());
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine(gbaseCode);
                }
            }
        }

        private void trackBarAscensionHeight_Scroll(object sender, EventArgs e)
        {
            ascensionHeight = trackBarAscensionHeight.Value;
            labelAscensionHeight.Text = trackBarAscensionHeight.Value.ToString(); 
        }

        private void trackBarAscensionVel_Scroll(object sender, EventArgs e)
        {
            ascensionVel = trackBarAscensionVel.Value;
            labelAscensionVel.Text = trackBarAscensionVel.Value.ToString();
        }

        private void trackBarAscensionAcc_Scroll(object sender, EventArgs e)
        {
            ascensionAcc = trackBarAscensionAcc.Value;
            labelAscensionAcc.Text = trackBarAscensionAcc.Value.ToString();
        }

        private void trackBarDescensionVel_Scroll(object sender, EventArgs e)
        {
            descensionVel = trackBarDescensionVel.Value;
            labelDescensionVel.Text = trackBarDescensionVel.Value.ToString();
        }

        private void trackBarDescensionAcc_Scroll(object sender, EventArgs e)
        {
            descensionAcc = trackBarDescensionAcc.Value;
            labelDescensionAcc.Text = trackBarDescensionAcc.Value.ToString();
        }

        private void trackBarTiltAngle_Scroll(object sender, EventArgs e)
        {
            tiltAngle = trackBarTiltAngle.Value;
            labelTiltAng.Text = trackBarTiltAngle.Value.ToString();
        }

        private void trackBarTiltVel_Scroll(object sender, EventArgs e)
        {
            tiltVelocity = trackBarTiltVel.Value;
            labelTiltVel.Text = trackBarTiltVel.Value.ToString();
        }

        private void trackBarTiltAcc_Scroll(object sender, EventArgs e)
        {
            tiltAcc = trackBarTiltAcc.Value;
            labelTiltAcc.Text = trackBarTiltAcc.Value.ToString();
        }

        public void generateGCode()
        {
            ikControlList = new List<double[]>();
            double ascencionHeight1 = ascensionHeight / 2;
            double frx = Math.Round(tiltAngle * Math.Cos(135 * Math.PI / 180), 2);
            double fry = Math.Round(tiltAngle * Math.Sin(135 * Math.PI / 180), 2);
            double brx = Math.Round(tiltAngle * Math.Cos(225 * Math.PI / 180), 2);
            double bry = Math.Round(tiltAngle * Math.Sin(225 * Math.PI / 180), 2);
            double blx = Math.Round(tiltAngle * Math.Cos(315 * Math.PI / 180), 2);
            double bly = Math.Round(tiltAngle * Math.Sin(315 * Math.PI / 180), 2);
            double flx = Math.Round(tiltAngle * Math.Cos(45 * Math.PI / 180), 2);
            double fly = Math.Round(tiltAngle * Math.Sin(45 * Math.PI / 180), 2);

            if (radioBtnClockwise.Checked == true)
            {
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc}");
                double[] axisF1 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF1);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF2 = { 0, 0, ascencionHeight1, 0, tiltAngle, 0 };
                ikControlList.Add(axisF2);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF3 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF3);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P-{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF4 = { 0, 0, ascencionHeight1, -tiltAngle, 0, 0 };
                ikControlList.Add(axisF4);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF5 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF5);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q-{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF6 = { 0, 0, ascencionHeight1, 0, -tiltAngle, 0 };
                ikControlList.Add(axisF6);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF7 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF7);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF8 = { 0, 0, ascencionHeight1, tiltAngle, 0, 0 };
                ikControlList.Add(axisF8);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF9 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF9);


                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc}");
                double[] axisF10 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF10);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{frx} Q{fry} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF11 = { 0, 0, ascensionHeight, frx, fry, 0 };
                ikControlList.Add(axisF11);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF12 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF12);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{brx} Q{bry} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF13 = { 0, 0, ascensionHeight, brx, bry, 0 };
                ikControlList.Add(axisF13);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF14 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF14);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{blx} Q{bly} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF15 = { 0, 0, ascensionHeight, blx, bly, 0 };
                ikControlList.Add(axisF15);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF16 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF16);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{flx} Q{fly} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF17 = { 0, 0, ascensionHeight, flx, fly, 0 };
                ikControlList.Add(axisF17);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF18 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF18);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FZ{descensionVel} EZ{descensionAcc} EZ-{descensionAcc}");


            }
            if (radioBtnCounterclck.Checked == true)
            {
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc}");
                double[] axisF1 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF1);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF2 = { 0, 0, ascencionHeight1, 0, tiltAngle, 0 };
                ikControlList.Add(axisF2);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF3 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF3);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF4 = { 0, 0, ascencionHeight1, tiltAngle, 0, 0 };
                ikControlList.Add(axisF4);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF5 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF5);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q-{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF6 = { 0, 0, ascencionHeight1, 0, -tiltAngle, 0 };
                ikControlList.Add(axisF6);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF7 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF7);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P-{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF8 = { 0, 0, ascencionHeight1, -tiltAngle, 0, 0 };
                ikControlList.Add(axisF8);
                gCodeList.Add($"G1 X0 Y0 Z{ascencionHeight1} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF9 = { 0, 0, ascencionHeight1, 0, 0, 0 };
                ikControlList.Add(axisF9);


                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc}");
                double[] axisF10 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF10);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{flx} Q{fly} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF11 = { 0, 0, ascensionHeight, fly, fly, 0 };
                ikControlList.Add(axisF11);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF12 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF12);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{blx} Q{bly} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF13 = { 0, 0, ascensionHeight, blx, bly, 0 };
                ikControlList.Add(axisF13);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF14 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF14);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{brx} Q{bry} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF15 = { 0, 0, ascensionHeight, brx, bry, 0 };
                ikControlList.Add(axisF15);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF16 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF16);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{frx} Q{fry} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF17 = { 0, 0, ascensionHeight, frx, fry, 0 };
                ikControlList.Add(axisF17);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF18 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF18);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FZ{descensionVel} EZ{descensionAcc} EZ-{descensionAcc}");

            }

        }
        public void ikConrol()
        {
            invKinematic = new InverseKinematic();

            for (int i = 0; i < ikControlList.Count; i++)
            {
                double[] result = new double[6];
                invKinematic.InverseKinematics(ikControlList[i], result);
                for (int j = 0; j < 6; j++)
                {
                    if (result[j] < -93 || result[j] > 93)
                    {
                        ikControlValue = 1;
                        break;
                    }

                }


            }
        }

    }
}
