using System;
using System.Linq;

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