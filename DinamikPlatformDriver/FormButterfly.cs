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
    public partial class FormButterfly : Form
    {
        private InverseKinematic invKinematic;
        public FormButterfly()
        {
            InitializeComponent();
        }
        string startCode1 = "%0001";
        string startCode2 = $@"N1 G51 D0.001                        
N2 G38 O1 I0.004 J0.004            
N3 G17                             
N4 G90                             
N5 G75                             
N6 G53";
        string endCode = "M2";
        int tiltAngleSym;
        int tiltAngleASymMin;
        int tiltAngleASymMax;
        int velocity;
        int acceleration;
        int repetition;
        List<string> gCodeList = new List<string>();
        StringBuilder gbaseCode = new StringBuilder();
        List<double[]> ikControlList;
        int ikControlValue;
        string path = "C:\\Users\\seher\\OneDrive - Elondor\\Desktop\\G Codes\\gcode.txt";

        private void btnStartButterfly_Click(object sender, EventArgs e)
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
                gbaseCode.Append($"N{n+7} G1 X0 Y0 Z0 P0 Q0 U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                gbaseCode.Append(Environment.NewLine);
                gbaseCode.Append(endCode);
                MessageBox.Show(gbaseCode.ToString());
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine(gbaseCode);
                }
            }

        }

        private void trackBarTiltSym_Scroll(object sender, EventArgs e)
        {
            tiltAngleSym = trackBarTiltSym.Value;
            labelSym.Text = trackBarTiltSym.Value.ToString();
        }

        private void trackBarTiltAsymMin_Scroll(object sender, EventArgs e)
        {
            tiltAngleASymMin=trackBarTiltAsymMin.Value;
            labelAsymMin.Text=trackBarTiltAsymMin.Value.ToString(); 
        }

        private void trackBarTiltAsymMax_Scroll(object sender, EventArgs e)
        {
            tiltAngleASymMax=trackBarTiltAsymMax.Value;
            labelAsymMax.Text=trackBarTiltAsymMax.Value.ToString();
        }

        private void trackBarVelocity_Scroll(object sender, EventArgs e)
        {
            velocity = trackBarVelocity.Value;
            labelVelocity.Text=trackBarVelocity.Value.ToString();
        }

        private void trackBarAcc_Scroll(object sender, EventArgs e)
        {
            acceleration = trackBarAcc.Value;
            labelAcc.Text=trackBarAcc.Value.ToString();
        }

        public void generateGCode()
        {
            ikControlList = new List<double[]>();
            if (radioButtonSym.Checked == true)
            {

                if (comboBoxStartDirect.Text == "1")
                {
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngleSym} Q{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt1 = { 0, 0, 0, -tiltAngleSym, tiltAngleSym, 0 };
                    ikControlList.Add(tilt1);
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngleSym} Q-{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt2 = { 0, 0, 0, -tiltAngleSym, -tiltAngleSym, 0 };
                    ikControlList.Add(tilt2);
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngleSym} Q{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt3 = { 0, 0, 0, tiltAngleSym, tiltAngleSym, 0 };
                    ikControlList.Add(tilt3);
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngleSym} Q-{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt4 = { 0, 0, 0, tiltAngleSym, -tiltAngleSym, 0 };
                    ikControlList.Add(tilt4);
                    
                }
                if (comboBoxStartDirect.Text == "2")
                {
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngleSym} Q-{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt1 = { 0, 0, 0, -tiltAngleSym, -tiltAngleSym, 0 };
                    ikControlList.Add(tilt1);
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngleSym} Q{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt2 = { 0, 0, 0, -tiltAngleSym, tiltAngleSym, 0 };
                    ikControlList.Add(tilt2);
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngleSym} Q-{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt3 = { 0, 0, 0, tiltAngleSym, -tiltAngleSym, 0 };
                    ikControlList.Add(tilt3);
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngleSym} Q{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt4 = { 0, 0, 0, tiltAngleSym, tiltAngleSym, 0 };
                    ikControlList.Add(tilt4);
                    
                }

                if (comboBoxStartDirect.Text == "3")
                {
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngleSym} Q-{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt1 = { 0, 0, 0, tiltAngleSym, -tiltAngleSym, 0 };
                    ikControlList.Add(tilt1);
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngleSym} Q{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt2 = { 0, 0, 0, tiltAngleSym, tiltAngleSym, 0 };
                    ikControlList.Add(tilt2);
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngleSym} Q-{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt3 = { 0, 0, 0, -tiltAngleSym, -tiltAngleSym, 0 };
                    ikControlList.Add(tilt3);
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngleSym} Q{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt4 = { 0, 0, 0, -tiltAngleSym, tiltAngleSym, 0 };
                    ikControlList.Add(tilt4);
                   
                }
                if (comboBoxStartDirect.Text == "4")
                {
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngleSym} Q{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt1 = { 0, 0, 0, tiltAngleSym, tiltAngleSym, 0 };
                    ikControlList.Add(tilt1);
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngleSym} Q-{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt2 = { 0, 0, 0, tiltAngleSym, -tiltAngleSym, 0 };
                    ikControlList.Add(tilt2);
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngleSym} Q{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt3 = { 0, 0, 0, -tiltAngleSym, tiltAngleSym, 0 };
                    ikControlList.Add(tilt3);
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngleSym} Q-{tiltAngleSym} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] tilt4 = { 0, 0, 0, -tiltAngleSym, -tiltAngleSym, 0 };
                    ikControlList.Add(tilt4);
              
                }
            }

            if (radioButtonAsym.Checked == true)
            {
                if (tiltAngleASymMin > tiltAngleASymMax)
                {
                    MessageBox.Show("minimum tilt açısı maksimum tilt açısından büyük olamaz");
                }
                else
                {
                    Random random = new Random();
                    int angle1 = random.Next(tiltAngleASymMin, tiltAngleASymMax);
                    int angle2 = random.Next(tiltAngleASymMin, tiltAngleASymMax);
                    int angle3 = random.Next(tiltAngleASymMin, tiltAngleASymMax);
                    int angle4 = random.Next(tiltAngleASymMin, tiltAngleASymMax);
                    if (comboBoxStartDirect.Text == "1")
                    {
                        gCodeList.Add($"G1 X0 Y0 Z0 P-{angle1} Q{angle1} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt1 = { 0, 0, 0, -angle1, angle1, 0 };
                        ikControlList.Add(tilt1);
                        gCodeList.Add($"G1 X0 Y0 Z0 P-{angle2} Q-{angle2} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt2 = { 0, 0, 0, -angle2, -angle2, 0 };
                        ikControlList.Add(tilt2);
                        gCodeList.Add($"G1 X0 Y0 Z0 P{angle3} Q{angle3} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt3 = { 0, 0, 0, angle3, angle3, 0 };
                        ikControlList.Add(tilt3);
                        gCodeList.Add($"G1 X0 Y0 Z0 P{angle4} Q-{angle4} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt4 = { 0, 0, 0, angle4, -angle4, 0 };
                        ikControlList.Add(tilt4);
              
                    }
                    if (comboBoxStartDirect.Text == "2")
                    {
                        gCodeList.Add($"G1 X0 Y0 Z0 P-{angle2} Q-{angle2} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt1 = { 0, 0, 0, -angle2, -angle2, 0 };
                        ikControlList.Add(tilt1);
                        gCodeList.Add($"G1 X0 Y0 Z0 P-{angle1} Q{angle1} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt2 = { 0, 0, 0, -angle1, angle1, 0 };
                        ikControlList.Add(tilt2);
                        gCodeList.Add($"G1 X0 Y0 Z0 P{angle3} Q-{angle3} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt3 = { 0, 0, 0, angle3, -angle3, 0 };
                        ikControlList.Add(tilt3);
                        gCodeList.Add($"G1 X0 Y0 Z0 P{angle4} Q{angle4} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt4 = { 0, 0, 0, angle4, angle4, 0 };
                        ikControlList.Add(tilt4);
                     
                    }
                    if (comboBoxStartDirect.Text == "3")
                    {
                        gCodeList.Add($"G1 X0 Y0 Z0 P{angle3} Q-{angle3} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt1 = { 0, 0, 0, angle3, -angle3, 0 };
                        ikControlList.Add(tilt1);
                        gCodeList.Add($"G1 X0 Y0 Z0 P{angle4} Q{angle4} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt2 = { 0, 0, 0, angle4, angle4, 0 };
                        ikControlList.Add(tilt2);
                        gCodeList.Add($"G1 X0 Y0 Z0 P-{angle2} Q-{angle2} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt3 = { 0, 0, 0, -angle2, -angle2, 0 };
                        ikControlList.Add(tilt3);
                        gCodeList.Add($"G1 X0 Y0 Z0 P-{angle1} Q{angle1} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt4 = { 0, 0, 0, -angle1, angle1, 0 };
                        ikControlList.Add(tilt4);
                        
                    }
                    if (comboBoxStartDirect.Text == "4")
                    {
                        gCodeList.Add($"G1 X0 Y0 Z0 P{angle4} Q{angle4} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt1 = { 0, 0, 0, angle4, angle4, 0 };
                        ikControlList.Add(tilt1);
                        gCodeList.Add($"G1 X0 Y0 Z0 P{angle3} Q-{angle3} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt2 = { 0, 0, 0, angle3, -angle3, 0 };
                        ikControlList.Add(tilt2);
                        gCodeList.Add($"G1 X0 Y0 Z0 P-{angle1} Q{angle1} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt3 = { 0, 0, 0, -angle1, angle1, 0 };
                        ikControlList.Add(tilt3);
                        gCodeList.Add($"G1 X0 Y0 Z0 P-{angle2} Q-{angle2} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                        double[] tilt4 = { 0, 0, 0, -angle2, -angle2, 0 };
                        ikControlList.Add(tilt4);
                      
                    }
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
