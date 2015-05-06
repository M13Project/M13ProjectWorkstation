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
        public ButtonBack_UC()
        {
            InitializeComponent();
            this.btnBack.BackColor = Color.FromArgb(26, 183, 234);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
            Form viewLogin = new View_Login();
            viewLogin.Show();
        }
    }
}
