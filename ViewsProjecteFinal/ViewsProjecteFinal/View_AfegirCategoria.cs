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
    public partial class View_AfegirCategoria : Form
    {
        PersistanceManager pm;
        public View_AfegirCategoria()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnAdd.BackColor = Color.FromArgb(26, 183, 234);
            this.label2.ForeColor = Color.FromArgb(7, 59, 90);
            this.label3.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnAdd.ForeColor = Color.FromArgb(7, 59, 90);
            pm = new PersistanceManager();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Nom = txtName.Text.ToString();
            categoria.Descompte = Double.Parse(txtDiscount.Text.ToString());
            pm.InsertCategoria(categoria);

        }
    }
}
