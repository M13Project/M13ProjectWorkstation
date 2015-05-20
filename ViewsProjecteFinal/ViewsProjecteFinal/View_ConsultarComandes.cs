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
    public partial class View_ConsultarComandes : Form
    {
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        public View_ConsultarComandes()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnShowDetail.BackColor = Color.FromArgb(26, 183, 234);
            this.btnShowDetail.ForeColor = Color.FromArgb(7, 59, 90);
            this.label1.ForeColor = Color.FromArgb(7, 59, 90);

            m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));
            this.gridView.DataSource = entities.Comanda.ToList();
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            String id;
            id = this.txtSelect.Text;

            Form showDetail = new View_DetallComanda(id);
            Methods.back(this, showDetail);
        }
    }
}
