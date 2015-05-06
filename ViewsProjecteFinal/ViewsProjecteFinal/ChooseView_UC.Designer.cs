namespace ViewsProjecteFinal
{
    partial class ChooseView_UC
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
            this.pboxOption = new System.Windows.Forms.PictureBox();
            this.lblOption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOption)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxOption
            // 
            this.pboxOption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pboxOption.Location = new System.Drawing.Point(3, 3);
            this.pboxOption.Name = "pboxOption";
            this.pboxOption.Size = new System.Drawing.Size(150, 109);
            this.pboxOption.TabIndex = 0;
            this.pboxOption.TabStop = false;
            // 
            // lblOption
            // 
            this.lblOption.BackColor = System.Drawing.Color.LightCyan;
            this.lblOption.Location = new System.Drawing.Point(3, 115);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(150, 38);
            this.lblOption.TabIndex = 1;
            this.lblOption.Text = "option";
            this.lblOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseView_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.pboxOption);
            this.Name = "ChooseView_UC";
            this.Size = new System.Drawing.Size(156, 157);
            ((System.ComponentModel.ISupportInitialize)(this.pboxOption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxOption;
        private System.Windows.Forms.Label lblOption;
    }
}
