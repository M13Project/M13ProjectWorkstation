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
    public partial class View_Login : Form
    {
        public View_Login()
        {
            InitializeComponent();
        }

        private void View_Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                this.Hide();
                Form mainViewAdmin = new MainViewAdmin();
                mainViewAdmin.Show();
            }
            else if (txtUsername.Text.Equals("agent") && txtPassword.Text.Equals("agent"))
            {
                this.Hide();
                Form mainViewAgent = new MainViewAgent();
                mainViewAgent.Show();
            }

        }
    }
}
