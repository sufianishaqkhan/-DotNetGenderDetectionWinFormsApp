
namespace GenderDetectionWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFPS = new System.Windows.Forms.Button();
            this.btnFDDNN = new System.Windows.Forms.Button();
            this.btnAgeGender = new System.Windows.Forms.Button();
            this.pictureBoxWebCam = new System.Windows.Forms.PictureBox();
            this.pictureBoxEffect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(37, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(119, 31);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFPS
            // 
            this.btnFPS.Location = new System.Drawing.Point(272, 31);
            this.btnFPS.Name = "btnFPS";
            this.btnFPS.Size = new System.Drawing.Size(75, 23);
            this.btnFPS.TabIndex = 2;
            this.btnFPS.Text = "FPS";
            this.btnFPS.UseVisualStyleBackColor = true;
            this.btnFPS.Click += new System.EventHandler(this.buttonFPS_Click);
            // 
            // btnFDDNN
            // 
            this.btnFDDNN.Location = new System.Drawing.Point(353, 31);
            this.btnFDDNN.Name = "btnFDDNN";
            this.btnFDDNN.Size = new System.Drawing.Size(110, 23);
            this.btnFDDNN.TabIndex = 3;
            this.btnFDDNN.Text = "Face Detection";
            this.btnFDDNN.UseVisualStyleBackColor = true;
            this.btnFDDNN.Click += new System.EventHandler(this.btnFDDNN_Click);
            // 
            // btnAgeGender
            // 
            this.btnAgeGender.Location = new System.Drawing.Point(469, 31);
            this.btnAgeGender.Name = "btnAgeGender";
            this.btnAgeGender.Size = new System.Drawing.Size(193, 23);
            this.btnAgeGender.TabIndex = 4;
            this.btnAgeGender.Text = "Age and Gender Estimation";
            this.btnAgeGender.UseVisualStyleBackColor = true;
            this.btnAgeGender.Click += new System.EventHandler(this.btnAgeGender_Click);
            // 
            // pictureBoxWebCam
            // 
            this.pictureBoxWebCam.Location = new System.Drawing.Point(37, 61);
            this.pictureBoxWebCam.Name = "pictureBoxWebCam";
            this.pictureBoxWebCam.Size = new System.Drawing.Size(310, 250);
            this.pictureBoxWebCam.TabIndex = 5;
            this.pictureBoxWebCam.TabStop = false;
            // 
            // pictureBoxEffect
            // 
            this.pictureBoxEffect.Location = new System.Drawing.Point(353, 60);
            this.pictureBoxEffect.Name = "pictureBoxEffect";
            this.pictureBoxEffect.Size = new System.Drawing.Size(309, 251);
            this.pictureBoxEffect.TabIndex = 6;
            this.pictureBoxEffect.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 333);
            this.Controls.Add(this.pictureBoxEffect);
            this.Controls.Add(this.pictureBoxWebCam);
            this.Controls.Add(this.btnAgeGender);
            this.Controls.Add(this.btnFDDNN);
            this.Controls.Add(this.btnFPS);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEffect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFPS;
        private System.Windows.Forms.Button btnFDDNN;
        private System.Windows.Forms.Button btnAgeGender;
        private System.Windows.Forms.PictureBox pictureBoxWebCam;
        private System.Windows.Forms.PictureBox pictureBoxEffect;
    }
}

