﻿using System;
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
                MessageBox.Show("S'ha inserit correctament.");

            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
        }
         }
        public int InsertUser(Usuari usuari)
        {
            try
            {
            remoteDataContext.AddToUsuari(usuari);
            remoteDataContext.SaveChanges();
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
        }
            return usuari.Id;
        }
        public void InsertCategoria(Categoria categoria)
        {
            try
            {
            remoteDataContext.AddToCategoria(categoria);
            MessageBox.Show("S'ha inserit correctament.");
            remoteDataContext.SaveChanges();
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            }
        }
        public void InsertProduct(Producte producte)
        {
            try 
            {
            remoteDataContext.AddToProducte(producte);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha inserit correctament.");
        }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut inserir: " + e);
            }
            
        }
        public void InsertToClients(Client client)
        {
            try
            {
            remoteDataContext.AddToClient(client);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha inserit correctament.");
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } 
        }
        public void InsertComanda_Producte(Comanda_Producte comanda_producte)
        {
            try
            {
                remoteDataContext.AddToComanda_Producte(comanda_producte);
                remoteDataContext.SaveChanges();
                MessageBox.Show("S'ha inserit correctament.");
                            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut inserir: " + e);
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
                MessageBox.Show("No s'ha actualitzar inserir: " + e);
            } 
        }
        public void UpdateUser(Usuari usuari)
        {
            try{
            remoteDataContext.UpdateObject(usuari);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha actualitzar correctament.");
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut actualitzar: " + e);
            } 
        }
        public void UpdateClient(Client client)
        {
            try
            {
                remoteDataContext.UpdateObject(client);
                remoteDataContext.SaveChanges();
                MessageBox.Show("S'ha actualitzar correctament.");
            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut actualitzar: " + e);
            }


        }
        public void UpdateCategoria(Categoria categoria)
        {
            try{
            remoteDataContext.UpdateObject(categoria);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha actualitzar correctament.");
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut actualitzar: " + e);
            } 
        }
        public void UpdateProducte(Producte producte)
        {
            try{
            remoteDataContext.UpdateObject(producte);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha actualitzar correctament.");
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut actualitzar: " + e);
            } 
        }
        public void UpdatePerfil(Usuari usuari)
        {
            try
            {
            remoteDataContext.UpdateObject(usuari);
            remoteDataContext.SaveChanges();
            MessageBox.Show("S'ha actualitzar correctament.");
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut actualitzar: " + e);
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
                IQueryable<Client> client = AllClient();
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
                            asd.Preu,
                            asd.Descompte,
                            asd.Habilitat,
                            Categoria = asd.Categoria
                        };
             foreach (var productGroup in query)
             {
                 Console.WriteLine(productGroup);
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
                             asd.Usuari.Nom,
                             asd.Usuari.Cognom,
                             asd.Usuari.Dni,
                             asd.Usuari.Contrasenya,
                             asd.AnyInici, 
                             ZonaT = asd.ZonaTreball,
                             asd.Habilitat
                         };

            foreach (var productGroup in query)
            {
                Console.WriteLine(productGroup.AnyInici);
                Console.WriteLine(productGroup.ZonaT);
                Console.WriteLine(productGroup.Habilitat);
                prod.Add(productGroup);
            }
            return prod;
        }
        public List<Object> gridDetallComandes(int id) {
            List<Object> com_prod = new List<Object>();

            var query = from asd in remoteDataContext.Comanda_Producte where asd.ComandaId == id
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
    }
}
