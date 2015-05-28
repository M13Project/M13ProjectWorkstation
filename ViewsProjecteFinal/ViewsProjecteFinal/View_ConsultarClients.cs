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
    public partial class View_ConsultarClients : Form
    {
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        List<Object> cli = new List<Object>();
        PersistanceManager pm = new PersistanceManager();
        public View_ConsultarClients()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));
            cli = pm.gridClients();
            this.gridView.DataSource = cli.ToList();
        }

        private void View_ConsultarClients_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
