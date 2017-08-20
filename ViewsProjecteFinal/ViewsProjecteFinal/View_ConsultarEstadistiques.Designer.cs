namespace ViewsProjecteFinal
{
    partial class View_ConsultarEstadistiques
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
            this.btnMostClients = new System.Windows.Forms.Button();
            this.btnMostOrders = new System.Windows.Forms.Button();
            this.btnMostSold = new System.Windows.Forms.Button();
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            this.buttonBack_UC1 = new ViewsProjecteFinal.ButtonBack_UC();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostClients
            // 
            this.btnMostClients.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnMostClients.Location = new System.Drawing.Point(397, 168);
            this.btnMostClients.Name = "btnMostClients";
            this.btnMostClients.Size = new System.Drawing.Size(565, 36);
            this.btnMostClients.TabIndex = 1;
            this.btnMostClients.Text = "Agent with most clients";
            this.btnMostClients.UseVisualStyleBackColor = true;
            this.btnMostClients.Click += new System.EventHandler(this.btnMostClients_Click);
            // 
            // btnMostOrders
            // 
            this.btnMostOrders.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnMostOrders.Location = new System.Drawing.Point(397, 265);
            this.btnMostOrders.Name = "btnMostOrders";
            this.btnMostOrders.Size = new System.Drawing.Size(565, 36);
            this.btnMostOrders.TabIndex = 2;
            this.btnMostOrders.Text = "Agent with most orders";
            this.btnMostOrders.UseVisualStyleBackColor = true;
            this.btnMostOrders.Click += new System.EventHandler(this.btnMostOrders_Click);
            // 
            // btnMostSold
            // 
            this.btnMostSold.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnMostSold.Location = new System.Drawing.Point(397, 359);
            this.btnMostSold.Name = "btnMostSold";
            this.btnMostSold.Size = new System.Drawing.Size(565, 36);
            this.btnMostSold.TabIndex = 3;
            this.btnMostSold.Text = "Most sold products";
            this.btnMostSold.UseVisualStyleBackColor = true;
            this.btnMostSold.Click += new System.EventHandler(this.btnMostSold_Click);
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1345, -2);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxLogout_UC1.TabIndex = 4;
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(650, 450);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(70, 21);
            this.buttonBack_UC1.TabIndex = 5;
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(560, 39);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(242, 73);
            this.lblTitolView.TabIndex = 54;
            this.lblTitolView.Text = "Statistics";
            // 
            // View_ConsultarEstadistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.buttonBack_UC1);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Controls.Add(this.btnMostSold);
            this.Controls.Add(this.btnMostOrders);
            this.Controls.Add(this.btnMostClients);
            this.Name = "View_ConsultarEstadistiques";
            this.Text = "View_ConsultarEstadistiques";
            this.Load += new System.EventHandler(this.View_ConsultarEstadistiques_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostClients;
        private System.Windows.Forms.Button btnMostOrders;
        private System.Windows.Forms.Button btnMostSold;
        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private ButtonBack_UC buttonBack_UC1;
        private System.Windows.Forms.Label lblTitolView;
    }
}