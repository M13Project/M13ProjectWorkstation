using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.CustomClasses;
using ViewsProjecteFinal.ServiceReference;

namespace ViewsProjecteFinal
{
    public partial class View_ModificarPerfil : Form
    {
        PersistanceManager pm;
        Usuari usuari;
        public View_ModificarPerfil(int id)
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnUpdate.BackColor = Color.FromArgb(26, 183, 234);
            this.label1.ForeColor = Color.FromArgb(7, 59, 90);
            this.label2.ForeColor = Color.FromArgb(7, 59, 90);
            this.label3.ForeColor = Color.FromArgb(7, 59, 90);
            this.label4.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnUpdate.ForeColor = Color.FromArgb(7, 59, 90);
            pm = new PersistanceManager();
            usuari = pm.getUsuari(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            usuari.Nom = txtName.Text.ToString();
            usuari.Dni = txtDNI.Text.ToString();
            usuari.Cognom = txtSurname.Text.ToString();
            usuari.Usuari1 = txtUsername.Text.ToString();
            pm.UpdatePerfil(usuari);

        }

        private void View_ModificarPerfil_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
