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
    public partial class MainViewAdmin : Form
    {
        private static int adminId;

        public MainViewAdmin(int adminIdMain)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            adminId = adminIdMain;
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            changeViewSelectionLabel();
        }

        private void changeViewSelectionLabel()
        {
            chooseView_UC1.changeLabelName(EnglishStringValues.SELECTION_1);
            chooseView_UC2.changeLabelName(EnglishStringValues.SELECTION_2);
            chooseView_UC3.changeLabelName(EnglishStringValues.SELECTION_3);
            chooseView_UC4.changeLabelName(EnglishStringValues.SELECTION_4);
            chooseView_UC5.changeLabelName(EnglishStringValues.SELECTION_5);
            chooseView_UC6.changeLabelName(EnglishStringValues.SELECTION_6);
        }
    }
}
