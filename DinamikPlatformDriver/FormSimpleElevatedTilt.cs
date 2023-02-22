using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DinamikPlatformDriver
{
    public partial class FormSimpleElevatedTilt : Form
    {
        private InverseKinematic invKinematic;
        public FormSimpleElevatedTilt()
        {
            InitializeComponent();
        }
        int ascensionHeight;
        int ascensionVelocity;
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
        private void FormSimpleElevatedTilt_Load(object sender, EventArgs e)
        {
           
        }
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

        private void trackBarShiftAmount_Scroll(object sender, EventArgs e)
        {
            ascensionHeight = trackBarAscensionHeight.Value;
            labelAscensionHeight.Text = trackBarAscensionHeight.Value.ToString();
        }

        private void trackBarShiftVel_Scroll(object sender, EventArgs e)
        {
            ascensionVelocity= trackBarAscensionVel.Value;
            labelAscensionVel.Text = trackBarAscensionVel.Value.ToString();
        }

        private void trackBarShiftAcc_Scroll(object sender, EventArgs e)
        {
            ascensionAcc= trackBarAscensionAcc.Value;
            labelAscensionAcc.Text= trackBarAscensionAcc.Value.ToString();
        }
        private void trackBarDescensionVel_Scroll(object sender, EventArgs e)
        {
            descensionVel= trackBarDescensionVel.Value;
            labelDescensionVel.Text= trackBarDescensionVel.Value.ToString();
        }

        private void trackBarDescensionAcc_Scroll(object sender, EventArgs e)
        {
            descensionAcc=trackBarDescensionAcc.Value;
            labelDescensionAcc.Text=trackBarDescensionAcc.Value.ToString();
        }

        private void trackBarTiltAngle_Scroll(object sender, EventArgs e)
        {
            tiltAngle= trackBarTiltAngle.Value;
            labelTiltAng.Text= trackBarTiltAngle.Value.ToString();
        }

        private void trackBarTiltVel_Scroll(object sender, EventArgs e)
        {
            tiltVelocity= trackBarTiltVel.Value;
            labelTiltVel.Text= trackBarTiltVel.Value.ToString();
        }

        private void trackBarTiltAcc_Scroll(object sender, EventArgs e)
        {
            tiltAcc= trackBarTiltAcc.Value;
            labelTiltAcc.Text=trackBarTiltAcc.Value.ToString();
        }

        public void generateGCode()
        {
            ikControlList = new List<double[]>();
            if (radioBtnClockwise.Checked == true)
            {  
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FZ{ascensionVelocity} EZ{ascensionAcc} EZ-{ascensionAcc}");
                double[] axisF1 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF1);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF2 = { 0, 0, ascensionHeight, 0, tiltAngle, 0 };
                ikControlList.Add(axisF2);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF3 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF3);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P-{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF4 = { 0, 0, ascensionHeight, -tiltAngle, 0, 0 };
                ikControlList.Add(axisF4);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF5 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF5);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q-{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF6 = { 0, 0, ascensionHeight, 0, -tiltAngle, 0 };
                ikControlList.Add(axisF6);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF7 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF7);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF8 = { 0, 0, ascensionHeight, tiltAngle, 0, 0 };
                ikControlList.Add(axisF8);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF9 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF9);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FZ{descensionVel} EZ{descensionAcc} EZ-{descensionAcc}");
                //
            }
            if (radioBtnCounterclck.Checked == true)
            {
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FZ{ascensionVelocity} EZ{ascensionAcc} EZ-{ascensionAcc}");
                double[] axisF1 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF1);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF2 = { 0, 0, ascensionHeight, 0, tiltAngle, 0 };
                ikControlList.Add(axisF2);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF3 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF3);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF4 = { 0, 0, ascensionHeight, tiltAngle, 0, 0 };
                ikControlList.Add(axisF4);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF5 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF5);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q-{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF6 = { 0, 0, ascensionHeight, 0, -tiltAngle, 0 };
                ikControlList.Add(axisF6);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                double[] axisF7 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF7);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P-{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF8 = { 0, 0, ascensionHeight, -tiltAngle, 0, 0 };
                ikControlList.Add(axisF8);
                gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF9 = { 0, 0, ascensionHeight, 0, 0, 0 };
                ikControlList.Add(axisF9);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FZ{descensionVel} EZ{descensionAcc} EZ-{descensionAcc}");
                //

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

