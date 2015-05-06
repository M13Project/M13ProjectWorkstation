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
    public partial class View_ConsultarComandes : Form
    {
        public View_ConsultarComandes()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnShowDetail.BackColor = Color.FromArgb(26, 183, 234);
            this.btnShowDetail.ForeColor = Color.FromArgb(7, 59, 90);
            this.label1.ForeColor = Color.FromArgb(7, 59, 90);
        }
    }
}
