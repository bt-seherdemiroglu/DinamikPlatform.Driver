namespace DinamikPlatformDriver
{
    partial class FormEasyShift
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtnClockwise = new System.Windows.Forms.RadioButton();
            this.radioBtnCounterclck = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxFront = new System.Windows.Forms.CheckBox();
            this.checkBoxBack = new System.Windows.Forms.CheckBox();
            this.checkBoxRight = new System.Windows.Forms.CheckBox();
            this.checkBoxLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxFrontR = new System.Windows.Forms.CheckBox();
            this.checkBoxFrontL = new System.Windows.Forms.CheckBox();
            this.checkBoxBackR = new System.Windows.Forms.CheckBox();
            this.checkBoxBackL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarShiftAmount = new System.Windows.Forms.TrackBar();
            this.trackBarShiftVelocity = new System.Windows.Forms.TrackBar();
            this.trackBarShiftAcc = new System.Windows.Forms.TrackBar();
            this.labelShiftAmount = new System.Windows.Forms.Label();
            this.labelShiftVel = new System.Windows.Forms.Label();
            this.labelShiftAcc = new System.Windows.Forms.Label();
            this.labelTiltAcc = new System.Windows.Forms.Label();
            this.labelTiltVel = new System.Windows.Forms.Label();
            this.labelTiltAngle = new System.Windows.Forms.Label();
            this.trackBarTiltAcc = new System.Windows.Forms.TrackBar();
            this.trackBarTiltVelocity = new System.Windows.Forms.TrackBar();
            this.trackBarTiltAngle = new System.Windows.Forms.TrackBar();
            this.label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxRepetition = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Direction:";
            // 
            // radioBtnClockwise
            // 
            this.radioBtnClockwise.AutoSize = true;
            this.radioBtnClockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnClockwise.Location = new System.Drawing.Point(250, 100);
            this.radioBtnClockwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnClockwise.Name = "radioBtnClockwise";
            this.radioBtnClockwise.Size = new System.Drawing.Size(126, 29);
            this.radioBtnClockwise.TabIndex = 1;
            this.radioBtnClockwise.TabStop = true;
            this.radioBtnClockwise.Text = "Clockwise";
            this.radioBtnClockwise.UseVisualStyleBackColor = true;
            // 
            // radioBtnCounterclck
            // 
            this.radioBtnCounterclck.AutoSize = true;
            this.radioBtnCounterclck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnCounterclck.Location = new System.Drawing.Point(506, 104);
            this.radioBtnCounterclck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnCounterclck.Name = "radioBtnCounterclck";
            this.radioBtnCounterclck.Size = new System.Drawing.Size(191, 29);
            this.radioBtnCounterclck.TabIndex = 2;
            this.radioBtnCounterclck.TabStop = true;
            this.radioBtnCounterclck.Text = "Counterclockwise";
            this.radioBtnCounterclck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shift Direction:";
            // 
            // checkBoxFront
            // 
            this.checkBoxFront.AutoSize = true;
            this.checkBoxFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxFront.Location = new System.Drawing.Point(250, 168);
            this.checkBoxFront.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFront.Name = "checkBoxFront";
            this.checkBoxFront.Size = new System.Drawing.Size(83, 29);
            this.checkBoxFront.TabIndex = 4;
            this.checkBoxFront.Text = "Front";
            this.checkBoxFront.UseVisualStyleBackColor = true;
            // 
            // checkBoxBack
            // 
            this.checkBoxBack.AutoSize = true;
            this.checkBoxBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxBack.Location = new System.Drawing.Point(250, 205);
            this.checkBoxBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxBack.Name = "checkBoxBack";
            this.checkBoxBack.Size = new System.Drawing.Size(82, 29);
            this.checkBoxBack.TabIndex = 5;
            this.checkBoxBack.Text = "Back";
            this.checkBoxBack.UseVisualStyleBackColor = true;
            // 
            // checkBoxRight
            // 
            this.checkBoxRight.AutoSize = true;
            this.checkBoxRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxRight.Location = new System.Drawing.Point(250, 242);
            this.checkBoxRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxRight.Name = "checkBoxRight";
            this.checkBoxRight.Size = new System.Drawing.Size(82, 29);
            this.checkBoxRight.TabIndex = 6;
            this.checkBoxRight.Text = "Right";
            this.checkBoxRight.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeft
            // 
            this.checkBoxLeft.AutoSize = true;
            this.checkBoxLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxLeft.Location = new System.Drawing.Point(250, 280);
            this.checkBoxLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxLeft.Name = "checkBoxLeft";
            this.checkBoxLeft.Size = new System.Drawing.Size(70, 29);
            this.checkBoxLeft.TabIndex = 7;
            this.checkBoxLeft.Text = "Left";
            this.checkBoxLeft.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrontR
            // 
            this.checkBoxFrontR.AutoSize = true;
            this.checkBoxFrontR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxFrontR.Location = new System.Drawing.Point(379, 168);
            this.checkBoxFrontR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFrontR.Name = "checkBoxFrontR";
            this.checkBoxFrontR.Size = new System.Drawing.Size(103, 29);
            this.checkBoxFrontR.TabIndex = 8;
            this.checkBoxFrontR.Text = "Front-R";
            this.checkBoxFrontR.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrontL
            // 
            this.checkBoxFrontL.AutoSize = true;
            this.checkBoxFrontL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxFrontL.Location = new System.Drawing.Point(379, 205);
            this.checkBoxFrontL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFrontL.Name = "checkBoxFrontL";
            this.checkBoxFrontL.Size = new System.Drawing.Size(101, 29);
            this.checkBoxFrontL.TabIndex = 9;
            this.checkBoxFrontL.Text = "Front-L";
            this.checkBoxFrontL.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackR
            // 
            this.checkBoxBackR.AutoSize = true;
            this.checkBoxBackR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxBackR.Location = new System.Drawing.Point(379, 242);
            this.checkBoxBackR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxBackR.Name = "checkBoxBackR";
            this.checkBoxBackR.Size = new System.Drawing.Size(102, 29);
            this.checkBoxBackR.TabIndex = 10;
            this.checkBoxBackR.Text = "Back-R";
            this.checkBoxBackR.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackL
            // 
            this.checkBoxBackL.AutoSize = true;
            this.checkBoxBackL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxBackL.Location = new System.Drawing.Point(379, 280);
            this.checkBoxBackL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxBackL.Name = "checkBoxBackL";
            this.checkBoxBackL.Size = new System.Drawing.Size(100, 29);
            this.checkBoxBackL.TabIndex = 11;
            this.checkBoxBackL.Text = "Back-L";
            this.checkBoxBackL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Shift Amount (mm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shift Velocity (deg/s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Shift Acceleration (deg/s ²):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 680);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Repetition:";
            // 
            // trackBarShiftAmount
            // 
            this.trackBarShiftAmount.Location = new System.Drawing.Point(271, 370);
            this.trackBarShiftAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarShiftAmount.Maximum = 50;
            this.trackBarShiftAmount.Name = "trackBarShiftAmount";
            this.trackBarShiftAmount.Size = new System.Drawing.Size(210, 69);
            this.trackBarShiftAmount.TabIndex = 16;
            this.trackBarShiftAmount.Scroll += new System.EventHandler(this.trackBarShiftAmount_Scroll);
            // 
            // trackBarShiftVelocity
            // 
            this.trackBarShiftVelocity.Location = new System.Drawing.Point(271, 460);
            this.trackBarShiftVelocity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarShiftVelocity.Name = "trackBarShiftVelocity";
            this.trackBarShiftVelocity.Size = new System.Drawing.Size(210, 69);
            this.trackBarShiftVelocity.TabIndex = 17;
            this.trackBarShiftVelocity.Scroll += new System.EventHandler(this.trackBarShiftVelocity_Scroll);
            // 
            // trackBarShiftAcc
            // 
            this.trackBarShiftAcc.Location = new System.Drawing.Point(271, 569);
            this.trackBarShiftAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarShiftAcc.Name = "trackBarShiftAcc";
            this.trackBarShiftAcc.Size = new System.Drawing.Size(210, 69);
            this.trackBarShiftAcc.TabIndex = 18;
            this.trackBarShiftAcc.Scroll += new System.EventHandler(this.trackBarShiftAcc_Scroll);
            // 
            // labelShiftAmount
            // 
            this.labelShiftAmount.AutoSize = true;
            this.labelShiftAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelShiftAmount.Location = new System.Drawing.Point(511, 370);
            this.labelShiftAmount.Name = "labelShiftAmount";
            this.labelShiftAmount.Size = new System.Drawing.Size(23, 25);
            this.labelShiftAmount.TabIndex = 19;
            this.labelShiftAmount.Text = "0";
            // 
            // labelShiftVel
            // 
            this.labelShiftVel.AutoSize = true;
            this.labelShiftVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelShiftVel.Location = new System.Drawing.Point(511, 460);
            this.labelShiftVel.Name = "labelShiftVel";
            this.labelShiftVel.Size = new System.Drawing.Size(23, 25);
            this.labelShiftVel.TabIndex = 20;
            this.labelShiftVel.Text = "0";
            // 
            // labelShiftAcc
            // 
            this.labelShiftAcc.AutoSize = true;
            this.labelShiftAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelShiftAcc.Location = new System.Drawing.Point(511, 569);
            this.labelShiftAcc.Name = "labelShiftAcc";
            this.labelShiftAcc.Size = new System.Drawing.Size(23, 25);
            this.labelShiftAcc.TabIndex = 21;
            this.labelShiftAcc.Text = "0";
            // 
            // labelTiltAcc
            // 
            this.labelTiltAcc.AutoSize = true;
            this.labelTiltAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTiltAcc.Location = new System.Drawing.Point(1068, 569);
            this.labelTiltAcc.Name = "labelTiltAcc";
            this.labelTiltAcc.Size = new System.Drawing.Size(23, 25);
            this.labelTiltAcc.TabIndex = 30;
            this.labelTiltAcc.Text = "0";
            // 
            // labelTiltVel
            // 
            this.labelTiltVel.AutoSize = true;
            this.labelTiltVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTiltVel.Location = new System.Drawing.Point(1068, 460);
            this.labelTiltVel.Name = "labelTiltVel";
            this.labelTiltVel.Size = new System.Drawing.Size(23, 25);
            this.labelTiltVel.TabIndex = 29;
            this.labelTiltVel.Text = "0";
            // 
            // labelTiltAngle
            // 
            this.labelTiltAngle.AutoSize = true;
            this.labelTiltAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTiltAngle.Location = new System.Drawing.Point(1068, 370);
            this.labelTiltAngle.Name = "labelTiltAngle";
            this.labelTiltAngle.Size = new System.Drawing.Size(23, 25);
            this.labelTiltAngle.TabIndex = 28;
            this.labelTiltAngle.Text = "0";
            // 
            // trackBarTiltAcc
            // 
            this.trackBarTiltAcc.Location = new System.Drawing.Point(826, 569);
            this.trackBarTiltAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltAcc.Name = "trackBarTiltAcc";
            this.trackBarTiltAcc.Size = new System.Drawing.Size(210, 69);
            this.trackBarTiltAcc.TabIndex = 27;
            this.trackBarTiltAcc.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBarTiltVelocity
            // 
            this.trackBarTiltVelocity.Location = new System.Drawing.Point(826, 460);
            this.trackBarTiltVelocity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltVelocity.Name = "trackBarTiltVelocity";
            this.trackBarTiltVelocity.Size = new System.Drawing.Size(210, 69);
            this.trackBarTiltVelocity.TabIndex = 26;
            this.trackBarTiltVelocity.Scroll += new System.EventHandler(this.trackBarTiltVelocity_Scroll);
            // 
            // trackBarTiltAngle
            // 
            this.trackBarTiltAngle.Location = new System.Drawing.Point(826, 370);
            this.trackBarTiltAngle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltAngle.Maximum = 400;
            this.trackBarTiltAngle.Name = "trackBarTiltAngle";
            this.trackBarTiltAngle.Size = new System.Drawing.Size(210, 69);
            this.trackBarTiltAngle.TabIndex = 25;
            this.trackBarTiltAngle.Scroll += new System.EventHandler(this.trackBarTiltAngle_Scroll);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(579, 569);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(237, 25);
            this.label.TabIndex = 24;
            this.label.Text = "Tilt Acceleration (deg/s ²):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(577, 472);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tilt Velocity (deg/s):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(579, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "Tilt Angle (deg):";
            // 
            // textBoxRepetition
            // 
            this.textBoxRepetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRepetition.Location = new System.Drawing.Point(256, 680);
            this.textBoxRepetition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRepetition.Name = "textBoxRepetition";
            this.textBoxRepetition.Size = new System.Drawing.Size(112, 30);
            this.textBoxRepetition.TabIndex = 31;
            this.textBoxRepetition.Text = "1";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(389, 786);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 52);
            this.btnStart.TabIndex = 32;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormEasyShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 874);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBoxRepetition);
            this.Controls.Add(this.labelTiltAcc);
            this.Controls.Add(this.labelTiltVel);
            this.Controls.Add(this.labelTiltAngle);
            this.Controls.Add(this.trackBarTiltAcc);
            this.Controls.Add(this.trackBarTiltVelocity);
            this.Controls.Add(this.trackBarTiltAngle);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelShiftAcc);
            this.Controls.Add(this.labelShiftVel);
            this.Controls.Add(this.labelShiftAmount);
            this.Controls.Add(this.trackBarShiftAcc);
            this.Controls.Add(this.trackBarShiftVelocity);
            this.Controls.Add(this.trackBarShiftAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxBackL);
            this.Controls.Add(this.checkBoxBackR);
            this.Controls.Add(this.checkBoxFrontL);
            this.Controls.Add(this.checkBoxFrontR);
            this.Controls.Add(this.checkBoxLeft);
            this.Controls.Add(this.checkBoxRight);
            this.Controls.Add(this.checkBoxBack);
            this.Controls.Add(this.checkBoxFront);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnCounterclck);
            this.Controls.Add(this.radioBtnClockwise);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEasyShift";
            this.Text = "EasyShift";
            this.Load += new System.EventHandler(this.FormEasyShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShiftAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnClockwise;
        private System.Windows.Forms.RadioButton radioBtnCounterclck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxFront;
        private System.Windows.Forms.CheckBox checkBoxBack;
        private System.Windows.Forms.CheckBox checkBoxRight;
        private System.Windows.Forms.CheckBox checkBoxLeft;
        private System.Windows.Forms.CheckBox checkBoxFrontR;
        private System.Windows.Forms.CheckBox checkBoxFrontL;
        private System.Windows.Forms.CheckBox checkBoxBackR;
        private System.Windows.Forms.CheckBox checkBoxBackL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarShiftAmount;
        private System.Windows.Forms.TrackBar trackBarShiftVelocity;
        private System.Windows.Forms.TrackBar trackBarShiftAcc;
        private System.Windows.Forms.Label labelShiftAmount;
        private System.Windows.Forms.Label labelShiftVel;
        private System.Windows.Forms.Label labelShiftAcc;
        private System.Windows.Forms.Label labelTiltAcc;
        private System.Windows.Forms.Label labelTiltVel;
        private System.Windows.Forms.Label labelTiltAngle;
        private System.Windows.Forms.TrackBar trackBarTiltAcc;
        private System.Windows.Forms.TrackBar trackBarTiltVelocity;
        private System.Windows.Forms.TrackBar trackBarTiltAngle;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxRepetition;
        private System.Windows.Forms.Button btnStart;
    }
}