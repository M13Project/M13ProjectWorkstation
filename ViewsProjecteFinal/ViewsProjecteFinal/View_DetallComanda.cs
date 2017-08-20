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
    public partial class View_DetallComanda : Form
    {
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        m13_projectEntities1 entities;
        PersistanceManager pm = new PersistanceManager();
        public View_DetallComanda(int id, int idCom)
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);

            entities = new m13_projectEntities1(new Uri(webServiceDomain));
            this.gridView.DataSource = pm.gridDetallComandes(id, idCom).ToList();
        }

        private void View_DetallComanda_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
