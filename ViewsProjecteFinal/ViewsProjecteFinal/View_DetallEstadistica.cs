using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsProjecteFinal
{
    public partial class View_DetallEstadistica : Form
    {
        public View_DetallEstadistica()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
        }

        private void View_DetallEstadistica_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
