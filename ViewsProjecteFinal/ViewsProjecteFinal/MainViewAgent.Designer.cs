namespace ViewsProjecteFinal
{
    partial class MainViewAgent
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
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            this.chooseView_UC1 = new ViewsProjecteFinal.ChooseView_UC();
            this.chooseView_UC2 = new ViewsProjecteFinal.ChooseView_UC();
            this.chooseView_UC3 = new ViewsProjecteFinal.ChooseView_UC();
            this.chooseView_UC4 = new ViewsProjecteFinal.ChooseView_UC();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1310, 2);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 5;
            // 
            // chooseView_UC1
            // 
            this.chooseView_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC1.Location = new System.Drawing.Point(481, 190);
            this.chooseView_UC1.Name = "chooseView_UC1";
            this.chooseView_UC1.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC1.TabIndex = 6;
            // 
            // chooseView_UC2
            // 
            this.chooseView_UC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC2.Location = new System.Drawing.Point(748, 190);
            this.chooseView_UC2.Name = "chooseView_UC2";
            this.chooseView_UC2.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC2.TabIndex = 7;
            // 
            // chooseView_UC3
            // 
            this.chooseView_UC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC3.Location = new System.Drawing.Point(481, 394);
            this.chooseView_UC3.Name = "chooseView_UC3";
            this.chooseView_UC3.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC3.TabIndex = 8;
            // 
            // chooseView_UC4
            // 
            this.chooseView_UC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC4.Location = new System.Drawing.Point(748, 394);
            this.chooseView_UC4.Name = "chooseView_UC4";
            this.chooseView_UC4.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC4.TabIndex = 9;
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(616, 77);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(157, 73);
            this.lblTitolView.TabIndex = 16;
            this.lblTitolView.Text = "Main";
            // 
            // MainViewAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.chooseView_UC4);
            this.Controls.Add(this.chooseView_UC3);
            this.Controls.Add(this.chooseView_UC2);
            this.Controls.Add(this.chooseView_UC1);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Name = "MainViewAgent";
            this.Text = "MainViewAgent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private ChooseView_UC chooseView_UC1;
        private ChooseView_UC chooseView_UC2;
        private ChooseView_UC chooseView_UC3;
        private ChooseView_UC chooseView_UC4;
        private System.Windows.Forms.Label lblTitolView;
    }
}