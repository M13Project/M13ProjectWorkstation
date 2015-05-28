using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.ServiceReference;
using ViewsProjecteFinal.CustomClasses;

namespace ViewsProjecteFinal
{
    public partial class View_ConsultarCategories : Form
    {
        Categoria categoria = new Categoria();
        PersistanceManager pm;
        static String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));
        List<Object> categories = new List<Object>();
        public View_ConsultarCategories()
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
            pm = new PersistanceManager();

            categories = pm.gridCategoria();
            this.gridView.DataSource = categories.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form afegirCategoria = new View_AfegirCategoria();
            Methods.back(this, afegirCategoria);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try{
               int id;

                id = int.Parse(this.txtSelect.Text);

            Form modificarCategoria = new View_ModificarCategoria(id);
            Methods.back(this, modificarCategoria);
            } catch {
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
                categoria = pm.getCategoria(id);
                DialogResult result;
                result = Methods.PerformCalculations();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    pm.DeleteCategoria(categoria);
                    this.gridView.DataSource = entities.Categoria.ToList();
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

        private void View_ConsultarCategories_VisibleChanged(object sender, EventArgs e)
        {
            this.gridView.Update();
            categories = pm.gridCategoria();
            this.gridView.DataSource = categories.ToList();
            this.gridView.Refresh();
        }

        private void View_ConsultarCategories_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
