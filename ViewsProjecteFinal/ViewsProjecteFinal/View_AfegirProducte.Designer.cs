namespace ViewsProjecteFinal
{
    partial class View_AfegirProducte
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
            this.txtDescompte = new System.Windows.Forms.TextBox();
            this.txtPreu = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.cmbboxCategoria = new System.Windows.Forms.ComboBox();
            this.cboxHabilitat = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            this.buttonBack_UC1 = new ViewsProjecteFinal.ButtonBack_UC();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.btnAdd.Location = new System.Drawing.Point(616, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 31);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddProducte_Click);
            // 
            // txtDescompte
            // 
            this.txtDescompte.BackColor = System.Drawing.Color.LightCyan;
            this.txtDescompte.Location = new System.Drawing.Point(597, 255);
            this.txtDescompte.Name = "txtDescompte";
            this.txtDescompte.Size = new System.Drawing.Size(30, 20);
            this.txtDescompte.TabIndex = 30;
            // 
            // txtPreu
            // 
            this.txtPreu.BackColor = System.Drawing.Color.LightCyan;
            this.txtPreu.Location = new System.Drawing.Point(597, 214);
            this.txtPreu.Name = "txtPreu";
            this.txtPreu.Size = new System.Drawing.Size(50, 20);
            this.txtPreu.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightCyan;
            this.txtName.Location = new System.Drawing.Point(597, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(92, 20);
            this.txtName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label4.Location = new System.Drawing.Point(508, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Habilitat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label3.Location = new System.Drawing.Point(508, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Preu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label2.Location = new System.Drawing.Point(508, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label1.Location = new System.Drawing.Point(508, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Descompte:";
            // 
            // pboxProfilePicture
            // 
            this.pboxProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.pboxProfilePicture.Location = new System.Drawing.Point(746, 173);
            this.pboxProfilePicture.Name = "pboxProfilePicture";
            this.pboxProfilePicture.Size = new System.Drawing.Size(147, 175);
            this.pboxProfilePicture.TabIndex = 35;
            this.pboxProfilePicture.TabStop = false;
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(514, 42);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(353, 73);
            this.lblTitolView.TabIndex = 48;
            this.lblTitolView.Text = "New Product";
            // 
            // cmbboxCategoria
            // 
            this.cmbboxCategoria.BackColor = System.Drawing.Color.LightCyan;
            this.cmbboxCategoria.DropDownHeight = 80;
            this.cmbboxCategoria.FormattingEnabled = true;
            this.cmbboxCategoria.IntegralHeight = false;
            this.cmbboxCategoria.Location = new System.Drawing.Point(597, 329);
            this.cmbboxCategoria.Name = "cmbboxCategoria";
            this.cmbboxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbboxCategoria.TabIndex = 79;
            // 
            // cboxHabilitat
            // 
            this.cboxHabilitat.AutoSize = true;
            this.cboxHabilitat.BackColor = System.Drawing.Color.Transparent;
            this.cboxHabilitat.Location = new System.Drawing.Point(597, 297);
            this.cboxHabilitat.Name = "cboxHabilitat";
            this.cboxHabilitat.Size = new System.Drawing.Size(15, 14);
            this.cboxHabilitat.TabIndex = 78;
            this.cboxHabilitat.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label5.Location = new System.Drawing.Point(509, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "Categoria:";
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1310, 2);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 34;
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(631, 443);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(70, 21);
            this.buttonBack_UC1.TabIndex = 33;
            // 
            // View_AfegirProducte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.cmbboxCategoria);
            this.Controls.Add(this.cboxHabilitat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.pboxProfilePicture);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Controls.Add(this.buttonBack_UC1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescompte);
            this.Controls.Add(this.txtPreu);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "View_AfegirProducte";
            this.Text = "View_AfegirProducte";
            this.Load += new System.EventHandler(this.View_AfegirProducte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private ButtonBack_UC buttonBack_UC1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescompte;
        private System.Windows.Forms.TextBox txtPreu;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxProfilePicture;
        private System.Windows.Forms.Label lblTitolView;
        private System.Windows.Forms.ComboBox cmbboxCategoria;
        private System.Windows.Forms.CheckBox cboxHabilitat;
        private System.Windows.Forms.Label label5;
    }
}