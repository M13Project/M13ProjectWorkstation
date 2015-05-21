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
        static String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));        
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
            
            
        }

        private void btnAddProducte_Click(object sender, EventArgs e)
        {
            Producte producte = new Producte();
            producte.Nom = txtName.Text.ToString();
            producte.Preu = Double.Parse(txtPreu.Text.ToString());
            producte.Descompte = Double.Parse(txtDescompte.Text.ToString());
            producte.Habilitat = bool.Parse(cboxHabilitat.Checked.ToString());
            foreach (Categoria cat in pm.AllCategoria())
            {
                if (cmbboxCategoria.SelectedItem.ToString().Equals(cat.Nom))
                {
                    producte.CategoriaId = cat.Id;
                }
            }

            
            pm.InsertProduct(producte);
        }
        
        private void View_AfegirProducte_Load(object sender, EventArgs e)
        {
            List<int> h = new List<int>();
            foreach (Categoria cat in pm.AllCategoria())
            {
                h.Add(cat.Id);
                cmbboxCategoria.Items.Add(cat.Nom);
            }
        }
    }
}
