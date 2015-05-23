namespace ViewsProjecteFinal
{
    partial class E_AgentMesClients_View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitolView = new System.Windows.Forms.Label();
            this.chartAgentsMesClients = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgentsMesClients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolView
            // 
            this.lblTitolView.AutoSize = true;
            this.lblTitolView.BackColor = System.Drawing.Color.Transparent;
            this.lblTitolView.Font = new System.Drawing.Font("Palatino Linotype", 40F);
            this.lblTitolView.Location = new System.Drawing.Point(379, 29);
            this.lblTitolView.Name = "lblTitolView";
            this.lblTitolView.Size = new System.Drawing.Size(604, 73);
            this.lblTitolView.TabIndex = 17;
            this.lblTitolView.Text = "Agent with most clients";
            // 
            // chartAgentsMesClients
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAgentsMesClients.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAgentsMesClients.Legends.Add(legend1);
            this.chartAgentsMesClients.Location = new System.Drawing.Point(277, 118);
            this.chartAgentsMesClients.Name = "chartAgentsMesClients";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAgentsMesClients.Series.Add(series1);
            this.chartAgentsMesClients.Size = new System.Drawing.Size(776, 416);
            this.chartAgentsMesClients.TabIndex = 18;
            this.chartAgentsMesClients.Text = "chartAgentsMesClients";
            // 
            // E_AgentMesClients_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViewsProjecteFinal.Properties.Resources.fonsViews;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.chartAgentsMesClients);
            this.Controls.Add(this.lblTitolView);
            this.Name = "E_AgentMesClients_View";
            this.Text = "E_AgentMesClients_View";
            this.Load += new System.EventHandler(this.E_AgentMesClients_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAgentsMesClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAgentsMesClients;

    }
}