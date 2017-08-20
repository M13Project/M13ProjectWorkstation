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
    public partial class View_ModificarCategoria : Form
    {
        Categoria categoria = new Categoria();
        PersistanceManager pm;
        public View_ModificarCategoria(int id)
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnUpdate.BackColor = Color.FromArgb(26, 183, 234);
            this.label2.ForeColor = Color.FromArgb(7, 59, 90);
            this.label3.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnUpdate.ForeColor = Color.FromArgb(7, 59, 90);
            pm = new PersistanceManager();
            
            categoria = pm.getCategoria(id);
            this.txtName.Text = categoria.Nom;
            this.txtDiscount.Text = categoria.Descompte.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            categoria.Descompte = Double.Parse(txtDiscount.Text.ToString());
            categoria.Nom = txtName.Text.ToString();
            pm.UpdateCategoria(categoria);
        }

        private void View_ModificarCategoria_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
