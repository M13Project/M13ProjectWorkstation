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

namespace ViewsProjecteFinal
{
    public partial class View_DetallComandaAgent : Form
    {
        PersistanceManager pm;
        public View_DetallComandaAgent(int id)
        {
            InitializeComponent();

            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            pm = new PersistanceManager();
            gridView.DataSource = pm.ComandesdelComercial(pm.getComercial(id));

        }

        private void View_DetallComandaAgent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
