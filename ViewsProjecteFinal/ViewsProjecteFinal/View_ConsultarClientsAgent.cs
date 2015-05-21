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
    public partial class View_ConsultarClientsAgent : Form
    {
        PersistanceManager pm;
        public View_ConsultarClientsAgent(String id)
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            pm = new PersistanceManager();
            this.gridView.DataSource = pm.ClientsdelComercial(pm.getComercial(int.Parse(id))).ToList();
        }

    }
}
