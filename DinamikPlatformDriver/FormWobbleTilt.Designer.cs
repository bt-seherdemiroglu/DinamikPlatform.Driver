namespace DinamikPlatformDriver
{
    partial class FormWobbleTilt
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
            this.radioBtnCounterclockwise = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarDirectionalChange = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarTiltAngle = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarVelocity = new System.Windows.Forms.TrackBar();
            this.trackBarAcc = new System.Windows.Forms.TrackBar();
            this.textBoxRepetition = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelDirectionalChange = new System.Windows.Forms.Label();
            this.labelTiltAngle = new System.Windows.Forms.Label();
            this.labelVelocity = new System.Windows.Forms.Label();
            this.labelAcc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDirectionalChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Direction:";
            // 
            // radioBtnClockwise
            // 
            this.radioBtnClockwise.AutoSize = true;
            this.radioBtnClockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnClockwise.Location = new System.Drawing.Point(280, 85);
            this.radioBtnClockwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnClockwise.Name = "radioBtnClockwise";
            this.radioBtnClockwise.Size = new System.Drawing.Size(126, 29);
            this.radioBtnClockwise.TabIndex = 1;
            this.radioBtnClockwise.TabStop = true;
            this.radioBtnClockwise.Text = "Clockwise";
            this.radioBtnClockwise.UseVisualStyleBackColor = true;
            // 
            // radioBtnCounterclockwise
            // 
            this.radioBtnCounterclockwise.AutoSize = true;
            this.radioBtnCounterclockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnCounterclockwise.Location = new System.Drawing.Point(462, 85);
            this.radioBtnCounterclockwise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnCounterclockwise.Name = "radioBtnCounterclockwise";
            this.radioBtnCounterclockwise.Size = new System.Drawing.Size(191, 29);
            this.radioBtnCounterclockwise.TabIndex = 2;
            this.radioBtnCounterclockwise.TabStop = true;
            this.radioBtnCounterclockwise.Text = "Counterclockwise";
            this.radioBtnCounterclockwise.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directional Change:";
            // 
            // trackBarDirectionalChange
            // 
            this.trackBarDirectionalChange.Location = new System.Drawing.Point(280, 179);
            this.trackBarDirectionalChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarDirectionalChange.Maximum = 36;
            this.trackBarDirectionalChange.Minimum = 4;
            this.trackBarDirectionalChange.Name = "trackBarDirectionalChange";
            this.trackBarDirectionalChange.Size = new System.Drawing.Size(300, 69);
            this.trackBarDirectionalChange.TabIndex = 4;
            this.trackBarDirectionalChange.Value = 4;
            this.trackBarDirectionalChange.Scroll += new System.EventHandler(this.trackBarDirectionalChange_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tilt Angle (deg):";
            // 
            // trackBarTiltAngle
            // 
            this.trackBarTiltAngle.Location = new System.Drawing.Point(282, 279);
            this.trackBarTiltAngle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTiltAngle.Maximum = 25;
            this.trackBarTiltAngle.Minimum = 5;
            this.trackBarTiltAngle.Name = "trackBarTiltAngle";
            this.trackBarTiltAngle.Size = new System.Drawing.Size(298, 69);
            this.trackBarTiltAngle.TabIndex = 6;
            this.trackBarTiltAngle.Value = 5;
            this.trackBarTiltAngle.Scroll += new System.EventHandler(this.trackBarTiltAngle_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Velocity (deg/s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Acceleration (deg/s ²):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Repetition:";
            // 
            // trackBarVelocity
            // 
            this.trackBarVelocity.Location = new System.Drawing.Point(282, 380);
            this.trackBarVelocity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarVelocity.Maximum = 80;
            this.trackBarVelocity.Minimum = 5;
            this.trackBarVelocity.Name = "trackBarVelocity";
            this.trackBarVelocity.Size = new System.Drawing.Size(298, 69);
            this.trackBarVelocity.TabIndex = 10;
            this.trackBarVelocity.Value = 5;
            this.trackBarVelocity.Scroll += new System.EventHandler(this.trackBarVelocity_Scroll);
            // 
            // trackBarAcc
            // 
            this.trackBarAcc.Location = new System.Drawing.Point(282, 500);
            this.trackBarAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarAcc.Maximum = 400;
            this.trackBarAcc.Name = "trackBarAcc";
            this.trackBarAcc.Size = new System.Drawing.Size(350, 69);
            this.trackBarAcc.TabIndex = 11;
            this.trackBarAcc.Scroll += new System.EventHandler(this.trackBarAcc_Scroll);
            // 
            // textBoxRepetition
            // 
            this.textBoxRepetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRepetition.Location = new System.Drawing.Point(287, 631);
            this.textBoxRepetition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRepetition.Name = "textBoxRepetition";
            this.textBoxRepetition.Size = new System.Drawing.Size(112, 30);
            this.textBoxRepetition.TabIndex = 12;
            this.textBoxRepetition.Text = "1";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(287, 706);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 56);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDirectionalChange
            // 
            this.labelDirectionalChange.AutoSize = true;
            this.labelDirectionalChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectionalChange.Location = new System.Drawing.Point(580, 179);
            this.labelDirectionalChange.Name = "labelDirectionalChange";
            this.labelDirectionalChange.Size = new System.Drawing.Size(23, 25);
            this.labelDirectionalChange.TabIndex = 14;
            this.labelDirectionalChange.Text = "4";
            // 
            // labelTiltAngle
            // 
            this.labelTiltAngle.AutoSize = true;
            this.labelTiltAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiltAngle.Location = new System.Drawing.Point(580, 279);
            this.labelTiltAngle.Name = "labelTiltAngle";
            this.labelTiltAngle.Size = new System.Drawing.Size(23, 25);
            this.labelTiltAngle.TabIndex = 15;
            this.labelTiltAngle.Text = "5";
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocity.Location = new System.Drawing.Point(580, 380);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(23, 25);
            this.labelVelocity.TabIndex = 16;
            this.labelVelocity.Text = "5";
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcc.Location = new System.Drawing.Point(638, 500);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(23, 25);
            this.labelAcc.TabIndex = 17;
            this.labelAcc.Text = "0";
            // 
            // FormWobbleTilt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 816);
            this.Controls.Add(this.labelAcc);
            this.Controls.Add(this.labelVelocity);
            this.Controls.Add(this.labelTiltAngle);
            this.Controls.Add(this.labelDirectionalChange);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBoxRepetition);
            this.Controls.Add(this.trackBarAcc);
            this.Controls.Add(this.trackBarVelocity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarTiltAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarDirectionalChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnCounterclockwise);
            this.Controls.Add(this.radioBtnClockwise);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWobbleTilt";
            this.Text = "FormWobbleTilt";
            this.Load += new System.EventHandler(this.FormWobbleTilt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDirectionalChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtnClockwise;
        private System.Windows.Forms.RadioButton radioBtnCounterclockwise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarDirectionalChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarTiltAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarVelocity;
        private System.Windows.Forms.TrackBar trackBarAcc;
        private System.Windows.Forms.TextBox textBoxRepetition;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelDirectionalChange;
        private System.Windows.Forms.Label labelTiltAngle;
        private System.Windows.Forms.Label labelVelocity;
        private System.Windows.Forms.Label labelAcc;
    }
}