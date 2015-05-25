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
    public partial class View_Login : Form
    {
        private LoginController lc;

        public View_Login()
        {
            InitializeComponent();
            lc = new LoginController();
            this.AcceptButton = btnSignIn;
        }

        private void View_Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            int userId = lc.checkUserSignIn(txtUsername.Text, txtPassword.Text);
            if (userId == 0)
            {
                MessageBox.Show(EnglishStringValues.LOGIN_MESSAGEBOX);
            }
            else 
            {
                if (userId > 0)
                {
                    //Activate main screen that agent will see
                    MainViewAgent mainViewAgent = new MainViewAgent(userId);                    
                    this.Hide();
                    mainViewAgent.Show();
                }
                else 
                {
                    //Activate main screen that administrator will see
                    MainViewAdmin mainViewAdmin = new MainViewAdmin(-userId);
                    this.Hide();
                    mainViewAdmin.Show();
                }    
            }            
        }

        private void txtUsername_EnterFocus(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_EnterFocus(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            this.txtPassword.PasswordChar = '*';
        }        
    }
}
