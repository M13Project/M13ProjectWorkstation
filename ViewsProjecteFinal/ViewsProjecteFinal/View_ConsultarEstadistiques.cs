﻿using System;
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
    public partial class View_ConsultarEstadistiques : Form
    {
        public View_ConsultarEstadistiques()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnMostClients.BackColor = Color.FromArgb(26, 183, 234);
            this.btnMostOrders.BackColor = Color.FromArgb(26, 183, 234);
            this.btnMostSold.BackColor = Color.FromArgb(26, 183, 234);
        }
    }
}
