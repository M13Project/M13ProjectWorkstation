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
    public partial class View_AfegirProducte : Form
    {
        PersistanceManager pm = new PersistanceManager();
        public View_AfegirProducte()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnAdd.BackColor = Color.FromArgb(26, 183, 234);
            this.label1.ForeColor = Color.FromArgb(7, 59, 90);
            this.label2.ForeColor = Color.FromArgb(7, 59, 90);
            this.label3.ForeColor = Color.FromArgb(7, 59, 90);
            this.label4.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnAdd.ForeColor = Color.FromArgb(7, 59, 90);

            
        //        System.Object[] ItemObject = new System.Object[];
        //    for (int i = 0; i <= 9; i++)
        //    {
        //        ItemObject[i] = "Item" + i;
        //    }
        //        cmbboxCategoria.Items.AddRange(ItemObject);
        }

        private void btnAddProducte_Click(object sender, EventArgs e)
        {
            Producte producte = new Producte();
            producte.Nom = txtName.Text.ToString();
            producte.Preu = Double.Parse(txtPreu.Text.ToString());
            producte.Descompte = Double.Parse(txtDescompte.Text.ToString());
            producte.Habilitat = bool.Parse( cboxHabilitat.Text.ToString());
            producte.Categoria.Nom = cmbboxCategoria.Text.ToString();
            pm.InsertProduct(producte);
        }
    }
}
