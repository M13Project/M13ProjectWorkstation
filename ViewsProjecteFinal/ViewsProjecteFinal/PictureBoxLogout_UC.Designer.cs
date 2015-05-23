namespace ViewsProjecteFinal
{
    partial class PictureBoxLogout_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pboxLogout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxLogout
            // 
            this.pboxLogout.BackColor = System.Drawing.Color.Transparent;
            this.pboxLogout.Image = global::ViewsProjecteFinal.Properties.Resources.logout;
            this.pboxLogout.InitialImage = null;
            this.pboxLogout.Location = new System.Drawing.Point(0, 0);
            this.pboxLogout.Name = "pboxLogout";
            this.pboxLogout.Size = new System.Drawing.Size(50, 50);
            this.pboxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogout.TabIndex = 0;
            this.pboxLogout.TabStop = false;
            this.pboxLogout.Click += new System.EventHandler(this.onClickLogout);
            this.pboxLogout.MouseEnter += new System.EventHandler(this.pboxLogout_MouseEnter);
            this.pboxLogout.MouseLeave += new System.EventHandler(this.pboxLogout_MouseLeave);
            // 
            // PictureBoxLogout_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pboxLogout);
            this.Name = "PictureBoxLogout_UC";
            this.Size = new System.Drawing.Size(50, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxLogout;
    }
}
