namespace ViewsProjecteFinal
{
    partial class MainViewAdmin
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
            this.chooseView_UC1 = new ViewsProjecteFinal.ChooseView_UC();
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            this.chooseView_UC2 = new ViewsProjecteFinal.ChooseView_UC();
            this.chooseView_UC3 = new ViewsProjecteFinal.ChooseView_UC();
            this.chooseView_UC4 = new ViewsProjecteFinal.ChooseView_UC();
            this.chooseView_UC5 = new ViewsProjecteFinal.ChooseView_UC();
            this.chooseView_UC6 = new ViewsProjecteFinal.ChooseView_UC();
            this.SuspendLayout();
            // 
            // chooseView_UC1
            // 
            this.chooseView_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC1.Location = new System.Drawing.Point(386, 209);
            this.chooseView_UC1.Name = "chooseView_UC1";
            this.chooseView_UC1.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC1.TabIndex = 9;
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1310, 2);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 8;
            // 
            // chooseView_UC2
            // 
            this.chooseView_UC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC2.Location = new System.Drawing.Point(634, 209);
            this.chooseView_UC2.Name = "chooseView_UC2";
            this.chooseView_UC2.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC2.TabIndex = 10;
            // 
            // chooseView_UC3
            // 
            this.chooseView_UC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC3.Location = new System.Drawing.Point(878, 209);
            this.chooseView_UC3.Name = "chooseView_UC3";
            this.chooseView_UC3.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC3.TabIndex = 11;
            // 
            // chooseView_UC4
            // 
            this.chooseView_UC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC4.Location = new System.Drawing.Point(634, 436);
            this.chooseView_UC4.Name = "chooseView_UC4";
            this.chooseView_UC4.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC4.TabIndex = 12;
            // 
            // chooseView_UC5
            // 
            this.chooseView_UC5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC5.Location = new System.Drawing.Point(878, 436);
            this.chooseView_UC5.Name = "chooseView_UC5";
            this.chooseView_UC5.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC5.TabIndex = 13;
            // 
            // chooseView_UC6
            // 
            this.chooseView_UC6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.chooseView_UC6.Location = new System.Drawing.Point(386, 436);
            this.chooseView_UC6.Name = "chooseView_UC6";
            this.chooseView_UC6.Size = new System.Drawing.Size(156, 157);
            this.chooseView_UC6.TabIndex = 14;
            // 
            // MainViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.chooseView_UC6);
            this.Controls.Add(this.chooseView_UC5);
            this.Controls.Add(this.chooseView_UC4);
            this.Controls.Add(this.chooseView_UC3);
            this.Controls.Add(this.chooseView_UC2);
            this.Controls.Add(this.chooseView_UC1);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Name = "MainViewAdmin";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private ChooseView_UC chooseView_UC1;
        private ChooseView_UC chooseView_UC2;
        private ChooseView_UC chooseView_UC3;
        private ChooseView_UC chooseView_UC4;
        private ChooseView_UC chooseView_UC5;
        private ChooseView_UC chooseView_UC6;
    }
}