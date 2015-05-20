using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.CustomClasses;
using ViewsProjecteFinal.ServiceReference;

namespace ViewsProjecteFinal
{
    
    public partial class View_ModificarAgent : Form
    {
        PersistanceManager pm = new PersistanceManager();
        public View_ModificarAgent(String id)
        {
            InitializeComponent();

            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnUpdate.BackColor = Color.FromArgb(26, 183, 234);
            this.label1.ForeColor = Color.FromArgb(7, 59, 90);
            this.label2.ForeColor = Color.FromArgb(7, 59, 90);
            this.label3.ForeColor = Color.FromArgb(7, 59, 90);
            this.label4.ForeColor = Color.FromArgb(7, 59, 90);
            this.label5.ForeColor = Color.FromArgb(7, 59, 90);
            this.label6.ForeColor = Color.FromArgb(7, 59, 90);
            this.label7.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnUpdate.ForeColor = Color.FromArgb(7, 59, 90);
            this.txtName.Text = id;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Usuari usuari = new Usuari();
            Comercial comercial = new Comercial();
            //comercial.AnyInici = txtStartYear.Text.ToString();
            comercial.ZonaTreball = txtWorkZone.Text.ToString();
            comercial.Habilitat = bool.Parse(cboxHabilitat.Checked.ToString());
            usuari.Nom = txtName.Text.ToString();
            usuari.Cognom = txtSurname.Text.ToString();
            usuari.Contrasenya = Methods.ComputeHash( txtPassword.Text.ToString() , new SHA256CryptoServiceProvider());
            usuari.Dni = txtDNI.Text.ToString();
            usuari.Usuari1 = txtUsername.Text.ToString();

            //usuari.Imatge = pictureBox1.
            //usuari.Comercial = comercial;
            //comercial.Usuari = usuari;
            pm.UpdateAgent(comercial);
            pm.UpdatePerfil(usuari);

        }
    }
}
