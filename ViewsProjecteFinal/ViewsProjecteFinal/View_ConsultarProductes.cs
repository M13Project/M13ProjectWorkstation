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
using ViewsProjecteFinal.CustomClasses;

namespace ViewsProjecteFinal
{
    public partial class View_ConsultarProductes : Form
    {
        Producte producte = new Producte();
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        PersistanceManager pm;
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
            pm = new PersistanceManager();

            m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));
            var query = from asd in entities.Producte
                        select new
                        {
                            asd.Id,
                            asd.Nom,
                            asd.Preu,
                            asd.Descompte,
                            asd.Habilitat,
                            Categoria = asd.Categoria
                        };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.Categoria);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form afegirProducte = new View_AfegirProducte();
            Methods.back(this, afegirProducte);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            Form modificarProducte = new View_ModificarProducte(txtSelect.Text.ToString());
            Methods.back(this, modificarProducte);
        }
    }
}
