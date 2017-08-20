namespace ViewsProjecteFinal
{
    partial class View_ConsultarComandes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnShowDetail = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectCom = new System.Windows.Forms.TextBox();
            this.buttonBack_UC1 = new ViewsProjecteFinal.ButtonBack_UC();
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label1.Location = new System.Drawing.Point(559, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Order:";
            // 
            // txtSelect
            // 
            this.txtSelect.BackColor = System.Drawing.Color.LightCyan;
            this.txtSelect.Location = new System.Drawing.Point(655, 534);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(72, 20);
            this.txtSelect.TabIndex = 10;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.btnShowDetail.Location = new System.Drawing.Point(747, 546);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(97, 37);
            this.btnShowDetail.TabIndex = 12;
            this.btnShowDetail.Text = "Show Detail";
            this.btnShowDetail.UseVisualStyleBackColor = true;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(256, 147);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(851, 367);
            this.gridView.TabIndex = 22;
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(499, 39);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(400, 73);
            this.lblTitolView.TabIndex = 53;
            this.lblTitolView.Text = "Consult Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.label2.Location = new System.Drawing.Point(559, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Select Agent:";
            // 
            // txtSelectCom
            // 
            this.txtSelectCom.BackColor = System.Drawing.Color.LightCyan;
            this.txtSelectCom.Location = new System.Drawing.Point(655, 569);
            this.txtSelectCom.Name = "txtSelectCom";
            this.txtSelectCom.Size = new System.Drawing.Size(72, 20);
            this.txtSelectCom.TabIndex = 11;
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(657, 616);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(70, 21);
            this.buttonBack_UC1.TabIndex = 13;
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1311, 2);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 7;
            // 
            // View_ConsultarComandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.txtSelectCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack_UC1);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Name = "View_ConsultarComandes";
            this.Text = "View_ConsultarComandes";
            this.Load += new System.EventHandler(this.View_ConsultarComandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonBack_UC buttonBack_UC1;
        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnShowDetail;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label lblTitolView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectCom;
    }
}