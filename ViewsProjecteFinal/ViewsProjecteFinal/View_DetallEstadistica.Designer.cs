namespace ViewsProjecteFinal
{
    partial class View_DetallEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_DetallEstadistica));
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMajorValue = new System.Windows.Forms.Label();
            this.lblMinorValue = new System.Windows.Forms.Label();
            this.buttonBack_UC1 = new ViewsProjecteFinal.ButtonBack_UC();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1303, 0);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label1.Location = new System.Drawing.Point(590, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Major Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label2.Location = new System.Drawing.Point(588, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minor Value:";
            // 
            // lblMajorValue
            // 
            this.lblMajorValue.AutoSize = true;
            this.lblMajorValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMajorValue.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.lblMajorValue.Location = new System.Drawing.Point(685, 524);
            this.lblMajorValue.Name = "lblMajorValue";
            this.lblMajorValue.Size = new System.Drawing.Size(14, 19);
            this.lblMajorValue.TabIndex = 4;
            this.lblMajorValue.Text = "-";
            // 
            // lblMinorValue
            // 
            this.lblMinorValue.AutoSize = true;
            this.lblMinorValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMinorValue.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.lblMinorValue.Location = new System.Drawing.Point(685, 549);
            this.lblMinorValue.Name = "lblMinorValue";
            this.lblMinorValue.Size = new System.Drawing.Size(14, 19);
            this.lblMinorValue.TabIndex = 5;
            this.lblMinorValue.Text = "-";
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(618, 588);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(70, 21);
            this.buttonBack_UC1.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(252, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(851, 367);
            this.reportViewer1.TabIndex = 7;
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(500, 30);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(355, 73);
            this.lblTitolView.TabIndex = 65;
            this.lblTitolView.Text = "Detail Orders";
            // 
            // View_DetallEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonBack_UC1);
            this.Controls.Add(this.lblMinorValue);
            this.Controls.Add(this.lblMajorValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Name = "View_DetallEstadistica";
            this.Text = "View_DetallEstadistica";
            this.Load += new System.EventHandler(this.View_DetallEstadistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMajorValue;
        private System.Windows.Forms.Label lblMinorValue;
        private ButtonBack_UC buttonBack_UC1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblTitolView;
    }
}