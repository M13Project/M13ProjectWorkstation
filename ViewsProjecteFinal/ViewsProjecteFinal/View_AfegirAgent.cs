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
using System.Security.Cryptography;


namespace ViewsProjecteFinal
{
    public partial class View_AfegirAgent : Form
    {

        PersistanceManager pm = new PersistanceManager();

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
            int id;
            Usuari us = new Usuari();
            us.Nom = txtName.Text;
            us.Cognom = txtSurname.Text;
            us.Dni = txtDNI.Text;
            us.Usuari1 = txtUsername.Text;
            us.Contrasenya = Methods.ComputeHash(txtPassword.Text.ToString() , new SHA256CryptoServiceProvider());

            id = pm.InsertUser(us);
            MessageBox.Show(id.ToString());
            Comercial com = new Comercial();
            string date = txtStartYear.Text.ToString();
            DateTime dt = Convert.ToDateTime(date);
            com.AnyInici = dt;
            com.Habilitat = true;
            com.ZonaTreball = txtWorkZone.Text;

            com.Id = id;
            pm.InsertAgent(com);
        }

        private void txtStartYear_Enter(object sender, EventArgs e)
        {
            lblHelp.Text = "dd/mm/yyyy";
            lblHelp.ForeColor = Color.White;
            lblHelp.BackColor = Color.DarkGreen;
        }

        private void txtStartYear_Leave(object sender, EventArgs e)
        {
            lblHelp.Text = "";
            lblHelp.BackColor = Color.Transparent;
        }
    }
}
