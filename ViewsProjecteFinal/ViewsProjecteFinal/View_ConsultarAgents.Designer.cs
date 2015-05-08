namespace ViewsProjecteFinal
{
    partial class View_ConsultarAgents
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.pictureBoxLogout_UC1 = new ViewsProjecteFinal.PictureBoxLogout_UC();
            this.buttonBack_UC1 = new ViewsProjecteFinal.ButtonBack_UC();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(260, 157);
            this.gridView.Name = "gridView";
            this.gridView.RowTemplate.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(851, 367);
            this.gridView.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.btnAdd.Location = new System.Drawing.Point(452, 545);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.btnModify.Location = new System.Drawing.Point(706, 545);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(102, 31);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblSelect.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.lblSelect.Location = new System.Drawing.Point(448, 596);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(48, 19);
            this.lblSelect.TabIndex = 5;
            this.lblSelect.Text = "Select:";
            // 
            // txtSelect
            // 
            this.txtSelect.BackColor = System.Drawing.Color.LightCyan;
            this.txtSelect.Location = new System.Drawing.Point(497, 596);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(197, 20);
            this.txtSelect.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.btnDelete.Location = new System.Drawing.Point(814, 545);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(501, 39);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(403, 73);
            this.lblTitolView.TabIndex = 49;
            this.lblTitolView.Text = "Consult Agents";
            // 
            // pictureBoxLogout_UC1
            // 
            this.pictureBoxLogout_UC1.Location = new System.Drawing.Point(1311, 1);
            this.pictureBoxLogout_UC1.Name = "pictureBoxLogout_UC1";
            this.pictureBoxLogout_UC1.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogout_UC1.TabIndex = 9;
            // 
            // buttonBack_UC1
            // 
            this.buttonBack_UC1.Location = new System.Drawing.Point(639, 634);
            this.buttonBack_UC1.Name = "buttonBack_UC1";
            this.buttonBack_UC1.Size = new System.Drawing.Size(70, 21);
            this.buttonBack_UC1.TabIndex = 8;
            // 
            // View_ConsultarAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.lblTitolView);
            this.Controls.Add(this.pictureBoxLogout_UC1);
            this.Controls.Add(this.buttonBack_UC1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridView);
            this.Name = "View_ConsultarAgents";
            this.Text = "ConsultarAgentsView";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnDelete;
        private ButtonBack_UC buttonBack_UC1;
        private PictureBoxLogout_UC pictureBoxLogout_UC1;
        private System.Windows.Forms.Label lblTitolView;
    }
}