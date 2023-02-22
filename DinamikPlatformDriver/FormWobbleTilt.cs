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
    public partial class FormWobbleTilt : Form
    {
        private InverseKinematic invKinematic;
        public FormWobbleTilt()
        {
            InitializeComponent();
        }
        int directionalChange;
        int tiltAngle;
        int velocity;
        int acceleration;
        int repetition;
        double angleIncrease;
        string path = "C:\\Users\\seher\\OneDrive - Elondor\\Desktop\\G Codes\\gcode.txt";
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
        private void FormWobbleTilt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void trackBarDirectionalChange_Scroll(object sender, EventArgs e)
        {
            directionalChange= trackBarDirectionalChange.Value; 
            labelDirectionalChange.Text=trackBarDirectionalChange.Value.ToString();
        }

        private void trackBarTiltAngle_Scroll(object sender, EventArgs e)
        {
            tiltAngle=trackBarTiltAngle.Value;
            labelTiltAngle.Text=trackBarTiltAngle.Value.ToString();
        }

        private void trackBarVelocity_Scroll(object sender, EventArgs e)
        {
            velocity= trackBarVelocity.Value;
            labelVelocity.Text=trackBarVelocity.Value.ToString();
        }

        private void trackBarAcc_Scroll(object sender, EventArgs e)
        {
            acceleration= trackBarAcc.Value;
            labelAcc.Text=trackBarAcc.Value.ToString(); 
        }
        public void generateGCode()
        {
            ikControlList = new List<double[]>();
            angleIncrease =   360 / directionalChange;
  
            if (radioBtnClockwise.Checked == true)
            {
                double angle = 90.00;
                int i = 0;
                while (i < directionalChange)
                {
                    double alfa = Math.Round(tiltAngle * Math.Cos(angle * Math.PI / 180), 2);
                    double beta = Math.Round(tiltAngle * Math.Sin(angle * Math.PI / 180), 2);
                    gCodeList.Add($"G1 X0 Y0 Z0 P{alfa} Q{beta} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axis1 = { 0, 0, 0, alfa, beta, 0 };
                    ikControlList.Add(axis1);
                    angle = angle + angleIncrease;
                    i = i + 1;
                }

            }
            if (radioBtnCounterclockwise.Checked == true)
            {
                double angle = 90;
                int i = 0;
                while (i < directionalChange)
                {
                    double alfa = Math.Round(tiltAngle * Math.Cos(angle * Math.PI / 180), 2);
                    double beta = Math.Round(tiltAngle * Math.Sin(angle * Math.PI / 180), 2);
                    gCodeList.Add($"G1 X0 Y0 Z0 P{alfa} Q{beta} U0 FP{velocity} EP{acceleration} EP-{acceleration} FQ{velocity} EQ{acceleration} EQ-{acceleration}");
                    double[] axis1 = { 0, 0, 0, alfa, beta, 0 };
                    ikControlList.Add(axis1);
                    angle = angle - angleIncrease;
                    i = i + 1;
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
