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
    public partial class FormEasyTilt : Form
    {

        private InverseKinematic invKinematic;
        public FormEasyTilt()
        {
            InitializeComponent();
        }
        int tiltAngle;
        int velocity;
        int acceleration;
        int repetition;
        List<string> gCodeList = new List<string>();
        List<double[]> ikControlList;
        string path = "C:\\Users\\seher\\OneDrive - Elondor\\Desktop\\G Codes\\gcode.txt";
        string startCode1 = "%0001";
        string startCode2 = $@"N1 G51 D0.001                        
N2 G38 O1 I0.004 J0.004            
N3 G17                             
N4 G90                             
N5 G75                             
N6 G53";
        string endCode = "M2";
        string front;
        string frontR;
        string right;
        string backR;
        string back;
        string backL;
        string left;
        string frontL;
        StringBuilder gbaseCode = new StringBuilder();

        int ikControlValue;
        int randomValue;


        private void FormEasyTilt_Load(object sender, EventArgs e)
        {

        }

        private void btnStartEasyTilt_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, String.Empty);
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

        private void trackBarTiltAngle_Scroll(object sender, EventArgs e)
        {
            tiltAngle = trackBarTiltAngle.Value;
            labelAngleValue.Text = trackBarTiltAngle.Value.ToString();


        }

        private void trackBarVelocity_Scroll(object sender, EventArgs e)
        {
            velocity = trackBarVelocity.Value;
            labelVelocityValue.Text = trackBarVelocity.Value.ToString();
        }

        private void trackBarAcc_Scroll(object sender, EventArgs e)
        {
            acceleration = trackBarAcc.Value;
            labelAccValue.Text = trackBarAcc.Value.ToString();
        }


        private void checkBoxFront_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFrontR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBackR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBack_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBackL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxLeft_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFrontL_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void generateGCode()
        {
            ikControlList = new List<double[]>();
            if (radioBtnRandom.Checked == true)
            {
                Random rnd = new Random();
                randomValue = rnd.Next(1, 3);
            }

            if (radioBtnClockwise.Checked == true | randomValue == 1)
            {
                

                if (checkBoxFront.Checked == true)
                {
                    front = $"G1 X0 Y0 Z0 P0 Q{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(front);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisF = { 0, 0, 0, 0, tiltAngle, 0 };
                    ikControlList.Add(axisF);


                }
                if (checkBoxFrontR.Checked == true)
                {
                    frontR = $"G1 X0 Y0 Z0 P-{tiltAngle} Q{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(frontR);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisFR = { 0, 0, 0, -tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisFR);

                }
                if (checkBoxRight.Checked == true)
                {
                    right = $"G1 X0 Y0 Z0 P-{tiltAngle} Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FP{velocity} EP{acceleration} EP-{acceleration}";
                    gCodeList.Add(right);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FP{velocity} EP{acceleration} EP-{acceleration}");
                    double[] axisR = { 0, 0, 0, -tiltAngle, 0, 0 };
                    ikControlList.Add(axisR);

                }
                if (checkBoxBackR.Checked == true)
                {
                    backR = $"G1 X0 Y0 Z0 P-{tiltAngle} Q-{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(backR);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisBR = { 0, 0, 0, -tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisBR);

                }
                if (checkBoxBack.Checked == true)
                {
                    back = $"G1 X0 Y0 Z0 P0 Q-{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(back);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisB = { 0, 0, 0, 0, -tiltAngle, 0 };
                    ikControlList.Add(axisB);

                }
                if (checkBoxBackL.Checked == true)
                {
                    backL = $"G1 X0 Y0 Z0 P{tiltAngle} Q-{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(backL);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisBL = { 0, 0, 0, tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisBL);

                }
                if (checkBoxLeft.Checked == true)
                {
                    left = $"G1 X0 Y0 Z0 P{tiltAngle} Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FP{velocity} EP{acceleration} EP-{acceleration}";
                    gCodeList.Add(left);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FP{velocity} EP{acceleration} EP-{acceleration}");
                    double[] axisL = { 0, 0, 0, tiltAngle, 0, 0 };
                    ikControlList.Add(axisL);

                }
                if (checkBoxFrontL.Checked == true)
                {
                    frontL = $"G1 X0 Y0 Z0 P{tiltAngle} Q{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(frontL);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisFR = { 0, 0, 0, tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisFR);

                }
            }
            if (radioBtnCounterclockwise.Checked == true | randomValue == 2)
            {
                if (checkBoxFront.Checked == true)
                {
                    front = $"G1 X0 Y0 Z0 P0 Q{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(front);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisF = { 0, 0, 0, 0, tiltAngle, 0 };
                    ikControlList.Add(axisF);

                }
                if (checkBoxFrontL.Checked == true)
                {
                    frontL = $"G1 X0 Y0 Z0 P{tiltAngle} Q{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(frontL);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisFL = { 0, 0, 0, tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisFL);

                }
                if (checkBoxLeft.Checked == true)
                {
                    left = $"G1 X0 Y0 Z0 P{tiltAngle} Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FP{velocity} EP{acceleration} EP-{acceleration}";
                    gCodeList.Add(left);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FP{velocity} EP{acceleration} EP-{acceleration}");
                    double[] axisL = { 0, 0, 0, tiltAngle, 0, 0 };
                    ikControlList.Add(axisL);

                }
                if (checkBoxBackL.Checked == true)
                {
                    backL = $"G1 X0 Y0 Z0 P{tiltAngle} Q-{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(backL);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisBL = { 0, 0, 0, tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisBL);

                }
                if (checkBoxBack.Checked == true)
                {
                    back = $"G1 X0 Y0 Z0 P0 Q-{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(back);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisB = { 0, 0, 0, 0, -tiltAngle, 0 };
                    ikControlList.Add(axisB);

                }
                if (checkBoxBackR.Checked == true)
                {
                    backR = $"G1 X0 Y0 Z0 P-{tiltAngle} Q-{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(backR);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisBR = { 0, 0, 0, -tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisBR);

                }
                if (checkBoxRight.Checked == true)
                {
                    right = $"G1 X0 Y0 Z0 P-{tiltAngle} Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FP{velocity} EP{acceleration} EP-{acceleration}";
                    gCodeList.Add(right);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FP{velocity} EP{acceleration} EP-{acceleration}");
                    double[] axisR = { 0, 0, 0, -tiltAngle, 0, 0 };
                    ikControlList.Add(axisR);

                }
                if (checkBoxFrontR.Checked == true)
                {
                    frontR = $"G1 X0 Y0 Z0 P-{tiltAngle} Q{tiltAngle} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}";
                    gCodeList.Add(frontR);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axisFR = { 0, 0, 0, -tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisFR);
                }
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
