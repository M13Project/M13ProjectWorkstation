using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewsProjecteFinal.ServiceReference;

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
            remoteDataContext.AddToComercial(comercial);
        }
        public void InsertUser(Usuari usuari)
        {
            remoteDataContext.AddToUsuari(usuari);
        }
        public void InsertCategoria(Categoria categoria)
        {
            remoteDataContext.AddToCategoria(categoria);
        }
        public void InsertProduct(Producte producte)
        {
            remoteDataContext.AddToProducte(producte);
        }
        public void InsertToClients(Client client)
        {
            remoteDataContext.AddToClient(client);
        }
        public void AllAgents()
        {
          
        }
        public void AllCategoria()
        {

        }
        public void AllClient()
        {

        }
        public void AllComandes()
        {

        }
        public void UpdateAgent(Comercial comercial)
        {
            remoteDataContext.UpdateObject(comercial);
        }
        public void UpdateUser(Usuari usuari)
        {
            remoteDataContext.UpdateObject(usuari);
        }
        public void UpdateCategoria(Categoria categoria)
        {
            remoteDataContext.UpdateObject(categoria);

        }
        public void UpdateProducte(Producte producte)
        {
            remoteDataContext.UpdateObject(producte);
        }
        public void UpdatePerfil(Usuari usuari)
        {
            remoteDataContext.UpdateObject(usuari);
        }

    }
}
