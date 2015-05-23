using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewsProjecteFinal.ServiceReference;
using ViewsProjecteFinal.CustomClasses;
using System.Windows.Forms.DataVisualization.Charting;

namespace ViewsProjecteFinal
{
    public partial class E_AgentMesClients_View : Form
    {
        m13_projectEntities1 remoteDataContext;
        PersistanceManager pm;
        public E_AgentMesClients_View()
        {
            InitializeComponent();
            
        }

        private void E_AgentMesClients_View_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            provaChart();
        }
        public void provaChart()
        {
            pm = new PersistanceManager();
            remoteDataContext = new m13_projectEntities1(new Uri("http://localhost:52220/M13ProjectWcfDataService.svc/"));
            //var usuaris = localEntities.Usuari.Include(g => g.);
            //Usuari us = (from user in remoteDataContext.Usuari select user);
            //var query = remoteDataContext.LoadProperty(us, "Comercial");

            chartAgentsMesClients.Series["Nom"].ChartType = SeriesChartType.Bar;
            chartAgentsMesClients.Series["Nom"].Points.AddY(1);
            chartAgentsMesClients.Series["Nom"].ChartArea = "ChartArea1";
            //Add a chart at run time.
            chartAgentsMesClients.Series.Add("RuntimeSeries");
            chartAgentsMesClients.Series["RuntimeSeries"].ChartType = SeriesChartType.Bar;
            chartAgentsMesClients.Series["RuntimeSeries"].ChartArea = "ChartArea2";
            //foreach (var usuari in query)
            {
                //chartAgentsMesClients.Series["RuntimeSeries"].Points.AddY(usuari.Comercial.Client.Count);
            }    
        }
    }
}
//// TODO: This line of code loads data into the 'MyTestDatabaseDataSet.Usuari' table. You can move, or remove it, as needed.
//            this.UsuariTableAdapter.Fill(this.MyTestDatabaseDataSet.Usuari);
//            //label1.Text = ComputeHash("qwertyuiop", new SHA256CryptoServiceProvider());
//            this.reportViewer1.RefreshReport();

//            provaInforme();
//        }

//        //public static string ComputeHash(string input, HashAlgorithm algorithm)
//        //{
//        //    Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

//        //    Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

//        //    String hashString = BitConverter.ToString(hashedBytes);

//        //    return hashString;
//        //}

//        public void provaInforme() {
//            MyTestDatabaseEntities localEntities = new MyTestDatabaseEntities();

//            //var usuaris = localEntities.Usuari.Include(g => g.);

//            var eager = localEntities.Usuari.Include("Comercial.Client");     
            

//            chart1.Series["Edat"].ChartType = SeriesChartType.Bar;
//            chart1.Series["Edat"].Points.AddY(1);
//            chart1.Series["Edat"].ChartArea = "ChartArea1";

//            //Add a chart at run time.
//            chart1.Series.Add("RuntimeSeries");
//            chart1.Series["RuntimeSeries"].ChartType = SeriesChartType.Bar;
//            chart1.Series["RuntimeSeries"].ChartArea = "ChartArea2";

//            foreach (Usuari usuari in eager)
//            {
//                chart1.Series["RuntimeSeries"].Points.AddY(usuari.Comercial.Client.Count);
//            }                        
//        }