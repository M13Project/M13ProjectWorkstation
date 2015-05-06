using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewsProjecteFinal.ServiceReference;

namespace ViewsProjecteFinal.CustomClasses
{
    class LoginController
    {
        private PersistanceManager pm;

        public LoginController() {
            pm = new PersistanceManager();
        }

        //This method search in the database if user with introduced username and password exsists
        public int checkUserSignIn(string username, string password) {
            int userId = 0;            
            Usuari user = pm.getUserWithUsernameAndPassword(username, password);
            if (user != null)
            {
                if (user.Comercial != null)
                {
                    userId = user.Id;
                }
                else {
                    //If the user is administrator, it returns its id with negative value
                    userId = -user.Id;
                }                
            }            
            return userId;
        }
    }
}
