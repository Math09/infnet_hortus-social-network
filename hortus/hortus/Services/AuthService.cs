using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hortus.Services
{
    public class AuthService
    {
        public static bool Login( string login, string password )
        {
            using( DataContext dataContext = new DataContext() )
            {
                return dataContext.User.Any( user => user.UserEmail.Equals( login, StringComparison.OrdinalIgnoreCase ) && user.UserPassword == password );
            }
        }
    }
}