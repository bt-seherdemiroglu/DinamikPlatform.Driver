namespace DinamikPlatformDriver
{
    partial class FormEasyRotation
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
            this.trackBarTiltAcc = new System.Windows.Forms.TrackBar();
            this.trackBarTiltVel = new System.Windows.Forms.TrackBar();
            this.trackBarTiltAngle = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRepetition = new System.Windows.Forms.TextBox();
            this.trackBarRotAcc = new System.Windows.Forms.TrackBar();
            this.trackBarRotVel = new System.Windows.Forms.TrackBar();
            this.trackBarRotDeg = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtnClockwise = new System.Windows.Forms.RadioButton();
            this.radioBtnCounterclck = new System.Windows.Forms.RadioButton();
            this.labelRotDeg = new System.Windows.Forms.Label();
            this.labelRotVel = new System.Windows.Forms.Label();
            this.labelRotAcc = new System.Windows.Forms.Label();
            this.labelTiltAng = new System.Windows.Forms.Label();
            this.labelTiltVel = new System.Windows.Forms.Label();
            this.labelTiltAcc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotDeg)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarTiltAcc
            // 
            this.trackBarTiltAcc.Location = new System.Drawing.Point(871, 382);
            this.trackBarTiltAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltAcc.Maximum = 400;
            this.trackBarTiltAcc.Name = "trackBarTiltAcc";
            this.trackBarTiltAcc.Size = new System.Drawing.Size(240, 69);
            this.trackBarTiltAcc.TabIndex = 33;
            this.trackBarTiltAcc.Scroll += new System.EventHandler(this.trackBarTiltAcc_Scroll);
            // 
            // trackBarTiltVel
            // 
            this.trackBarTiltVel.Location = new System.Drawing.Point(871, 272);
            this.trackBarTiltVel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltVel.Maximum = 80;
            this.trackBarTiltVel.Name = "trackBarTiltVel";
            this.trackBarTiltVel.Size = new System.Drawing.Size(240, 69);
            this.trackBarTiltVel.TabIndex = 32;
            this.trackBarTiltVel.Scroll += new System.EventHandler(this.trackBarTiltVel_Scroll);
            // 
            // trackBarTiltAngle
            // 
            this.trackBarTiltAngle.Location = new System.Drawing.Point(871, 165);
            this.trackBarTiltAngle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltAngle.Maximum = 500;
            this.trackBarTiltAngle.Name = "trackBarTiltAngle";
            this.trackBarTiltAngle.Size = new System.Drawing.Size(240, 69);
            this.trackBarTiltAngle.TabIndex = 31;
            this.trackBarTiltAngle.Scroll += new System.EventHandler(this.trackBarTiltAngle_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(604, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tilt Acceleration (deg/s ²):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(604, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tilt Velocity (deg):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(604, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Tilt Angle:";
            // 
            // textBoxRepetition
            // 
            this.textBoxRepetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRepetition.Location = new System.Drawing.Point(332, 528);
            this.textBoxRepetition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRepetition.Name = "textBoxRepetition";
            this.textBoxRepetition.Size = new System.Drawing.Size(112, 30);
            this.textBoxRepetition.TabIndex = 27;
            this.textBoxRepetition.Text = "1";
            // 
            // trackBarRotAcc
            // 
            this.trackBarRotAcc.Location = new System.Drawing.Point(305, 396);
            this.trackBarRotAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarRotAcc.Maximum = 400;
            this.trackBarRotAcc.Name = "trackBarRotAcc";
            this.trackBarRotAcc.Size = new System.Drawing.Size(246, 69);
            this.trackBarRotAcc.TabIndex = 26;
            this.trackBarRotAcc.Scroll += new System.EventHandler(this.trackBarRotAcc_Scroll);
            // 
            // trackBarRotVel
            // 
            this.trackBarRotVel.Location = new System.Drawing.Point(305, 298);
            this.trackBarRotVel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarRotVel.Maximum = 80;
            this.trackBarRotVel.Name = "trackBarRotVel";
            this.trackBarRotVel.Size = new System.Drawing.Size(246, 69);
            this.trackBarRotVel.TabIndex = 25;
            this.trackBarRotVel.Scroll += new System.EventHandler(this.trackBarRotVel_Scroll);
            // 
            // trackBarRotDeg
            // 
            this.trackBarRotDeg.Location = new System.Drawing.Point(305, 190);
            this.trackBarRotDeg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarRotDeg.Maximum = 200;
            this.trackBarRotDeg.Name = "trackBarRotDeg";
            this.trackBarRotDeg.Size = new System.Drawing.Size(246, 69);
            this.trackBarRotDeg.TabIndex = 24;
            this.trackBarRotDeg.Scroll += new System.EventHandler(this.trackBarRotDeg_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 528);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Repetition:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rotation Acceleration (deg/s ²):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rotation Velocity (deg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rotation Degree:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Start Direction:";
            // 
            // radioBtnClockwise
            // 
            this.radioBtnClockwise.AutoSize = true;
            this.radioBtnClockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnClockwise.Location = new System.Drawing.Point(321, 89);
            this.radioBtnClockwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnClockwise.Name = "radioBtnClockwise";
            this.radioBtnClockwise.Size = new System.Drawing.Size(126, 29);
            this.radioBtnClockwise.TabIndex = 34;
            this.radioBtnClockwise.TabStop = true;
            this.radioBtnClockwise.Text = "Clockwise";
            this.radioBtnClockwise.UseVisualStyleBackColor = true;
            // 
            // radioBtnCounterclck
            // 
            this.radioBtnCounterclck.AutoSize = true;
            this.radioBtnCounterclck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnCounterclck.Location = new System.Drawing.Point(565, 89);
            this.radioBtnCounterclck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnCounterclck.Name = "radioBtnCounterclck";
            this.radioBtnCounterclck.Size = new System.Drawing.Size(191, 29);
            this.radioBtnCounterclck.TabIndex = 35;
            this.radioBtnCounterclck.TabStop = true;
            this.radioBtnCounterclck.Text = "Counterclockwise";
            this.radioBtnCounterclck.UseVisualStyleBackColor = true;
            // 
            // labelRotDeg
            // 
            this.labelRotDeg.AutoSize = true;
            this.labelRotDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRotDeg.Location = new System.Drawing.Point(559, 190);
            this.labelRotDeg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRotDeg.Name = "labelRotDeg";
            this.labelRotDeg.Size = new System.Drawing.Size(23, 25);
            this.labelRotDeg.TabIndex = 36;
            this.labelRotDeg.Text = "0";
            // 
            // labelRotVel
            // 
            this.labelRotVel.AutoSize = true;
            this.labelRotVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRotVel.Location = new System.Drawing.Point(560, 298);
            this.labelRotVel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRotVel.Name = "labelRotVel";
            this.labelRotVel.Size = new System.Drawing.Size(23, 25);
            this.labelRotVel.TabIndex = 37;
            this.labelRotVel.Text = "0";
            // 
            // labelRotAcc
            // 
            this.labelRotAcc.AutoSize = true;
            this.labelRotAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRotAcc.Location = new System.Drawing.Point(559, 396);
            this.labelRotAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRotAcc.Name = "labelRotAcc";
            this.labelRotAcc.Size = new System.Drawing.Size(23, 25);
            this.labelRotAcc.TabIndex = 38;
            this.labelRotAcc.Text = "0";
            // 
            // labelTiltAng
            // 
            this.labelTiltAng.AutoSize = true;
            this.labelTiltAng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTiltAng.Location = new System.Drawing.Point(1132, 165);
            this.labelTiltAng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTiltAng.Name = "labelTiltAng";
            this.labelTiltAng.Size = new System.Drawing.Size(23, 25);
            this.labelTiltAng.TabIndex = 39;
            this.labelTiltAng.Text = "0";
            // 
            // labelTiltVel
            // 
            this.labelTiltVel.AutoSize = true;
            this.labelTiltVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTiltVel.Location = new System.Drawing.Point(1132, 272);
            this.labelTiltVel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTiltVel.Name = "labelTiltVel";
            this.labelTiltVel.Size = new System.Drawing.Size(23, 25);
            this.labelTiltVel.TabIndex = 40;
            this.labelTiltVel.Text = "0";
            // 
            // labelTiltAcc
            // 
            this.labelTiltAcc.AutoSize = true;
            this.labelTiltAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTiltAcc.Location = new System.Drawing.Point(1132, 382);
            this.labelTiltAcc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTiltAcc.Name = "labelTiltAcc";
            this.labelTiltAcc.Size = new System.Drawing.Size(23, 25);
            this.labelTiltAcc.TabIndex = 41;
            this.labelTiltAcc.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(460, 686);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 42;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEasyRotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 874);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTiltAcc);
            this.Controls.Add(this.labelTiltVel);
            this.Controls.Add(this.labelTiltAng);
            this.Controls.Add(this.labelRotAcc);
            this.Controls.Add(this.labelRotVel);
            this.Controls.Add(this.labelRotDeg);
            this.Controls.Add(this.radioBtnCounterclck);
            this.Controls.Add(this.radioBtnClockwise);
            this.Controls.Add(this.trackBarTiltAcc);
            this.Controls.Add(this.trackBarTiltVel);
            this.Controls.Add(this.trackBarTiltAngle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRepetition);
            this.Controls.Add(this.trackBarRotAcc);
            this.Controls.Add(this.trackBarRotVel);
            this.Controls.Add(this.trackBarRotDeg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEasyRotation";
            this.Text = "Easy Rotation";
            this.Load += new System.EventHandler(this.FormEasyRotation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotDeg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarTiltAcc;
        private System.Windows.Forms.TrackBar trackBarTiltVel;
        private System.Windows.Forms.TrackBar trackBarTiltAngle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRepetition;
        private System.Windows.Forms.TrackBar trackBarRotAcc;
        private System.Windows.Forms.TrackBar trackBarRotVel;
        private System.Windows.Forms.TrackBar trackBarRotDeg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnClockwise;
        private System.Windows.Forms.RadioButton radioBtnCounterclck;
        private System.Windows.Forms.Label labelRotDeg;
        private System.Windows.Forms.Label labelRotVel;
        private System.Windows.Forms.Label labelRotAcc;
        private System.Windows.Forms.Label labelTiltAng;
        private System.Windows.Forms.Label labelTiltVel;
        private System.Windows.Forms.Label labelTiltAcc;
        private System.Windows.Forms.Button button1;
    }
}