namespace ViewsProjecteFinal
{
    partial class View_ModificarCategoria
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
            this.buttonBack_UC1 = new ViewsProjecteFinal.ButtonBack_UC();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1302, 1);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 53;
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(628, 342);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(70, 21);
            this.buttonBack_UC1.TabIndex = 52;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(612, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 31);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.LightCyan;
            this.txtDiscount.Location = new System.Drawing.Point(663, 213);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(29, 20);
            this.txtDiscount.TabIndex = 50;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightCyan;
            this.txtName.Location = new System.Drawing.Point(663, 172);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(92, 20);
            this.txtName.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label3.Location = new System.Drawing.Point(575, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label2.Location = new System.Drawing.Point(575, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name:";
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(456, 39);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(443, 73);
            this.lblTitolView.TabIndex = 68;
            this.lblTitolView.Text = "Modify Category";
            // 
            // View_ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Controls.Add(this.buttonBack_UC1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "View_ModificarCategoria";
            this.Text = "View_ModificarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private ButtonBack_UC buttonBack_UC1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitolView;
    }
}