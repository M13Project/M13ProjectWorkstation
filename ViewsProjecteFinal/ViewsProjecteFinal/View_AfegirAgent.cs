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
    public partial class View_AfegirAgent : Form
    {

        PersistanceManager pm = new PersistanceManager();
        MonthCalendar mc = new MonthCalendar();

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
            String a = txtStartYear.ToString() + " 00:00:00";
            com.AnyInici = DateTime.Parse(a);
            com.ZonaTreball = txtWorkZone.ToString();
            Usuari us = new Usuari();
            us.Nom = txtName.ToString();
            us.Cognom = txtSurname.ToString();
            us.Dni = txtDNI.ToString();
            us.Usuari1 = txtUsername.ToString();
            us.Contrasenya = txtPassword.ToString();
            us.Comercial = com;

            pm.InsertAgent(com);
            pm.InsertUser(us);
        }

        private void txtStartYear_Enter(object sender, EventArgs e)
        {
            lblHelp.Text = "yyyy-mm-dd";
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
