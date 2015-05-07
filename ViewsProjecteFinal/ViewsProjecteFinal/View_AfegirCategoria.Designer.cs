namespace ViewsProjecteFinal
{
    partial class View_AfegirCategoria
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            this.buttonBack_UC1 = new ViewsProjecteFinal.ButtonBack_UC();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(630, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 31);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.LightCyan;
            this.txtDiscount.Location = new System.Drawing.Point(683, 212);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(29, 20);
            this.txtDiscount.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightCyan;
            this.txtName.Location = new System.Drawing.Point(683, 169);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(92, 20);
            this.txtName.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label3.Location = new System.Drawing.Point(599, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label2.Location = new System.Drawing.Point(599, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name:";
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(501, 39);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(382, 73);
            this.lblTitolView.TabIndex = 47;
            this.lblTitolView.Text = "New Category";
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1311, 1);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 46;
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(648, 317);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(70, 21);
            this.buttonBack_UC1.TabIndex = 45;
            // 
            // View_AfegirCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Controls.Add(this.buttonBack_UC1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "View_AfegirCategoria";
            this.Text = "View_AfegirCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private ButtonBack_UC buttonBack_UC1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitolView;
    }
}