using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewsProjecteFinal.ServiceReference;
using System.Windows.Forms;

namespace ViewsProjecteFinal.CustomClasses
{
    class PersistanceManager
    {
        private m13_projectEntities remoteDataContext;

        public PersistanceManager() {
            remoteDataContext = new m13_projectEntities(new Uri("http://localhost:52220/M13ProjectWcfDataService.svc/"));
        }

        public Usuari getUserWithUsernameAndPassword(string username, string password) {            
            //IQueryable query = from user in remoteDataContext.Usuari select new { Username = user.Usuari1, Password = user.Contrasenya, isComercial = user.Comercial };
            Usuari extractedUser = (from user in remoteDataContext.Usuari where user.Usuari1.Equals(username) && user.Contrasenya.Equals(password) select user).SingleOrDefault();
            if(extractedUser != null) {
                remoteDataContext.LoadProperty(extractedUser, "Comercial");
            }            
            return extractedUser;
        }
        public void InsertAgent(Comercial comercial)
        {
            try
            {
                remoteDataContext.AddToComercial(comercial);
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } finally{
                MessageBox.Show("S'ha inserit correctament.");
            }
         }
        public void InsertUser(Usuari usuari)
        {
            try
            {
            remoteDataContext.AddToUsuari(usuari);
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } finally{
                MessageBox.Show("S'ha inserit correctament.");
            }
        }
        public void InsertCategoria(Categoria categoria)
        {
            try
            {
            remoteDataContext.AddToCategoria(categoria);
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } finally{
                MessageBox.Show("S'ha inserit correctament.");
            }
        }
        public void InsertProduct(Producte producte)
        {
            try 
            {
            remoteDataContext.AddToProducte(producte);
            }
            catch (Exception e)
            {
                MessageBox.Show("No s'ha pogut inserir: " + e);
            }
            finally
            {
                MessageBox.Show("S'ha inserit correctament.");
            }
        }
        public void InsertToClients(Client client)
        {
            try
            {
                remoteDataContext.AddToClient(client);
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } finally{
                MessageBox.Show("S'ha inserit correctament.");
            }
        }
        public void AllAgents()
        {
          
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
        public IQueryable<Comanda> ComandesdelClient(Client client)
        {
            var com = from comandes in remoteDataContext.Comanda where comandes.Client.Id == client.Id select comandes;
            return com;
        }
        
        public void UpdateAgent(Comercial comercial)
        {
            try
            {
            remoteDataContext.UpdateObject(comercial);
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } finally{
                MessageBox.Show("S'ha inserit correctament.");
            }
        }
        public void UpdateUser(Usuari usuari)
        {
            try{
            remoteDataContext.UpdateObject(usuari);
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } finally{
                MessageBox.Show("S'ha inserit correctament.");
            }
        }
        public void UpdateCategoria(Categoria categoria)
        {
            try{
            remoteDataContext.UpdateObject(categoria);
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } finally{
                MessageBox.Show("S'ha inserit correctament.");
            }
        }
        public void UpdateProducte(Producte producte)
        {
            try{
            remoteDataContext.UpdateObject(producte);
            } catch (Exception e){
                MessageBox.Show("No s'ha pogut inserir: " + e);
            } finally{
                MessageBox.Show("S'ha inserit correctament.");
            }
        }
        public void UpdatePerfil(Usuari usuari)
        {
            remoteDataContext.UpdateObject(usuari);
        }
    }
}
