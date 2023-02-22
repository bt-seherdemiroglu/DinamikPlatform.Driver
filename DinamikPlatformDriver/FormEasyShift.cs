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
    public partial class FormEasyShift : Form
    {
        private InverseKinematic invKinematic;
        public FormEasyShift()
        {
            InitializeComponent();
        }
        int shiftAmount;
        int shiftVelocity;
        int shiftAcc;
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
        private void FormEasyShift_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, String.Empty);
            generateGCode();
            ikControl();
            
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
            shiftAmount=trackBarShiftAmount.Value;
            labelShiftAmount.Text=trackBarShiftAmount.Value.ToString();
            
        }

        private void trackBarShiftVelocity_Scroll(object sender, EventArgs e)
        {
            shiftVelocity=trackBarShiftVelocity.Value;
            labelShiftVel.Text=trackBarShiftVelocity.Value.ToString();
        }

        private void trackBarShiftAcc_Scroll(object sender, EventArgs e)
        {
            shiftAcc=trackBarShiftAcc.Value;
            labelShiftAcc.Text=trackBarShiftAcc.Value.ToString();
        }

        private void trackBarTiltAngle_Scroll(object sender, EventArgs e)
        {
            tiltAngle=trackBarTiltAngle.Value;
            labelTiltAngle.Text=trackBarTiltAngle.Value.ToString();
        }

        private void trackBarTiltVelocity_Scroll(object sender, EventArgs e)
        {
            tiltVelocity=trackBarTiltVelocity.Value;    
            labelTiltVel.Text=trackBarTiltVelocity.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            tiltAcc=trackBarTiltAcc.Value;
            labelTiltAcc.Text=trackBarTiltAcc.Value.ToString();
        }

        public void generateGCode()
        {
            ikControlList = new List<double[]>();
            if (radioBtnClockwise.Checked == true)
            {
                if (checkBoxFront.Checked == true)
                {
                    gCodeList.Add($"G1 X{shiftAmount} Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                    double[] axisF1 = { shiftAmount, 0, 0, 0, 0, 0 };
                    ikControlList.Add(axisF1);
                    gCodeList.Add($"G1 X{shiftAmount} Y0 Z0 P0 Q-{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF2 = { shiftAmount, 0, 0, 0, -tiltAngle, 0 };
                    ikControlList.Add(axisF2);
                    gCodeList.Add($"G1 X{shiftAmount} Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF3 = { shiftAmount, 0, 0, 0, 0, 0 };
                    ikControlList.Add(axisF3);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                  
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF4 = { 0, 0, 0, 0, tiltAngle, 0 };
                    ikControlList.Add(axisF4);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
             
                }
                if (checkBoxFrontR.Checked == true)
                {
                    gCodeList.Add($"G1 X{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF5 = { shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF5);
                    gCodeList.Add($"G1 X{shiftAmount} Y-{shiftAmount} Z0 P{tiltAngle} Q-{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF6 = { shiftAmount, -shiftAmount, 0, tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisF6);
                    gCodeList.Add($"G1 X{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF7 = { shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF7);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngle} Q{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF8 = { 0, 0, 0, -tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisF8);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxRight.Checked == true)
                {
                    gCodeList.Add($"G1 X0 Y-{shiftAmount} Z0 P0 Q0 U0 FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF9 = { 0, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF9);
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P-{tiltAngle} Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF10 = { 0, shiftAmount, 0, -tiltAngle, 0, 0 };
                    ikControlList.Add(axisF10);
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF11 = { 0, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF11);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{shiftVelocity} EQ{shiftAcc} EQ-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF12 = { 0, 0, 0, tiltAngle, 0, 0 };
                    ikControlList.Add(axisF12);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxBackR.Checked == true)
                {
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                    double[] axisF13 = { -shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF13);
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P{tiltAngle} Q{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF14 = { -shiftAmount, -shiftAmount, 0, tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisF14);
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF15 = { -shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF15);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngle} Q-{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF16 = { 0, 0, 0, -tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisF16);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
            
                if (checkBoxBack.Checked == true)
                {
                    gCodeList.Add($"G1 X-{shiftAmount} Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                    double[] axisF17 = { -shiftAmount, 0, 0, 0, 0, 0 };
                    ikControlList.Add(axisF17);
                    gCodeList.Add($"G1 X-{shiftAmount} Y0 Z0 P0 Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF18 = { -shiftAmount, 0, 0, 0, tiltAngle, 0 };
                    ikControlList.Add(axisF18);
                    gCodeList.Add($"G1 X-{shiftAmount} Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF19 = { -shiftAmount, 0, 0, 0, 0, 0 };
                    ikControlList.Add(axisF19);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q-{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF20 = { 0, 0, 0, 0, -tiltAngle, 0 };
                    ikControlList.Add(axisF20);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxBackL.Checked == true)
                {
                    gCodeList.Add($"G1 X-{shiftAmount} Y{shiftAmount} Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF21 = { -shiftAmount, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF21);
                    gCodeList.Add($"G1 X-{shiftAmount} Y{shiftAmount} Z0 P-{tiltAngle} Q{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF22 = { -shiftAmount, shiftAmount, 0, -tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisF22);
                    gCodeList.Add($"G1 X-{shiftAmount} Y{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF23 = { -shiftAmount, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF23);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q-{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF24 = { 0, 0, 0, tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisF24);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxLeft.Checked == true)
                {
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P0 Q0 U0 FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF25 = { 0, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF25);
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P-{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                    double[] axisF26 = { 0, shiftAmount, 0, -tiltAngle, 0, 0 };
                    ikControlList.Add(axisF26);
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                    double[] axisF27 = { 0, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF27);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                    double[] axisF28 = { 0, 0, 0, tiltAngle, 0, 0 };
                    ikControlList.Add(axisF28);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                    //
                }
                if (checkBoxFrontL.Checked == true)
                {
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF29 = { -shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF29);
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P-{tiltAngle} Q-{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF30 = { -shiftAmount, -shiftAmount, 0, -tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisF30);
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF31 = { -shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF31);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF32 = { 0, 0, 0, tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisF32);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
        
            }
            if(radioBtnCounterclck.Checked == true)
            {
                if (checkBoxFront.Checked == true)
                {
                    gCodeList.Add($"G1 X{shiftAmount} Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                    double[] axisF1 = { shiftAmount, 0, 0, 0, 0, 0 };
                    ikControlList.Add(axisF1);
                    gCodeList.Add($"G1 X{shiftAmount} Y0 Z0 P0 Q-{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF2 = { shiftAmount, 0, 0, 0, -tiltAngle, 0 };
                    ikControlList.Add(axisF2);
                    gCodeList.Add($"G1 X{shiftAmount} Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF3 = { shiftAmount, 0, 0, 0, 0, 0 };
                    ikControlList.Add(axisF3);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");

                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF4 = { 0, 0, 0, 0, tiltAngle, 0 };
                    ikControlList.Add(axisF4);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                }
                if (checkBoxFrontL.Checked == true)
                {
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF5 = { -shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF5);
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P-{tiltAngle} Q-{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF6 = { -shiftAmount, -shiftAmount, 0, -tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisF6);
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF7 = { -shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF7);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF8 = { 0, 0, 0, tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisF8);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxLeft.Checked == true)
                {
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P0 Q0 U0 FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF9 = { 0, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF9);
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P-{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                    double[] axisF10 = { 0, shiftAmount, 0, -tiltAngle, 0, 0 };
                    ikControlList.Add(axisF10);
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                    double[] axisF11 = { 0, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF11);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                    double[] axisF12 = { 0, 0, 0, tiltAngle, 0, 0 };
                    ikControlList.Add(axisF12);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc}");
                    //
                }
                if (checkBoxBackL.Checked == true)
                {
                    gCodeList.Add($"G1 X-{shiftAmount} Y{shiftAmount} Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF13 = { -shiftAmount, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF13);
                    gCodeList.Add($"G1 X-{shiftAmount} Y{shiftAmount} Z0 P-{tiltAngle} Q{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF14 = { -shiftAmount, shiftAmount, 0, -tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisF14);
                    gCodeList.Add($"G1 X-{shiftAmount} Y{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF15 = { -shiftAmount, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF15);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q-{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF16 = { 0, 0, 0, tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisF16);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxBack.Checked == true)
                {
                    gCodeList.Add($"G1 X-{shiftAmount} Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                    double[] axisF17 = { -shiftAmount, 0, 0, 0, 0, 0 };
                    ikControlList.Add(axisF17);
                    gCodeList.Add($"G1 X-{shiftAmount} Y0 Z0 P0 Q{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF18 = { -shiftAmount, 0, 0, 0, tiltAngle, 0 };
                    ikControlList.Add(axisF18);
                    gCodeList.Add($"G1 X-{shiftAmount} Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF19 = { -shiftAmount, 0, 0, 0, 0, 0 };
                    ikControlList.Add(axisF19);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q-{tiltAngle} U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF20 = { 0, 0, 0, 0, -tiltAngle, 0 };
                    ikControlList.Add(axisF20);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxBackR.Checked == true)
                {
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc}");
                    double[] axisF21 = { -shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF21);
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P{tiltAngle} Q{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF22 = { -shiftAmount, -shiftAmount, 0, tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisF22);
                    gCodeList.Add($"G1 X-{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF23 = { -shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF23);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngle} Q-{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF24 = { 0, 0, 0, -tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisF24);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxRight.Checked == true)
                {
                    gCodeList.Add($"G1 X0 Y-{shiftAmount} Z0 P0 Q0 U0 FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF25 = { 0, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF25);
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P-{tiltAngle} Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF26 = { 0, shiftAmount, 0, -tiltAngle, 0, 0 };
                    ikControlList.Add(axisF26);
                    gCodeList.Add($"G1 X0 Y{shiftAmount} Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF27 = { 0, shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF27);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{shiftVelocity} EQ{shiftAcc} EQ-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P{tiltAngle} Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF28 = { 0, 0, 0, tiltAngle, 0, 0 };
                    ikControlList.Add(axisF28);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
                if (checkBoxFrontR.Checked == true)
                {
                    gCodeList.Add($"G1 X{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    double[] axisF29 = { shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF29);
                    gCodeList.Add($"G1 X{shiftAmount} Y-{shiftAmount} Z0 P{tiltAngle} Q-{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF30 = { shiftAmount, -shiftAmount, 0, tiltAngle, -tiltAngle, 0 };
                    ikControlList.Add(axisF30);
                    gCodeList.Add($"G1 X{shiftAmount} Y-{shiftAmount} Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF31 = { shiftAmount, -shiftAmount, 0, 0, 0, 0 };
                    ikControlList.Add(axisF31);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FX{shiftVelocity} EX{shiftAcc} EX-{shiftAcc} FY{shiftVelocity} EY{shiftAcc} EY-{shiftAcc}");
                    //
                    gCodeList.Add($"G1 X0 Y0 Z0 P-{tiltAngle} Q{tiltAngle} U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    double[] axisF32 = { 0, 0, 0, -tiltAngle, tiltAngle, 0 };
                    ikControlList.Add(axisF32);
                    gCodeList.Add($"G1 X0 Y0 Z0 P0 Q0 U0 FP{tiltVelocity} EP{tiltAcc} EP-{tiltAcc} FQ{tiltVelocity} EQ{tiltAcc} EQ-{tiltAcc}");
                    //
                }
            }
        }
        public void ikControl()
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
