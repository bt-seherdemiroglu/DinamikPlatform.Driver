namespace DinamikPlatformDriver
{
    partial class FormButterfly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormButterfly));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStartDirect = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonSym = new System.Windows.Forms.RadioButton();
            this.radioButtonAsym = new System.Windows.Forms.RadioButton();
            this.trackBarTiltSym = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarTiltAsymMin = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarTiltAsymMax = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarVelocity = new System.Windows.Forms.TrackBar();
            this.trackBarAcc = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRepetition = new System.Windows.Forms.TextBox();
            this.btnStartButterfly = new System.Windows.Forms.Button();
            this.labelSym = new System.Windows.Forms.Label();
            this.labelAsymMin = new System.Windows.Forms.Label();
            this.labelAsymMax = new System.Windows.Forms.Label();
            this.labelVelocity = new System.Windows.Forms.Label();
            this.labelAcc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltSym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAsymMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAsymMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Direction:";
            // 
            // comboBoxStartDirect
            // 
            this.comboBoxStartDirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxStartDirect.FormattingEnabled = true;
            this.comboBoxStartDirect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxStartDirect.Location = new System.Drawing.Point(188, 156);
            this.comboBoxStartDirect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxStartDirect.Name = "comboBoxStartDirect";
            this.comboBoxStartDirect.Size = new System.Drawing.Size(136, 33);
            this.comboBoxStartDirect.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 328);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(240, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tilt Angle (deg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(400, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min";
            // 
            // radioButtonSym
            // 
            this.radioButtonSym.AutoSize = true;
            this.radioButtonSym.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonSym.Location = new System.Drawing.Point(18, 392);
            this.radioButtonSym.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonSym.Name = "radioButtonSym";
            this.radioButtonSym.Size = new System.Drawing.Size(144, 29);
            this.radioButtonSym.TabIndex = 5;
            this.radioButtonSym.TabStop = true;
            this.radioButtonSym.Text = "Symmetrical";
            this.radioButtonSym.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsym
            // 
            this.radioButtonAsym.AutoSize = true;
            this.radioButtonAsym.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonAsym.Location = new System.Drawing.Point(18, 479);
            this.radioButtonAsym.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonAsym.Name = "radioButtonAsym";
            this.radioButtonAsym.Size = new System.Drawing.Size(154, 29);
            this.radioButtonAsym.TabIndex = 6;
            this.radioButtonAsym.TabStop = true;
            this.radioButtonAsym.Text = "Asymmetrical";
            this.radioButtonAsym.UseVisualStyleBackColor = true;
            // 
            // trackBarTiltSym
            // 
            this.trackBarTiltSym.Location = new System.Drawing.Point(446, 379);
            this.trackBarTiltSym.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltSym.Maximum = 500;
            this.trackBarTiltSym.Name = "trackBarTiltSym";
            this.trackBarTiltSym.Size = new System.Drawing.Size(286, 69);
            this.trackBarTiltSym.TabIndex = 7;
            this.trackBarTiltSym.Scroll += new System.EventHandler(this.trackBarTiltSym_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(240, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tilt Angle (deg):";
            // 
            // trackBarTiltAsymMin
            // 
            this.trackBarTiltAsymMin.Location = new System.Drawing.Point(446, 479);
            this.trackBarTiltAsymMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltAsymMin.Maximum = 30;
            this.trackBarTiltAsymMin.Name = "trackBarTiltAsymMin";
            this.trackBarTiltAsymMin.Size = new System.Drawing.Size(286, 69);
            this.trackBarTiltAsymMin.TabIndex = 9;
            this.trackBarTiltAsymMin.Scroll += new System.EventHandler(this.trackBarTiltAsymMin_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(839, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max";
            // 
            // trackBarTiltAsymMax
            // 
            this.trackBarTiltAsymMax.Location = new System.Drawing.Point(903, 479);
            this.trackBarTiltAsymMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltAsymMax.Maximum = 500;
            this.trackBarTiltAsymMax.Name = "trackBarTiltAsymMax";
            this.trackBarTiltAsymMax.Size = new System.Drawing.Size(296, 69);
            this.trackBarTiltAsymMax.TabIndex = 11;
            this.trackBarTiltAsymMax.Scroll += new System.EventHandler(this.trackBarTiltAsymMax_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Velocity (deg/s):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 651);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Acceleration (deg/s ²):";
            // 
            // trackBarVelocity
            // 
            this.trackBarVelocity.Location = new System.Drawing.Point(274, 582);
            this.trackBarVelocity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarVelocity.Maximum = 60;
            this.trackBarVelocity.Name = "trackBarVelocity";
            this.trackBarVelocity.Size = new System.Drawing.Size(334, 69);
            this.trackBarVelocity.TabIndex = 14;
            this.trackBarVelocity.Scroll += new System.EventHandler(this.trackBarVelocity_Scroll);
            // 
            // trackBarAcc
            // 
            this.trackBarAcc.Location = new System.Drawing.Point(274, 651);
            this.trackBarAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarAcc.Maximum = 440;
            this.trackBarAcc.Name = "trackBarAcc";
            this.trackBarAcc.Size = new System.Drawing.Size(334, 69);
            this.trackBarAcc.TabIndex = 15;
            this.trackBarAcc.Scroll += new System.EventHandler(this.trackBarAcc_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 738);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Repetition:";
            // 
            // textBoxRepetition
            // 
            this.textBoxRepetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRepetition.Location = new System.Drawing.Point(274, 738);
            this.textBoxRepetition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRepetition.Name = "textBoxRepetition";
            this.textBoxRepetition.Size = new System.Drawing.Size(112, 30);
            this.textBoxRepetition.TabIndex = 17;
            this.textBoxRepetition.Text = "1";
            // 
            // btnStartButterfly
            // 
            this.btnStartButterfly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartButterfly.Location = new System.Drawing.Point(322, 820);
            this.btnStartButterfly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartButterfly.Name = "btnStartButterfly";
            this.btnStartButterfly.Size = new System.Drawing.Size(152, 58);
            this.btnStartButterfly.TabIndex = 18;
            this.btnStartButterfly.Text = "START";
            this.btnStartButterfly.UseVisualStyleBackColor = true;
            this.btnStartButterfly.Click += new System.EventHandler(this.btnStartButterfly_Click);
            // 
            // labelSym
            // 
            this.labelSym.AutoSize = true;
            this.labelSym.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSym.Location = new System.Drawing.Point(738, 379);
            this.labelSym.Name = "labelSym";
            this.labelSym.Size = new System.Drawing.Size(23, 25);
            this.labelSym.TabIndex = 19;
            this.labelSym.Text = "0";
            // 
            // labelAsymMin
            // 
            this.labelAsymMin.AutoSize = true;
            this.labelAsymMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAsymMin.Location = new System.Drawing.Point(755, 482);
            this.labelAsymMin.Name = "labelAsymMin";
            this.labelAsymMin.Size = new System.Drawing.Size(23, 25);
            this.labelAsymMin.TabIndex = 20;
            this.labelAsymMin.Text = "0";
            // 
            // labelAsymMax
            // 
            this.labelAsymMax.AutoSize = true;
            this.labelAsymMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAsymMax.Location = new System.Drawing.Point(1206, 485);
            this.labelAsymMax.Name = "labelAsymMax";
            this.labelAsymMax.Size = new System.Drawing.Size(23, 25);
            this.labelAsymMax.TabIndex = 21;
            this.labelAsymMax.Text = "0";
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVelocity.Location = new System.Drawing.Point(639, 582);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(23, 25);
            this.labelVelocity.TabIndex = 22;
            this.labelVelocity.Text = "0";
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAcc.Location = new System.Drawing.Point(639, 651);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(23, 25);
            this.labelAcc.TabIndex = 23;
            this.labelAcc.Text = "0";
            // 
            // FormButterfly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 891);
            this.Controls.Add(this.labelAcc);
            this.Controls.Add(this.labelVelocity);
            this.Controls.Add(this.labelAsymMax);
            this.Controls.Add(this.labelAsymMin);
            this.Controls.Add(this.labelSym);
            this.Controls.Add(this.btnStartButterfly);
            this.Controls.Add(this.textBoxRepetition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBarAcc);
            this.Controls.Add(this.trackBarVelocity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarTiltAsymMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarTiltAsymMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarTiltSym);
            this.Controls.Add(this.radioButtonAsym);
            this.Controls.Add(this.radioButtonSym);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxStartDirect);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormButterfly";
            this.Text = "FormButterfly";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltSym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAsymMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAsymMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStartDirect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonSym;
        private System.Windows.Forms.RadioButton radioButtonAsym;
        private System.Windows.Forms.TrackBar trackBarTiltSym;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarTiltAsymMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarTiltAsymMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarVelocity;
        private System.Windows.Forms.TrackBar trackBarAcc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRepetition;
        private System.Windows.Forms.Button btnStartButterfly;
        private System.Windows.Forms.Label labelSym;
        private System.Windows.Forms.Label labelAsymMin;
        private System.Windows.Forms.Label labelAsymMax;
        private System.Windows.Forms.Label labelVelocity;
        private System.Windows.Forms.Label labelAcc;
    }
}