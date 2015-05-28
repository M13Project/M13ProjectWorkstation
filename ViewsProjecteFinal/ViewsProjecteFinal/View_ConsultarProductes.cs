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
    public partial class View_ConsultarProductes : Form
    {
        Producte producte = new Producte();
        PersistanceManager pm = new PersistanceManager();
        List<Object> productes;
        public View_ConsultarProductes()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnAdd.BackColor = Color.FromArgb(26, 183, 234);
            this.btnDelete.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnDelete.ForeColor = Color.FromArgb(7, 59, 90);
            this.lblSelect.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnAdd.ForeColor = Color.FromArgb(7, 59, 90);

            productes = pm.gridProductes();
            this.gridView.DataSource = productes.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        Form afegirProducte = new View_AfegirProducte();
            Methods.back(this, afegirProducte);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                int id;

                id = int.Parse(this.txtSelect.Text);

                Form modificarProducte = new View_ModificarProducte(id);
                Methods.back(this, modificarProducte);
            }
            catch
            {
                if (txtSelect.Text.Equals(""))
                {
                    MessageBox.Show("You must write an Id in the Select text!");
                }
                else
                {
                    MessageBox.Show("Incorrect Value!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;

                id = int.Parse(this.txtSelect.Text);
                producte = pm.getProducte(id);
                DialogResult result;
                result = Methods.PerformCalculations();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    pm.DeleteProducte(producte);
                    productes = pm.gridProductes();
                    this.gridView.DataSource = productes.ToList();
                }
                else { }
            }
            catch
            {
                if (txtSelect.Text.Equals(""))
                {
                    MessageBox.Show("You must write an Id in the Select text!");
                }
                else
                {
                    MessageBox.Show("Incorrect Value!");
                }
            }
        }

        private void View_ConsultarProductes_VisibleChanged(object sender, EventArgs e)
        {
            this.Refresh();
            this.Update();
            productes = pm.gridProductes();
            this.gridView.DataSource = productes.ToList();
        }

        private void View_ConsultarProductes_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}