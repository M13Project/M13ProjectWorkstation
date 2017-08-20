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
    public partial class MainViewAgent : Form
    {
        private int agentId;

        public MainViewAgent(int agentId)
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.agentId = agentId;
            chooseView_UC1.changeLabelName(EnglishStringValues.SELECTION_AC_1);
            chooseView_UC2.changeLabelName(EnglishStringValues.SELECTION_AC_2);
            chooseView_UC3.changeLabelName(EnglishStringValues.SELECTION_AC_3);
            chooseView_UC4.changeLabelName(EnglishStringValues.SELECTION_AC_4);
        }

        private void MainViewAgent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }        
    }
}
