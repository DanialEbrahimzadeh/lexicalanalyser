namespace Design_Compiler__First_Stage_
{
    partial class SplashScreenForm
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
            this.LoadingPictureBox = new System.Windows.Forms.PictureBox();
            this.PleaseWaitLabel = new System.Windows.Forms.Label();
            this.FirstLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingPictureBox
            // 
            this.LoadingPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LoadingPictureBox.Location = new System.Drawing.Point(303, 429);
            this.LoadingPictureBox.Name = "LoadingPictureBox";
            this.LoadingPictureBox.Size = new System.Drawing.Size(48, 48);
            this.LoadingPictureBox.TabIndex = 5;
            this.LoadingPictureBox.TabStop = false;
            // 
            // PleaseWaitLabel
            // 
            this.PleaseWaitLabel.AutoSize = true;
            this.PleaseWaitLabel.BackColor = System.Drawing.Color.Transparent;
            this.PleaseWaitLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PleaseWaitLabel.ForeColor = System.Drawing.Color.White;
            this.PleaseWaitLabel.Location = new System.Drawing.Point(354, 435);
            this.PleaseWaitLabel.Name = "PleaseWaitLabel";
            this.PleaseWaitLabel.Size = new System.Drawing.Size(145, 37);
            this.PleaseWaitLabel.TabIndex = 4;
            this.PleaseWaitLabel.Text = "Please Wait";
            // 
            // FirstLogoPictureBox
            // 
            this.FirstLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.FirstLogoPictureBox.Location = new System.Drawing.Point(100, 23);
            this.FirstLogoPictureBox.Name = "FirstLogoPictureBox";
            this.FirstLogoPictureBox.Size = new System.Drawing.Size(600, 400);
            this.FirstLogoPictureBox.TabIndex = 3;
            this.FirstLogoPictureBox.TabStop = false;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.LoadingPictureBox);
            this.Controls.Add(this.PleaseWaitLabel);
            this.Controls.Add(this.FirstLogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenForm";
            this.Shown += new System.EventHandler(this.SplashScreenForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoadingPictureBox;
        private System.Windows.Forms.Label PleaseWaitLabel;
        private System.Windows.Forms.PictureBox FirstLogoPictureBox;
    }
}