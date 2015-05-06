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
    public partial class ChooseView_UC : UserControl
    {
        
        public ChooseView_UC()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(7, 59, 90);
        }

        public void changeLabelName(string newLabelName) {
            lblOption.Text = newLabelName;
        }

        public void changeImage(Image newImage) {
            pboxOption.Image = newImage;
        }
    }
}
