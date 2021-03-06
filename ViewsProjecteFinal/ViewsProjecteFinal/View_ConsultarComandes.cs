﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.ServiceReference;
using ViewsProjecteFinal.CustomClasses;

namespace ViewsProjecteFinal
{
    public partial class View_ConsultarComandes : Form
    {
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        PersistanceManager pm = new PersistanceManager();
        List<Object> comandes = new List<Object>();
        public View_ConsultarComandes()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnShowDetail.BackColor = Color.FromArgb(26, 183, 234);
            this.btnShowDetail.ForeColor = Color.FromArgb(7, 59, 90);
            this.label1.ForeColor = Color.FromArgb(7, 59, 90);
            this.label2.ForeColor = Color.FromArgb(7, 59, 90);

            m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));
            comandes = pm.gridComandes();
            this.gridView.DataSource = comandes.ToList();
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                int idCom;
                id = int.Parse(this.txtSelect.Text);
                idCom = int.Parse(this.txtSelectCom.Text);

                Form showDetail = new View_DetallComanda(id, idCom);
                Methods.back(this, showDetail);
            }
            catch
            {
                if (txtSelect.Text.Equals(""))
                {
                    MessageBox.Show("Introdueix una id al camp de text!");
                }
                else
                {
                    MessageBox.Show("Valor incorrecte!");
                }
            }
        }

        private void View_ConsultarComandes_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
