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
    public partial class View_DetallComanda : Form
    {
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        public View_DetallComanda(String id)
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);

            m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));


            var query = from asd in entities.Comanda_Producte
                        select new
                        {
                            Quantity = asd.Quantitat,
                            Date = asd.Comanda.Data,
                            Committed = asd.Comanda.Lliurada,
                            Name_Category = asd.Producte.Categoria.Nom,
                            Enabled = asd.Producte.Habilitat,
                            Name_Product = asd.Producte.Nom,
                            Price_Product = asd.Producte.Preu,
                            Discount = asd.Producte.Descompte
                        };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.Committed);
                Console.WriteLine(productGroup.Date);
                Console.WriteLine(productGroup.Discount);
                Console.WriteLine(productGroup.Enabled);
                Console.WriteLine(productGroup.Name_Category);
                Console.WriteLine(productGroup.Name_Product);
                Console.WriteLine(productGroup.Price_Product);
                Console.WriteLine(productGroup.Quantity);
            }
            this.gridView.DataSource = query.ToList();
        }
    }
}
