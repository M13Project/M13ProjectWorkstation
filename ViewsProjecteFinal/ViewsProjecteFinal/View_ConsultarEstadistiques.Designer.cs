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
            this.SuspendLayout();
            // 
            // btnMostClients
            // 
            this.btnMostClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostClients.Location = new System.Drawing.Point(397, 219);
            this.btnMostClients.Name = "btnMostClients";
            this.btnMostClients.Size = new System.Drawing.Size(565, 36);
            this.btnMostClients.TabIndex = 1;
            this.btnMostClients.Text = "Agent with most clients";
            this.btnMostClients.UseVisualStyleBackColor = true;
            // 
            // btnMostOrders
            // 
            this.btnMostOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostOrders.Location = new System.Drawing.Point(397, 303);
            this.btnMostOrders.Name = "btnMostOrders";
            this.btnMostOrders.Size = new System.Drawing.Size(565, 36);
            this.btnMostOrders.TabIndex = 2;
            this.btnMostOrders.Text = "Agent with most orders";
            this.btnMostOrders.UseVisualStyleBackColor = true;
            // 
            // btnMostSold
            // 
            this.btnMostSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostSold.Location = new System.Drawing.Point(397, 384);
            this.btnMostSold.Name = "btnMostSold";
            this.btnMostSold.Size = new System.Drawing.Size(565, 36);
            this.btnMostSold.TabIndex = 3;
            this.btnMostSold.Text = "Most sold products";
            this.btnMostSold.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1345, -2);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxLogout_UC1.TabIndex = 4;
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(619, 475);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(124, 37);
            this.buttonBack_UC1.TabIndex = 5;
            // 
            // View_ConsultarEstadistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.buttonBack_UC1);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Controls.Add(this.btnMostSold);
            this.Controls.Add(this.btnMostOrders);
            this.Controls.Add(this.btnMostClients);
            this.Name = "View_ConsultarEstadistiques";
            this.Text = "View_ConsultarEstadistiques";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostClients;
        private System.Windows.Forms.Button btnMostOrders;
        private System.Windows.Forms.Button btnMostSold;
        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private ButtonBack_UC buttonBack_UC1;
    }
}