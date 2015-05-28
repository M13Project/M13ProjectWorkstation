using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.CustomClasses;
using ViewsProjecteFinal.ServiceReference;

namespace ViewsProjecteFinal
{
    
    public partial class ModificarAgent : Form
    {
        PersistanceManager pm;
        Usuari usuari = new Usuari();
        Comercial comercial = new Comercial();
        public ModificarAgent(int id)
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
            this.label8.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnUpdate.ForeColor = Color.FromArgb(7, 59, 90);
            pboxPerfil.Image = ViewsProjecteFinal.Properties.Resources.AgentComercialDefecte;
            pm = new PersistanceManager();
            usuari = pm.getUsuari(id);
            comercial = pm.getComercial(id);

            this.txtName.Text = usuari.Nom;
            this.txtDNI.Text = usuari.Dni;
            this.txtPassword.Text = usuari.Contrasenya;
            this.txtSurname.Text = usuari.Cognom;
            this.txtUsername.Text = usuari.Usuari1;
            this.txtWorkZone.Text = comercial.ZonaTreball;
            DateTime dt = (DateTime)comercial.AnyInici;
            txtStartYear.Text = dt.Date.ToString();
            this.cboxHabilitat.Checked = comercial.Habilitat;
            this.pboxPerfil.ImageLocation = usuari.Imatge;
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string date = txtStartYear.Text.ToString();
            DateTime dt = Convert.ToDateTime(date);
            comercial.AnyInici = dt;
            comercial.ZonaTreball = txtWorkZone.Text.ToString();
            comercial.Habilitat = bool.Parse(cboxHabilitat.Checked.ToString());
            usuari.Nom = txtName.Text.ToString();
            usuari.Cognom = txtSurname.Text.ToString();
            usuari.Contrasenya = Methods.ComputeHash( txtPassword.Text.ToString() , new SHA256CryptoServiceProvider());
            usuari.Dni = txtDNI.Text.ToString();
            usuari.Usuari1 = txtUsername.Text.ToString();
            usuari.Imatge = pboxPerfil.ImageLocation;

            pm.UpdateAgent(comercial);
            pm.UpdatePerfil(usuari);

        }

        private void View_ModificarAgent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pboxPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "Jpg files (*.jpg)|*.jpg|Png files (*.png)|*.png|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;
                    string filepath = opFile.FileName;

                    File.Copy(filepath, appPath + iName);
                    pboxPerfil.Image = new Bitmap(opFile.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
    }
}
