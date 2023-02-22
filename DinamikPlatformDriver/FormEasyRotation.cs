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
    public partial class FormEasyRotation : Form
    {
        private InverseKinematic invKinematic;
        public FormEasyRotation()
        {
            InitializeComponent();
        }
        int rotationDegree;
        int rotationVelocity;
        int rotationAcc;
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
        private void FormEasyRotation_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
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


        private void trackBarRotDeg_Scroll(object sender, EventArgs e)
        {
            rotationDegree = trackBarRotDeg.Value;
            labelRotDeg.Text = trackBarRotDeg.Value.ToString();
        }

        private void trackBarRotVel_Scroll(object sender, EventArgs e)
        {
            rotationVelocity = trackBarRotVel.Value;
            labelRotVel.Text = trackBarRotVel.Value.ToString();
        }

        private void trackBarRotAcc_Scroll(object sender, EventArgs e)
        {
            rotationAcc = trackBarRotAcc.Value;
            labelRotAcc.Text = trackBarRotAcc.Value.ToString();
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
            if (radioBtnClockwise.Checked == true)
            {
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U-{rotationDegree} FU{rotationVelocity} EU{rotationAcc} EU-{rotationAcc}");
                double[] axisF1 = { 0, 0, 0, 0, 0, -rotationDegree };
                ikControlList.Add(axisF1);
                gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q0 U{rotationDegree} FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF2 = { 0, 0, 0, tiltAngle, 0, rotationDegree };
                ikControlList.Add(axisF2);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U-{rotationDegree} FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF3 = { 0, 0, 0, 0, 0, -rotationDegree };
                ikControlList.Add(axisF3);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FU{rotationVelocity} EU{rotationAcc} EU-{rotationAcc}");
                //
                gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF4 = { 0, 0, 0, -tiltAngle, 0, 0 };
                ikControlList.Add(axisF4);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                //

                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U{rotationDegree} FU{rotationVelocity} EU{rotationAcc} EU-{rotationAcc}");
                double[] axisF5 = { 0, 0, 0, 0, 0, rotationDegree };
                ikControlList.Add(axisF5);
                gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngle} Q0 U{rotationDegree} FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF6 = { 0, 0, 0, -tiltAngle, 0, rotationDegree };
                ikControlList.Add(axisF6);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U{rotationDegree} FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF7 = { 0, 0, 0, 0, 0, 0, rotationDegree };
                ikControlList.Add(axisF7);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FU{rotationVelocity} EU{rotationAcc} EU-{rotationAcc}");
                //
                gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF8 = { 0, 0, 0, tiltAngle, 0, 0 };
                ikControlList.Add(axisF8);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                //
            }
            if (radioBtnCounterclck.Checked == true)
            {
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U{rotationDegree} FU{rotationVelocity} EU{rotationAcc} EU-{rotationAcc}");
                double[] axisF1 = { 0, 0, 0, 0, 0, rotationDegree };
                ikControlList.Add(axisF1);
                gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngle} Q0 U{rotationDegree} FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF2 = { 0, 0, 0, -tiltAngle, 0, rotationDegree };
                ikControlList.Add(axisF2);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U{rotationDegree} FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF3 = { 0, 0, 0, 0, 0, 0, rotationDegree };
                ikControlList.Add(axisF3);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FU{rotationVelocity} EU{rotationAcc} EU-{rotationAcc}");
                //
                gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF4 = { 0, 0, 0, tiltAngle, 0, 0 };
                ikControlList.Add(axisF4);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                //

                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U-{rotationDegree} FU{rotationVelocity} EU{rotationAcc} EU-{rotationAcc}");
                double[] axisF5 = { 0, 0, 0, 0, 0, -rotationDegree };
                ikControlList.Add(axisF5);
                gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q0 U{rotationDegree} FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF6 = { 0, 0, 0, tiltAngle, 0, rotationDegree };
                ikControlList.Add(axisF6);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U-{rotationDegree} FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF7 = { 0, 0, 0, 0, 0, -rotationDegree };
                ikControlList.Add(axisF7);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FU{rotationVelocity} EU{rotationAcc} EU-{rotationAcc}");
                //
                gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                double[] axisF8 = { 0, 0, 0, -tiltAngle, 0, 0 };
                ikControlList.Add(axisF8);
                gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
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
