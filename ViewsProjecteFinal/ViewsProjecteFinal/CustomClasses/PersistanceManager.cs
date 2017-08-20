using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewsProjecteFinal.ServiceReference;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ViewsProjecteFinal.CustomClasses
{
    class PersistanceManager
    {
        private m13_projectEntities1 remoteDataContext;

        public PersistanceManager() {
            remoteDataContext = new m13_projectEntities1(new Uri("http://localhost:52220/M13ProjectWcfDataService.svc/"));
        }

        public Usuari getUserWithUsernameAndPassword(string username, string password) {
            String password_encripted = Methods.ComputeHash(password , new SHA256CryptoServiceProvider());
            //IQueryable query = from user in remoteDataContext.Usuari select new { Username = user.Usuari1, Password = user.Contrasenya, isComercial = user.Comercial };
            Usuari extractedUser = (from user in remoteDataContext.Usuari where user.Usuari1.Equals(username) && user.Contrasenya.Equals(password) select user).SingleOrDefault();
            if(extractedUser != null) {
                remoteDataContext.LoadProperty(extractedUser, "Comercial");
            }            
            return extractedUser;
        }
        //Inserts
        public void InsertAgent(Comercial comercial)
        {
            try
            {
                remoteDataContext.AddToComercial(comercial);
                remoteDataContext.SaveChanges();
                MessageBox.Show("Successfully added!");

            } catch (Exception e){
                MessageBox.Show("The Agent couldn't be added: ");
        }
         }
        public int InsertUser(Usuari usuari)
        {
            try
            {
            remoteDataContext.AddToUsuari(usuari);
            remoteDataContext.SaveChanges();
            } catch (Exception e){
                MessageBox.Show("The User couldn't be added");
        }
            return usuari.Id;
        }
        public void InsertCategoria(Categoria categoria)
        {
            try
            {
            remoteDataContext.AddToCategoria(categoria);
            remoteDataContext.SaveChanges();
            MessageBox.Show("Successfully added!");
            }
            catch (Exception e)
            {
                MessageBox.Show("The Category couldn't be added ");
            }
        }
        public void InsertProduct(Producte producte)
        {
            try 
            {
            remoteDataContext.AddToProducte(producte);
            remoteDataContext.SaveChanges();
            MessageBox.Show("Successfully added!");
            }
            catch (Exception e)
            {
                MessageBox.Show("The Product couldn't be added ");
            }
            
        }
        public void InsertToClients(Client client)
        {
            try
            {
            remoteDataContext.AddToClient(client);
            remoteDataContext.SaveChanges();
            MessageBox.Show("Successfully added!");
            }
            catch (Exception e)
            {
                MessageBox.Show("The Client couldn't be added ");
            }
        }
        public void InsertComanda_Producte(Comanda_Producte comanda_producte)
        {
            try
            {
                remoteDataContext.AddToComanda_Producte(comanda_producte);
                remoteDataContext.SaveChanges();
                MessageBox.Show("Successfully added!");
                            }
            catch (Exception e)
            {
                MessageBox.Show("The Order couldn't be added ");
            }
        }
        //public void AddCategoria(Producte category) {
        //    remoteDataContext.AddObject("Categoria", category);
        //}
        //Gets
        public IQueryable<Usuari> AllUsuari()
        {
            var u = from usuari in remoteDataContext.Usuari select usuari;
            return u;
        }
        public IQueryable<Comercial> AllComercial()
        {
            var c = from comercial in remoteDataContext.Comercial select comercial;
            return c;
        }
        public IQueryable<Categoria> AllCategoria()
        {
            var cat = from categoria in remoteDataContext.Categoria select categoria;
            return cat ;

        }
        public IQueryable<Client> AllClient()
        {

            var cli =  from client in remoteDataContext.Client select client;
            return cli;

        }
        public IQueryable<Client> AllClientAgent(int id)
        {

            var cli = from client in remoteDataContext.Client where client.ComercialId == id select client;
            return cli;

        }
        public IQueryable<Comanda> AllComandes()
        {
            var com = from comandes in remoteDataContext.Comanda select comandes;
            return com;
        }
        public IQueryable<Producte> AllProductes()
        {
            var prod = from productes in remoteDataContext.Producte select productes;
            return prod;
        }
        public IQueryable<Comanda> ComandesdelComercial(Comercial comercial)
        {
            var com = from comandes in remoteDataContext.Comanda where comandes.ComercialId == comercial.Id select comandes;
            return com;
        }
        public IQueryable<Comanda> ComandesdelClient(Client client)
        {
            var com = from comandes in remoteDataContext.Comanda where comandes.Client.Id == client.Id select comandes;
            return com;
        }
        public IQueryable<Comanda_Producte> AllProducteinComanda(Comanda c)
        {
            var linies = from comanda_producte in remoteDataContext.Comanda_Producte where comanda_producte.ComandaId == c.Id select comanda_producte;
                return linies;
        }
        public IQueryable<Client> ClientsdelComercial(Comercial c)
        {
            var cli = from clients in remoteDataContext.Client where clients.Comercial.Id == c.Id select clients;
            return cli;
        }
        public IQueryable<Producte> ProductesdeCategoria(Categoria c)
        {
            var pro = from productes in remoteDataContext.Producte where productes.CategoriaId == c.Id select productes;
            return pro;
        }
        public Client getClient(String name, String surname)
        {
            Client client = (from clients in remoteDataContext.Client where clients.Nom.Equals(name) && clients.Cognom.Equals(surname) select clients).SingleOrDefault();
            return client;
        }
        public Client getClient(int id)
        {
            Client client = (from clients in remoteDataContext.Client where clients.Id == id select clients).SingleOrDefault();
            return client;
        }
        public Usuari getUsuari(int id)
        {
            Usuari u = (from usuari in remoteDataContext.Usuari where usuari.Id == id select usuari).SingleOrDefault();
            return u;
        }
        public Categoria getCategoria(int id)
        {
            Categoria cat = (from categoria in remoteDataContext.Categoria where categoria.Id == id select categoria).SingleOrDefault();
            return cat;
        }
        public Comercial getComercial(int id)
        {
            Comercial com = (from comercial in remoteDataContext.Comercial where comercial.Id == id select comercial).SingleOrDefault();
            return com;
        }
        public Producte getProducte(int id)
        {
            Producte pro = (from producte in remoteDataContext.Producte where producte.Id == id select producte).SingleOrDefault();
            return pro;
        }


        
        //Updates
        public void UpdateAgent(Comercial comercial)
        {
            try
            {
            remoteDataContext.UpdateObject(comercial);
            remoteDataContext.SaveChanges();
            } catch (Exception e){
                MessageBox.Show("The Comercial couldn't be modified");
            } 
        }
        public void UpdateUser(Usuari usuari)
        {
            try{
            remoteDataContext.UpdateObject(usuari);

            remoteDataContext.SaveChanges();
            MessageBox.Show("Successfully modified!");
            } catch (Exception e){
                MessageBox.Show("The User couldn't be modified");
            } 
        }
        public void UpdateClient(Client client)
        {
            try
            {
                remoteDataContext.UpdateObject(client);
                remoteDataContext.SaveChanges();
                MessageBox.Show("Successfully modified!");
            }
            catch (Exception e)
            {
                MessageBox.Show("The Client couldn't be modified");
            }


        }
        public void UpdateCategoria(Categoria categoria)
        {
            try{
            remoteDataContext.UpdateObject(categoria);
            remoteDataContext.SaveChanges();
            MessageBox.Show("Successfully modified!");
            } catch (Exception e){
                MessageBox.Show("The Category couldn't be modified");
            } 
        }
        public void UpdateProducte(Producte producte)
        {
            try{
            remoteDataContext.UpdateObject(producte);
            remoteDataContext.SaveChanges();
            MessageBox.Show("Successfully modified!");
            } catch (Exception e){
                MessageBox.Show("The Product couldn't be modified");
            } 
        }
        public void UpdatePerfil(Usuari usuari)
        {
            try
            {
            remoteDataContext.UpdateObject(usuari);
            remoteDataContext.SaveChanges();
            MessageBox.Show("Successfully modified!");
            } catch (Exception e){
                MessageBox.Show("The User Profile couldn't be modified");
            } 
        }
        //Deletes
        public void DeleteComanda(Comanda c)
        {
            try { 
            IQueryable<Comanda_Producte> comanda_producte = AllProducteinComanda(c);
            foreach (Comanda_Producte c_P in comanda_producte)
            {
                DeleteComanda_Producte(c_P);
            }
            remoteDataContext.DeleteObject(c);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha eliminat correctament.");

            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut eliminar: " + e);
            }
        }
        public void DeleteComanda_Producte(Comanda_Producte cp)
        {
            try { 
            remoteDataContext.DeleteObject(cp);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha eliminat correctament.");

            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut eliminar: " + e);
            }
        }
        public void DeleteClient(Client c)
        {
            try { 
            IQueryable<Comanda> comandes= ComandesdelClient(c);
            foreach (Comanda comanda in comandes)
            {
                DeleteComanda(comanda);
            }
            remoteDataContext.DeleteObject(c);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha eliminat correctament.");

            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut eliminar: " + e);
            }
        }
        public void DeleteProducte(Producte p){
            try{
            remoteDataContext.DeleteObject(p);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha eliminat correctament.");

            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut eliminar: " + e);
            }
        }
        public void DeleteCategoria(Categoria c/*, Categoria NovaC*/)
        {
            try { 
            //Eliminar Productes de la categoria
            IQueryable<Producte> productes = ProductesdeCategoria(c);
            foreach(Producte p in productes  ){
                
                DeleteProducte(p);
                //Change categoria dels Productes
                // p.CategoriaId = NovaC.Id;
                //p.Categoria = NovaC;
                //UpdateProducte(p);

            }
            //Delete Categoria
            remoteDataContext.DeleteObject(c);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha eliminat correctament.");

            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut eliminar: " + e);
            }
        }
        public void DeleteComercial(Comercial c /*, Comercial NouComercial*/)
        {
            //Change or Delete all clients of comercial
            try
            {
                IQueryable<Client> client = AllClientAgent(c.Id);
                if (client.Count() != 0)
                {
                    foreach (Client cli in client)
                    {
                        DeleteClient(cli);
                        // Change 
                        //cli.Comercial = NouComercial;
                        //cli.ComercialId = NouComercia.Id;
                        //UpdateClient(cli);

                    }
                    remoteDataContext.DeleteObject(c);
                    remoteDataContext.SaveChanges();
                }
                remoteDataContext.DeleteObject(getUsuari(c.Id));
                remoteDataContext.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut eliminar: " + e);
            }
        }
        public List<Object> gridProductes() {
            List<Object> prod = new List<Object>();
            var query = from asd in remoteDataContext.Producte
                        select new
                        {
                            asd.Id,
                            Name = asd.Nom,
                            Price = asd.Preu,
                            Discount = asd.Descompte,
                            Enabled = asd.Habilitat,
                            Name_Category = asd.Categoria.Nom,
                            CategoryId = asd.CategoriaId
                        };
             foreach (var productGroup in query)
             {
                 Console.WriteLine(productGroup.Id);
                 Console.WriteLine(productGroup.Name);
                 Console.WriteLine(productGroup.Price);
                 Console.WriteLine(productGroup.Discount);
                 Console.WriteLine(productGroup.Enabled);
                 Console.WriteLine(productGroup.Name_Category);
                 Console.WriteLine(productGroup.CategoryId);
                 prod.Add(productGroup);
             }
            return prod;
        }
        public List<Object> gridUsuaris()
        {
            List<Object> prod = new List<Object>();
            var query = from asd in remoteDataContext.Comercial
                         select new
                         {
                             asd.Usuari.Id,
                             Name = asd.Usuari.Nom,
                             Surname = asd.Usuari.Cognom,
                             Username = asd.Usuari.Usuari1,
                             IDCard = asd.Usuari.Dni,
                             Start_Year = asd.AnyInici, 
                             Work_Zone = asd.ZonaTreball,
                             Enabled = asd.Habilitat
                         };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.Start_Year);
                Console.WriteLine(productGroup.Work_Zone);
                Console.WriteLine(productGroup.Enabled);
                prod.Add(productGroup);
            }
            return prod;
        }
        public List<Object> gridClients()
        {
            List<Object> prod = new List<Object>();
            var query = from asd in remoteDataContext.Client
                        select new
                        {
                            asd.Id,
                            Name = asd.Nom,
                            Surname = asd.Cognom,
                            Age = asd.Edat,
                            IDCard = asd.Dni,
                            Next_Visit = asd.DataProperaVisita,
                            Localization = asd.Localitzacio,
                            asd.ComercialId
                        };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.Id);
                Console.WriteLine(productGroup.Name);
                Console.WriteLine(productGroup.Surname);
                Console.WriteLine(productGroup.Age);
                Console.WriteLine(productGroup.IDCard);
                Console.WriteLine(productGroup.Next_Visit);
                Console.WriteLine(productGroup.Localization);
                Console.WriteLine(productGroup.ComercialId);
                prod.Add(productGroup);
            }
            return prod;
        }
        public List<Object> gridCategoria()
        {
            List<Object> cat = new List<Object>();
            var query = from asd in remoteDataContext.Categoria
                        select new
                        {
                            asd.Id,
                            Name = asd.Nom,
                            Discount = asd.Descompte
                        };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.Id);
                Console.WriteLine(productGroup.Name);
                Console.WriteLine(productGroup.Discount);
                cat.Add(productGroup);
            }
            return cat;
        }
        public List<Object> gridComandes()
        {
            List<Object> com = new List<Object>();
            var query = from asd in remoteDataContext.Comanda
                        select new
                        {
                            asd.Id,
                            asd.ComercialId,
                            Delivered = asd.Lliurada,
                            Date = asd.Data,
                            asd.ClientId,
                            Name = asd.Client.Nom,
                            Surname = asd.Client.Cognom
                        };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.Id);
                Console.WriteLine(productGroup.Delivered);
                Console.WriteLine(productGroup.Date);
                Console.WriteLine(productGroup.ClientId);
                Console.WriteLine(productGroup.Name);
                Console.WriteLine(productGroup.Surname);
                Console.WriteLine(productGroup.ComercialId);
                com.Add(productGroup);
            }
            return com;
        }
        public List<Object> gridDetallComandes(int id, int idCom) {
            List<Object> com_prod = new List<Object>();

            var query = from asd in remoteDataContext.Comanda_Producte where asd.ComandaId == id && asd.ComercialId == idCom
                        select new
                        {
                            Quantity = asd.Quantitat,
                            Date = asd.Comanda.Data,
                            Committed = asd.Comanda.Lliurada,
                            Name_Category = asd.Producte.Categoria.Nom,
                            Enabled = asd.Producte.Habilitat,
                            Name_Product = asd.Producte.Nom,
                            Price_Product = asd.Producte.Preu,
                            Discount = asd.Producte.Descompte
                        };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.Committed);
                Console.WriteLine(productGroup.Date);
                Console.WriteLine(productGroup.Discount);
                Console.WriteLine(productGroup.Enabled);
                Console.WriteLine(productGroup.Name_Category);
                Console.WriteLine(productGroup.Name_Product);
                Console.WriteLine(productGroup.Price_Product);
                Console.WriteLine(productGroup.Quantity);
                com_prod.Add(productGroup);
            }
            return com_prod;
        }
        public bool validateFields(String a, int i) {
            bool comprovar = false;

            if (a.Count() < i) {
                comprovar = true;
            }

            return comprovar;
        }
        public int countClient(int id)
        {
            int cli = (from client in remoteDataContext.Client where client.ComercialId == id select client).Count();
            return cli;
        }
    }
}
