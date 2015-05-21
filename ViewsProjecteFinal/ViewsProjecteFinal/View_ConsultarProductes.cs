﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.CustomClasses;
using ViewsProjecteFinal.ServiceReference;

namespace ViewsProjecteFinal
{
    public partial class View_ConsultarProductes : Form
    {
        String webServiceDomain = "http://localhost:52220/M13ProjectWcfDataService.svc/";
        PersistanceManager pm;
        public View_ConsultarProductes()
        {
            InitializeComponent();
            this.lblTitolView.ForeColor = Color.FromArgb(26, 183, 234);
            this.btnAdd.BackColor = Color.FromArgb(26, 183, 234);
            this.btnDelete.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.BackColor = Color.FromArgb(26, 183, 234);
            this.btnModify.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnDelete.ForeColor = Color.FromArgb(7, 59, 90);
            this.lblSelect.ForeColor = Color.FromArgb(7, 59, 90);
            this.btnAdd.ForeColor = Color.FromArgb(7, 59, 90);
            pm = new PersistanceManager();

            m13_projectEntities1 entities = new m13_projectEntities1(new Uri(webServiceDomain));
            var query = from asd in entities.Producte
                        select new
                        {
                            ID = asd.Id,
                            Name = asd.Nom,
                            Price = asd.Preu,
                            Discount = asd.Descompte,
                            Hability = asd.Habilitat,
                            Category = asd.Categoria
                        };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.Category);

            }
            this.gridView.DataSource = query.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form afegirProducte = new View_AfegirProducte();
            Methods.back(this, afegirProducte);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
                    
            try
            {
                int id;

                id = int.Parse(this.txtSelect.Text);

                Form modificarProducte = new View_ModificarProducte(id);
                Methods.back(this, modificarProducte);
            }
            catch
            {
                if (txtSelect.Text.Equals(""))
                {
                    MessageBox.Show("Introdueix una id al camp de text!");
                }
                else
                {
                    MessageBox.Show("Valor incorrecte!");
                }
            }
        }

        private void View_ConsultarProductes_VisibleChanged(object sender, EventArgs e)
        {
            this.gridView.Update();
            this.gridView.DataSource = pm.AllProductes().ToList();
            
            //this.gridView
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Producte producte = new Producte();
            try
            {
                int id;

                id = int.Parse(this.txtSelect.Text);
                producte = pm.getProducte(id);
                DialogResult result;
                result = Methods.PerformCalculations();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    pm.DeleteProducte(producte);
                    this.gridView.Update();
                    this.gridView.DataSource = pm.AllProductes().ToList();
                }
                else { }
            }
            catch
            {
                if (txtSelect.Text.Equals(""))
                {
                    MessageBox.Show("Introdueix una id al camp de text!");
                }
                else
                {
                    MessageBox.Show("Valor incorrecte!");
                }
            }
        }
    }
}
