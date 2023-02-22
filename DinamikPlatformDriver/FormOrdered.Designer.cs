namespace DinamikPlatformDriver
{
    partial class FormOrdered
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
            this.radioBtnCounterclocwise = new System.Windows.Forms.RadioButton();
            this.radioBtnRandom = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRepetition = new System.Windows.Forms.Label();
            this.trackBarNumberofTilt = new System.Windows.Forms.TrackBar();
            this.trackBarTiltAngle = new System.Windows.Forms.TrackBar();
            this.trackBarVelocity = new System.Windows.Forms.TrackBar();
            this.trackBarAcc = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRepetition = new System.Windows.Forms.TextBox();
            this.labelNumberofTilt = new System.Windows.Forms.Label();
            this.labelTiltAngle = new System.Windows.Forms.Label();
            this.labelVelocity = new System.Windows.Forms.Label();
            this.labelAcc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumberofTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Direction:";
            // 
            // radioBtnClockwise
            // 
            this.radioBtnClockwise.AutoSize = true;
            this.radioBtnClockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnClockwise.Location = new System.Drawing.Point(285, 59);
            this.radioBtnClockwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnClockwise.Name = "radioBtnClockwise";
            this.radioBtnClockwise.Size = new System.Drawing.Size(126, 29);
            this.radioBtnClockwise.TabIndex = 1;
            this.radioBtnClockwise.TabStop = true;
            this.radioBtnClockwise.Text = "Clockwise";
            this.radioBtnClockwise.UseVisualStyleBackColor = true;
            // 
            // radioBtnCounterclocwise
            // 
            this.radioBtnCounterclocwise.AutoSize = true;
            this.radioBtnCounterclocwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnCounterclocwise.Location = new System.Drawing.Point(489, 59);
            this.radioBtnCounterclocwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnCounterclocwise.Name = "radioBtnCounterclocwise";
            this.radioBtnCounterclocwise.Size = new System.Drawing.Size(191, 29);
            this.radioBtnCounterclocwise.TabIndex = 2;
            this.radioBtnCounterclocwise.TabStop = true;
            this.radioBtnCounterclocwise.Text = "Counterclockwise";
            this.radioBtnCounterclocwise.UseVisualStyleBackColor = true;
            // 
            // radioBtnRandom
            // 
            this.radioBtnRandom.AutoSize = true;
            this.radioBtnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnRandom.Location = new System.Drawing.Point(766, 62);
            this.radioBtnRandom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnRandom.Name = "radioBtnRandom";
            this.radioBtnRandom.Size = new System.Drawing.Size(110, 29);
            this.radioBtnRandom.TabIndex = 3;
            this.radioBtnRandom.TabStop = true;
            this.radioBtnRandom.Text = "Random";
            this.radioBtnRandom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Tilt :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tilt Angle (deg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tilt Velocity (deg/s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Acceleration (deg/s ²):";
            // 
            // labelRepetition
            // 
            this.labelRepetition.AutoSize = true;
            this.labelRepetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRepetition.Location = new System.Drawing.Point(39, 621);
            this.labelRepetition.Name = "labelRepetition";
            this.labelRepetition.Size = new System.Drawing.Size(104, 25);
            this.labelRepetition.TabIndex = 8;
            this.labelRepetition.Text = "Repetition:";
            // 
            // trackBarNumberofTilt
            // 
            this.trackBarNumberofTilt.Location = new System.Drawing.Point(268, 161);
            this.trackBarNumberofTilt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarNumberofTilt.Maximum = 36;
            this.trackBarNumberofTilt.Minimum = 4;
            this.trackBarNumberofTilt.Name = "trackBarNumberofTilt";
            this.trackBarNumberofTilt.Size = new System.Drawing.Size(196, 69);
            this.trackBarNumberofTilt.TabIndex = 9;
            this.trackBarNumberofTilt.Value = 4;
            this.trackBarNumberofTilt.Scroll += new System.EventHandler(this.trackBarNumberofTilt_Scroll);
            // 
            // trackBarTiltAngle
            // 
            this.trackBarTiltAngle.Location = new System.Drawing.Point(268, 261);
            this.trackBarTiltAngle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltAngle.Maximum = 25;
            this.trackBarTiltAngle.Minimum = 5;
            this.trackBarTiltAngle.Name = "trackBarTiltAngle";
            this.trackBarTiltAngle.Size = new System.Drawing.Size(196, 69);
            this.trackBarTiltAngle.TabIndex = 10;
            this.trackBarTiltAngle.Value = 5;
            this.trackBarTiltAngle.Scroll += new System.EventHandler(this.trackBarTiltAngle_Scroll);
            // 
            // trackBarVelocity
            // 
            this.trackBarVelocity.Location = new System.Drawing.Point(268, 355);
            this.trackBarVelocity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarVelocity.Maximum = 80;
            this.trackBarVelocity.Name = "trackBarVelocity";
            this.trackBarVelocity.Size = new System.Drawing.Size(196, 69);
            this.trackBarVelocity.TabIndex = 11;
            this.trackBarVelocity.Scroll += new System.EventHandler(this.trackBarVelocity_Scroll);
            // 
            // trackBarAcc
            // 
            this.trackBarAcc.Location = new System.Drawing.Point(268, 460);
            this.trackBarAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarAcc.Maximum = 400;
            this.trackBarAcc.Name = "trackBarAcc";
            this.trackBarAcc.Size = new System.Drawing.Size(196, 69);
            this.trackBarAcc.TabIndex = 12;
            this.trackBarAcc.Scroll += new System.EventHandler(this.trackBarAcc_Scroll);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRepetition
            // 
            this.textBoxRepetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepetition.Location = new System.Drawing.Point(164, 618);
            this.textBoxRepetition.Name = "textBoxRepetition";
            this.textBoxRepetition.Size = new System.Drawing.Size(100, 30);
            this.textBoxRepetition.TabIndex = 14;
            this.textBoxRepetition.Text = "1";
            // 
            // labelNumberofTilt
            // 
            this.labelNumberofTilt.AutoSize = true;
            this.labelNumberofTilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberofTilt.Location = new System.Drawing.Point(499, 161);
            this.labelNumberofTilt.Name = "labelNumberofTilt";
            this.labelNumberofTilt.Size = new System.Drawing.Size(23, 25);
            this.labelNumberofTilt.TabIndex = 15;
            this.labelNumberofTilt.Text = "4";
            // 
            // labelTiltAngle
            // 
            this.labelTiltAngle.AutoSize = true;
            this.labelTiltAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiltAngle.Location = new System.Drawing.Point(499, 261);
            this.labelTiltAngle.Name = "labelTiltAngle";
            this.labelTiltAngle.Size = new System.Drawing.Size(23, 25);
            this.labelTiltAngle.TabIndex = 16;
            this.labelTiltAngle.Text = "5";
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocity.Location = new System.Drawing.Point(499, 355);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(23, 25);
            this.labelVelocity.TabIndex = 17;
            this.labelVelocity.Text = "5";
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcc.Location = new System.Drawing.Point(499, 460);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(23, 25);
            this.labelAcc.TabIndex = 18;
            this.labelAcc.Text = "0";
            // 
            // FormOrdered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 762);
            this.Controls.Add(this.labelAcc);
            this.Controls.Add(this.labelVelocity);
            this.Controls.Add(this.labelTiltAngle);
            this.Controls.Add(this.labelNumberofTilt);
            this.Controls.Add(this.textBoxRepetition);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBarAcc);
            this.Controls.Add(this.trackBarVelocity);
            this.Controls.Add(this.trackBarTiltAngle);
            this.Controls.Add(this.trackBarNumberofTilt);
            this.Controls.Add(this.labelRepetition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnRandom);
            this.Controls.Add(this.radioBtnCounterclocwise);
            this.Controls.Add(this.radioBtnClockwise);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOrdered";
            this.Text = "FormOrdered";
            this.Load += new System.EventHandler(this.FormOrdered_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumberofTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnClockwise;
        private System.Windows.Forms.RadioButton radioBtnCounterclocwise;
        private System.Windows.Forms.RadioButton radioBtnRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRepetition;
        private System.Windows.Forms.TrackBar trackBarNumberofTilt;
        private System.Windows.Forms.TrackBar trackBarTiltAngle;
        private System.Windows.Forms.TrackBar trackBarVelocity;
        private System.Windows.Forms.TrackBar trackBarAcc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRepetition;
        private System.Windows.Forms.Label labelNumberofTilt;
        private System.Windows.Forms.Label labelTiltAngle;
        private System.Windows.Forms.Label labelVelocity;
        private System.Windows.Forms.Label labelAcc;
    }
}