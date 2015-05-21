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
    public partial class View_ConsultarProductesAgent : Form
    {
        PersistanceManager pm;
        public View_ConsultarProductesAgent()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            pm = new PersistanceManager();
        }

        private void View_ConsultarProductesAgent_VisibleChanged(object sender, EventArgs e)
        {
            this.gridView.Update();

        }
    }
}
