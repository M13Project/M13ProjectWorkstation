using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsProjecteFinal
{
    public partial class ButtonBack_UC : UserControl
    {
        
        public ButtonBack_UC(Form f)
        {
            InitializeComponent();
            this.btnBack.BackColor = Color.FromArgb(26, 183, 234);
            this.btnBack.ForeColor = Color.FromArgb(7, 59, 90);

        }
        public ButtonBack_UC()
        {
            InitializeComponent();
            this.btnBack.BackColor = Color.FromArgb(26, 183, 234);
            this.btnBack.ForeColor = Color.FromArgb(7, 59, 90);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bool surt = false;
            while (surt == false){
                int i = Application.OpenForms.Count - 1;
                {
                    if (Application.OpenForms[i].Name.Contains("Afegir") || Application.OpenForms[i].Name.Contains("Modificar"))
                    {
                        DialogResult result;
                        string message = "Are you sure that you want to back? The changes will disappear!";
                        string caption = "Back";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            Form.ActiveForm.Close();
                            surt = true;
                        }
                        else if (result == System.Windows.Forms.DialogResult.No) { surt = true; }

                    }
                    else
                    {
                        Form.ActiveForm.Close();
                        surt = true;
                    }
                }
            }
        }

    }
}
