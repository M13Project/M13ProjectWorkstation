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
            

            var query = from asd in entities.Comercial
                         select new
                         {
                             asd.Usuari.Id,
                             asd.Usuari.Nom,
                             asd.Usuari.Cognom,
                             asd.Usuari.Dni,
                             asd.Usuari.Contrasenya,
                             asd.AnyInici, 
                             ZonaT = asd.ZonaTreball,
                             asd.Habilitat
                         };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.AnyInici);
                Console.WriteLine(productGroup.ZonaT);
                Console.WriteLine(productGroup.Habilitat);

            }
            this.gridView.DataSource = query.ToList();
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

            Form modificarAgent = new View_ModificarAgent(id);
            Methods.back(this, modificarAgent);
        }
    }
}
