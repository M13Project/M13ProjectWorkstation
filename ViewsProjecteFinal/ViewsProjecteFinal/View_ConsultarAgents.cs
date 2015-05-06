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
    public partial class View_ConsultarAgents : Form
    {
        public View_ConsultarAgents()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnAdd.BackColor = Color.FromArgb(26, 183, 234);
            this.btnDelete.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.BackColor = Color.FromArgb(26, 183, 234);

        }
    }
}
