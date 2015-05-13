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

namespace ViewsProjecteFinal
{
    public partial class View_ConsultarAgents : Form
    {
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        public View_ConsultarAgents()
        {
           
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnAdd.BackColor = Color.FromArgb(26, 183, 234);
            this.btnDelete.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnDelete.ForeColor = Color.FromArgb(7, 59, 90);
            this.lblSelect.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnAdd.ForeColor = Color.FromArgb(7, 59, 90);

            m13_projectEntities entities = new m13_projectEntities(new Uri(webServiceDomain));
            

            /**/
            //IQueryable<Usuari> query = from usuari in entities.Usuari select usuari;
            //foreach (Usuari usda in query)
            //{
            //    entities.LoadProperty(usda, "Comercial");

            //}
            //var query = from asd in entities.Usuari
            //            join comdsa in entities.Comercial on asd.Id equals comdsa.Id
            //            select new { Name = asd.Nom, Zona = comdsa.ZonaTreball };
            /**/


            //var query = from usuari in entities.Usuari
            //            join com in entities.Comercial on usuari.Id equals com.Id into prodGroup
            //            select new
            //            {
            //                Comercial = from prod2 in prodGroup select prod2

            //            };

            //foreach (var productGroup in query)
            //{
            //    Console.WriteLine(productGroup.Comercial);
            //}
            this.gridView.DataSource = entities.Comercial.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form afegirAgent = new View_AfegirAgent();
            Methods.back(this, afegirAgent);

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            String id;
            id = this.txtSelect.Text;

            Form modificarCategoria = new View_ModificarCategoria(id);
            Methods.back(this, modificarCategoria);
        }
    }
}
