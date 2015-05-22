using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.CustomClasses;

namespace ViewsProjecteFinal
{    
    public partial class ChooseView_UC : UserControl
    {
        private static String idChoose;

        public ChooseView_UC()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(7, 59, 90);
            this.lblOption.ForeColor = Color.FromArgb(7, 59, 90);
        }
        
        public void changeLabelName(string newLabelName) {
            lblOption.Text = newLabelName;
        }

        public void changeImage(Image newImage) {
            pboxOption.Image = newImage;
        }

        private void pboxOption_Click(object sender, EventArgs e)
        {
            idChoose = Form.ActiveForm.GetType().ToString();
            showForms(idChoose);
        }        

        private void lblOption_Click(object sender, EventArgs e)
        {
            idChoose = Form.ActiveForm.GetType().ToString();
            showForms(idChoose);
        }

        public void showForms(String form)
        {
            Form f = Form.ActiveForm;

            if (form.Equals("ViewsProjecteFinal.MainViewAdmin"))
            {
                if (this.lblOption.Text == EnglishStringValues.SELECTION_1)
                {
                    f = new View_ConsultarAgents();
                }
                else if (this.lblOption.Text == EnglishStringValues.SELECTION_2)
                {
                    f = new View_ConsultarClients();
                }
                else if (this.lblOption.Text == EnglishStringValues.SELECTION_3)
                {
                    f = new View_ConsultarProductes();
                }
                else if (this.lblOption.Text == EnglishStringValues.SELECTION_4)
                {
                    f = new View_ConsultarComandes();
                }
                else if (this.lblOption.Text == EnglishStringValues.SELECTION_5)
                {
                    f = new View_ConsultarCategories();
                }
                else if (this.lblOption.Text == EnglishStringValues.SELECTION_6)
                {
                    f = new View_ConsultarEstadistiques();
                }
                Methods.back(MainViewAdmin.ActiveForm, f);
            }
            else if (form.Equals("ViewsProjecteFinal.MainViewAgent"))
            {
                if (this.lblOption.Text == EnglishStringValues.SELECTION_AC_1)
                {
                    //f = new View_ModificarPerfil();
                }
                else if (this.lblOption.Text == EnglishStringValues.SELECTION_AC_2)
                {
                    f = new View_ConsultarProductesAgent();
                }
                else if (this.lblOption.Text == EnglishStringValues.SELECTION_AC_3)
                {
                    f = new View_ConsultarClientsAgent();
                }
                else if (this.lblOption.Text == EnglishStringValues.SELECTION_AC_4)
                {
                    f = new View_ConsultarComandes();
                }
                Methods.back(MainViewAgent.ActiveForm, f);
            }
        }

    }
}
