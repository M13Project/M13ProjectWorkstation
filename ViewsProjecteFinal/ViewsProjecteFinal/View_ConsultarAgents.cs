using System;
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
    public partial class View_ConsultarAgents : Form
    {
        PersistanceManager pm = new PersistanceManager();
        Comercial comercial = new Comercial();
        Usuari usuari = new Usuari();
        List<Object> comercials = new List<Object>();
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

            m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));
            comercials = pm.gridUsuaris();
            this.gridView.DataSource = comercials.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form afegirAgent = new View_AfegirAgent();
            Methods.back(this, afegirAgent);

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;

                id = int.Parse(this.txtSelect.Text);
                //usuari = pm.getUsuari(id);
                comercial = pm.getComercial(id);
                DialogResult result;
                result = Methods.PerformCalculations();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    pm.DeleteComercial(comercial);
                    comercials = pm.gridUsuaris();
                    this.gridView.DataSource = comercials.ToList();
                }
                else { }
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                id = int.Parse(this.txtSelect.Text);

                Form modificarAgent = new View_ModificarAgent(id);
                Methods.back(this, modificarAgent);
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

        private void View_ConsultarAgents_VisibleChanged(object sender, EventArgs e)
        {
            this.Update();
            this.Refresh();
            this.gridView.DataSource = comercials.ToList();
        }

        private void View_ConsultarAgents_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
