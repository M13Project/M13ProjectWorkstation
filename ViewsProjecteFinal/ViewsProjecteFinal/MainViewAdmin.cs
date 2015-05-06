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
    public partial class MainViewAdmin : Form
    {
        private int adminId;

        public MainViewAdmin(int adminId)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.adminId = adminId;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //chooseView_UC_CAgents.BackColor = System.Drawing.Color.FromArgb(7, 59, 90);
            
        }
    }
}
