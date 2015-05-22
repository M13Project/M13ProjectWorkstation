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
    public partial class View_ModificarProducte : Form
    {
        PersistanceManager pm;
        public View_ModificarProducte(String id)
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Producte producte = new Producte();
            Categoria cat = new Categoria();
            producte.Descompte = Double.Parse(txtDescompte.Text.ToString());
            producte.Habilitat = bool.Parse(cboxHabilitat.Checked.ToString());
            producte.Nom = txtName.Text.ToString();
            producte.Preu = Double.Parse(txtPreu.Text.ToString());
            //cat.Nom = cmbboxCategoria.SelectedText.ToString();
            
            //producte.Categoria.Id = ;
            pm.UpdateProducte(producte);

        }

        private void View_ModificarProducte_Load(object sender, EventArgs e)
        {
            foreach (Categoria cat in pm.AllCategoria())
            {
                cmbboxCategoria.Items.Add(cat.Nom);
            }
        }
    }
}
