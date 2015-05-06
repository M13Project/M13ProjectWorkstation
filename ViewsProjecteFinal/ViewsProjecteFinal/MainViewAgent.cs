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
    public partial class MainViewAgent : Form
    {
        private int agentId;

        public MainViewAgent(int agentId)
        {
            InitializeComponent();
            this.agentId = agentId;
        }
    }
}
