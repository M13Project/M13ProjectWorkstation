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
    public partial class PictureBoxLogout_UC : UserControl
    {
        public PictureBoxLogout_UC()
        {
            InitializeComponent();
            
        }

        private void onClickLogout(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name.Equals("View_Login"))
                {
                    Application.OpenForms[i].Show();
                }
                if (!Application.OpenForms[i].Name.Equals("View_Login")){
                    Application.OpenForms[i].Close();
                }
            }
        }
    }
}
