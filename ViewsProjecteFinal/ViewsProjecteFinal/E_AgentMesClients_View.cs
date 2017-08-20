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
using System.Data.SqlClient;

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
            prova();
            this.reportViewer1.RefreshReport();
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

        public void prova()
        {
            String strCon = "Data Source=MARCPB;Initial Catalog=m13_project;Integrated Security=True";
            SqlConnection conBD = new SqlConnection(strCon);
            SqlCommand sql = new SqlCommand("SELECT count(ComercialId) as numClients FROM Client GROUP BY ComercialId;", conBD);
            SqlDataReader myReader;
            try
            {
                conBD.Open();
                myReader = sql.ExecuteReader();
                while (myReader.Read())
                {
                    this.chartAgentsMesClients.Series["Series1"].Points.AddXY(myReader["numClients"].ToString(), myReader["punts"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conBD.State == ConnectionState.Open)
                {
                    conBD.Close();
                }
            }
        }

        /*
        public void prova()
        {
            PersistanceManager pm = new PersistanceManager();
            IQueryable<Client> client = pm.AllClient();
            List<int> f = new List<int>(); 
            //Select count(ComercialId) From client 
            for (int i = 0; i < client.ToList().Count(); i++ )
            {
                f.Add(pm.countClient(client(i).ComercialId));
                Console.WriteLine(f.ToString());
            } 

            //chartAgentsMesClients.Series["Nom"].ChartType = SeriesChartType.Bar;
            //chartAgentsMesClients.Series["Nom"].Points.AddY(1);
            //chartAgentsMesClients.Series["Nom"].ChartArea = "ChartArea1";

            this.dataGridView1.DataSource = f;
            try
            {
                foreach (Client cli in client) {
                    chartAgentsMesClients.Series["Series1"].Points.AddY(cli.Comercial.Client.Count); 
                    //(myReader["usuari"].ToString(), myReader["punts"]);                
                }   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
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