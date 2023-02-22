using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikPlatformDriver
{
    public partial class FormComplexElevatedTilt : Form
    {
        private InverseKinematic invKinematic;
        public FormComplexElevatedTilt()
        {
            InitializeComponent();
        }
        int ascensionHeight;
        int ascensionVel;
        double ascensionAcc;
        int descensionVel;
        int descensionAcc;
        int ascensionTiltAngle;
        int ascensionTiltVelocity;
        int ascensionTiltAcc;
        int descensionTiltAngle;
        int descensionTiltVelocity;
        int descensionTiltAcc;
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
            ascensionAcc = trackBarAscensionAcc.Value/100;
            labelAscensionAcc.Text =trackBarAscensionAcc.Value.ToString();
            
        }

        private void trackBarAscensionTiltAngle_Scroll(object sender, EventArgs e)
        {
            ascensionTiltAngle = trackBarAscensionTiltAngle.Value;
            labelAscensionTiltAng.Text = trackBarAscensionTiltAngle.Value.ToString();
        }

        private void trackBarAscensionTiltVel_Scroll(object sender, EventArgs e)
        {
            ascensionTiltVelocity = trackBarAscensionTiltVel.Value;
            labelAscensionTiltVel.Text = trackBarAscensionTiltVel.Value.ToString();
        }

        private void trackBarAscensionTiltAcc_Scroll(object sender, EventArgs e)
        {
            ascensionTiltAcc = trackBarAscensionTiltAcc.Value;
            labelAscensionTiltAcc.Text = trackBarAscensionTiltAcc.Value.ToString();
        }

        private void trackBarDescensionVel_Scroll(object sender, EventArgs e)
        {
            descensionVel = trackBarDescensionVel.Value;
            labelDescensionVel.Text = trackBarDescensionVel.Value.ToString();
        }

        private void trackBarDescensionAcc_Scroll(object sender, EventArgs e)
        {
            descensionAcc = trackBarDescensionAcc.Value/100;
            labelDescensionAcc.Text = trackBarDescensionAcc.Value.ToString();
        }

        private void trackBarDescesionTiltAngle_Scroll(object sender, EventArgs e)
        {
            descensionTiltAngle = trackBarDescesionTiltAngle.Value;
            labelDescensionTiltAngle.Text = trackBarDescesionTiltAngle.Value.ToString();
        }

        private void trackBarDescesionTiltVelocity_Scroll(object sender, EventArgs e)
        {
            descensionTiltVelocity = trackBarDescesionTiltVelocity.Value;
            labelDescensionTiltVelocity.Text = trackBarDescesionTiltVelocity.Value.ToString();
        }

        private void trackBarTiltAcc_Scroll(object sender, EventArgs e)
        {
            descensionTiltAcc = trackBarDescensionTiltAcc.Value;
            labelDescensionTiltAcc.Text = trackBarDescensionTiltAcc.Value.ToString();
        }
        public void generateGCode()
        {
            ikControlList = new List<double[]>();
            double elevationAmount1 = ascensionHeight / 8;
            double elevationAmount2 = ascensionHeight / 8 * 2;
            double elevationAmount3 = ascensionHeight / 8 * 3;
            double elevationAmount4 = ascensionHeight / 8 * 4;
            double elevationAmount5 = ascensionHeight / 8 * 5;
            double elevationAmount6 = ascensionHeight / 8 * 6;
            double elevationAmount7 = ascensionHeight / 8 * 7;
           
            //Ascension
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount1} P0 Q{ascensionTiltAngle} U0 0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FQ{ascensionTiltVelocity} EQ{ascensionTiltAcc} EQ-{ascensionTiltAcc}");
            double[] axisF1 = { 0, 0, elevationAmount1, 0, ascensionTiltAngle, 0 };
            ikControlList.Add(axisF1);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount2} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FQ{ascensionTiltVelocity} EQ{ascensionTiltAcc} EQ-{ascensionTiltAcc}");
            double[] axisF2 = { 0, 0, elevationAmount2, 0, 0, 0 };
            ikControlList.Add(axisF2);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount3} P-{ascensionTiltAngle} Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FP{ascensionTiltVelocity} EP{ascensionTiltAcc} EP-{ascensionTiltAcc}");
            double[] axisF3 = { 0, 0, elevationAmount3, -ascensionTiltAngle, 0, 0 };
            ikControlList.Add(axisF3);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount4} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FP{ascensionTiltVelocity} EP{ascensionTiltAcc} EP-{ascensionTiltAcc}");
            double[] axisF4 = { 0, 0, elevationAmount4, 0, 0, 0 };
            ikControlList.Add(axisF4);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount5} P0 Q-{ascensionTiltAngle} U0 0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FQ{ascensionTiltVelocity} EQ{ascensionTiltAcc} EQ-{ascensionTiltAcc}");
            double[] axisF5 = { 0, 0, elevationAmount5, 0, -ascensionTiltAngle, 0 };
            ikControlList.Add(axisF5);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount6} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FQ{ascensionTiltVelocity} EQ{ascensionTiltAcc} EQ-{ascensionTiltAcc}");
            double[] axisF6 = { 0, 0, elevationAmount6, 0, 0, 0 };
            ikControlList.Add(axisF6);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount7} P{ascensionTiltAngle} Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FP{ascensionTiltVelocity} EP{ascensionTiltAcc} EP-{ascensionTiltAcc}");
            double[] axisF7 = { 0, 0, elevationAmount7, ascensionTiltAngle, 0, 0 };
            ikControlList.Add(axisF7);
            gCodeList.Add($"G1 X0 Y0 Z{ascensionHeight} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FQ{ascensionTiltVelocity} EQ{ascensionTiltAcc} EQ-{ascensionTiltAcc}");
            double[] axisF8 = { 0, 0, ascensionHeight, 0, 0, 0 };
            ikControlList.Add(axisF8);
            
            //Descension
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount7} P0 Q{descensionTiltAngle} U0 0 FZ{descensionVel} EZ{descensionAcc} EZ-{descensionAcc} FQ{descensionTiltVelocity} EQ{descensionTiltAcc} EQ-{descensionTiltAcc}");
            double[] axisF9 = { 0, 0, elevationAmount7, 0, descensionTiltAngle, 0 };
            ikControlList.Add(axisF9);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount6} P0 Q0 U0 FZ{descensionVel} EZ{descensionAcc} EZ-{descensionAcc} FQ{descensionTiltVelocity} EQ{descensionTiltAcc} EQ-{descensionTiltAcc}");
            double[] axisF10 = { 0, 0, elevationAmount6, 0, 0, 0 };
            ikControlList.Add(axisF10);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount5} P-{ascensionTiltAngle} Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FP{ascensionTiltVelocity} EP{ascensionTiltAcc} EP-{ascensionTiltAcc}");
            double[] axisF11 = { 0, 0, elevationAmount5, -ascensionTiltAngle, 0, 0 };
            ikControlList.Add(axisF11);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount4} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FP{ascensionTiltVelocity} EP{ascensionTiltAcc} EP-{ascensionTiltAcc}");
            double[] axisF12 = { 0, 0, elevationAmount4, 0, 0, 0 };
            ikControlList.Add(axisF12);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount3} P0 Q-{ascensionTiltAngle} U0 0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FQ{ascensionTiltVelocity} EQ{ascensionTiltAcc} EQ-{ascensionTiltAcc}");
            double[] axisF13 = { 0, 0, elevationAmount3, 0, -ascensionTiltAngle, 0 };
            ikControlList.Add(axisF13);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount2} P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FQ{ascensionTiltVelocity} EQ{ascensionTiltAcc} EQ-{ascensionTiltAcc}");
            double[] axisF14 = { 0, 0, elevationAmount2, 0, 0, 0 };
            ikControlList.Add(axisF14);
            gCodeList.Add($"G1 X0 Y0 Z{elevationAmount1} P{ascensionTiltAngle} Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FP{ascensionTiltVelocity} EP{ascensionTiltAcc} EP-{ascensionTiltAcc}");
            double[] axisF15 = { 0, 0, elevationAmount1, ascensionTiltAngle, 0, 0 };
            ikControlList.Add(axisF15);
            gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FZ{ascensionVel} EZ{ascensionAcc} EZ-{ascensionAcc} FQ{ascensionTiltVelocity} EQ{ascensionTiltAcc} EQ-{ascensionTiltAcc}");
            double[] axisF16 = { 0, 0, 0, 0, 0, 0 };
            ikControlList.Add(axisF16);

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
