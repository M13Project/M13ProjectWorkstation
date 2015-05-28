using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Producte producte = new Producte();
        PersistanceManager pm;
        public View_ModificarProducte(int id)
        {
            InitializeComponent();
            
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnUpdate.BackColor = Color.FromArgb(26, 183, 234);
            this.label1.ForeColor = Color.FromArgb(7, 59, 90);
            this.label2.ForeColor = Color.FromArgb(7, 59, 90);
            this.label3.ForeColor = Color.FromArgb(7, 59, 90);
            this.label4.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnUpdate.ForeColor = Color.FromArgb(7, 59, 90);
            pboxProfilePicture.Image = ViewsProjecteFinal.Properties.Resources.ProductDefault;
            pm = new PersistanceManager();
            foreach (Categoria cat in pm.AllCategoria())
            {
                cmbboxCategoria.Items.Add(cat.Nom);
            }
            producte = pm.getProducte(id);
            txtDescompte.Text = producte.Descompte.ToString();
            txtName.Text = producte.Nom;
            txtPreu.Text = producte.Preu.ToString();
            cboxHabilitat.Checked = producte.Habilitat;
            cmbboxCategoria.SelectedItem = pm.getCategoria(producte.CategoriaId).Nom;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            pm.UpdateProducte(producte);

        }

        private void View_ModificarProducte_Load(object sender, EventArgs e)
        {
            foreach (Categoria cat in pm.AllCategoria())
            {
                cmbboxCategoria.Items.Add(cat.Nom);
            }
            cmbboxCategoria.SelectedItem = producte.Categoria.Nom;
        }

        private void View_ModificarProducte_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pboxProfilePicture_Click(object sender, EventArgs e)
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
                    pboxProfilePicture.Image = new Bitmap(opFile.OpenFile());
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
