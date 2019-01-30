namespace Cinema_System
{
    partial class MovieHall
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
            this.labelCenter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCenter
            // 
            this.labelCenter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCenter.Location = new System.Drawing.Point(80, 64);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(880, 525);
            this.labelCenter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(100, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 459);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(401, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 459);
            this.label2.TabIndex = 1;
            // 
            // MovieHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_System.Properties.Resources.blurred;
            this.ClientSize = new System.Drawing.Size(1132, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieHall";
            this.Text = "MovieHall";
            this.Load += new System.EventHandler(this.MovieHall_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}