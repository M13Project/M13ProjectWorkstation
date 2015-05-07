﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.WebServiceReference;

namespace ViewsProjecteFinal
{
    public partial class View_ConsultarAgents : Form
    {
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        public View_ConsultarAgents()
        {
           
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnAdd.BackColor = Color.FromArgb(26, 183, 234);
            this.btnDelete.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnDelete.ForeColor = Color.FromArgb(7, 59, 90);
            this.lblSelect.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnAdd.ForeColor = Color.FromArgb(7, 59, 90);

            m13_projectEntities entities = new m13_projectEntities(new Uri(webServiceDomain)); 
            this.gridView.DataSource = entities.Comercial.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form afegirAgent = new View_AfegirAgent();
            afegirAgent.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            String id;
            id = this.txtSelect.Text;
            
            this.Hide();
            Form modificarAgent = new View_ModificarAgent(id);
            modificarAgent.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
