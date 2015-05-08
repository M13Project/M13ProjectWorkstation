namespace ViewsProjecteFinal
{
    partial class View_ConsultarClients
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
            this.buttonBack_UC1 = new ViewsProjecteFinal.ButtonBack_UC();
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.lblTitolView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(641, 551);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(70, 21);
            this.buttonBack_UC1.TabIndex = 2;
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1310, 1);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 3;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(256, 151);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(851, 367);
            this.gridView.TabIndex = 19;
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(488, 39);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(401, 73);
            this.lblTitolView.TabIndex = 51;
            this.lblTitolView.Text = "Consult Clients";
            // 
            // View_ConsultarClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Controls.Add(this.buttonBack_UC1);
            this.Name = "View_ConsultarClients";
            this.Text = "View_ConsultarClients";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonBack_UC buttonBack_UC1;
        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label lblTitolView;
    }
}