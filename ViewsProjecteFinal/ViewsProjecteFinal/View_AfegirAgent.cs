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

namespace ViewsProjecteFinal
{
    public partial class View_AfegirAgent : Form
    {

        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";        

        public View_AfegirAgent()
        {
            InitializeComponent();
            this.btnAdd.BackColor = Color.FromArgb(26, 183, 234);
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.label1.ForeColor = Color.FromArgb(7, 59, 90);
            this.label2.ForeColor = Color.FromArgb(7, 59, 90);
            this.label3.ForeColor = Color.FromArgb(7, 59, 90);
            this.label4.ForeColor = Color.FromArgb(7, 59, 90);
            this.label5.ForeColor = Color.FromArgb(7, 59, 90);
            this.label6.ForeColor = Color.FromArgb(7, 59, 90);
            this.label7.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnAdd.ForeColor = Color.FromArgb(7, 59, 90);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Comercial com = new Comercial();
            //com.AnyInici = txtStartYear;
            com.ZonaTreball = txtWorkZone.ToString();
            Usuari us = new Usuari();
            us.Nom = txtName.ToString();
            us.Cognom = txtSurname.ToString();
            us.Dni = txtDNI.ToString();
            us.Usuari1 = txtUsername.ToString();
            us.Contrasenya = txtPassword.ToString();
            us.Comercial = com;

        }
    }
}
