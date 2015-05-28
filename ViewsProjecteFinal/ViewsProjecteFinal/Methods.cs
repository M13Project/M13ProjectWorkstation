using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsProjecteFinal
{
    class Methods
    {
        public static void back(Form f, Form f2) {
            PictureBoxLogout_UC pbl = new PictureBoxLogout_UC();
            f.Hide();
 
            f2.ShowDialog();
            
            f.Show();
            
        }
        public static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
        public static DialogResult PerformCalculations()
        {
            DialogResult result;
            string message = "Are you sure that you want to delete?";
            string caption = "Delete Category";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            result = MessageBox.Show(message, caption, buttons);

            return result;
        }
    }
}
