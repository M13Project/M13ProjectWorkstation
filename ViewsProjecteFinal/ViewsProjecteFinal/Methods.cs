using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsProjecteFinal
{
    class Methods
    {
        public static void back(Form f, Form f2) {
            f.Hide();
 
            f2.ShowDialog();

            f.Show(); 
        }
    }
}
