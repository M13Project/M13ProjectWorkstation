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
using ViewsProjecteFinal.ServiceReference;

namespace ViewsProjecteFinal
{
    public partial class MainViewAdmin : Form
    {
        private static int adminId;

        PersistanceManager pm = new PersistanceManager();

        public MainViewAdmin(int adminIdMain)
        {
            Usuari usuari = new Usuari();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            adminId = adminIdMain;
            usuari = pm.getUsuari(adminIdMain);
            String salutacio ="Welcome " + usuari.Nom + " " + usuari.Cognom;
            lblWelcome.Text = salutacio;
            this.lblWelcome.ForeColor = Color.FromArgb(7, 59, 90);
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
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
            chooseView_UC1.changeImage(ViewsProjecteFinal.Properties.Resources.AgentComercial);
            chooseView_UC2.changeImage(ViewsProjecteFinal.Properties.Resources.Clients);
            chooseView_UC3.changeImage(ViewsProjecteFinal.Properties.Resources.Products);
            chooseView_UC4.changeImage(ViewsProjecteFinal.Properties.Resources.Orders);
            chooseView_UC5.changeImage(ViewsProjecteFinal.Properties.Resources.Categories);
            chooseView_UC6.changeImage(ViewsProjecteFinal.Properties.Resources.Statistics);
        }
    }
}
