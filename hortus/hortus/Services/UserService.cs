using hortus.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace hortus.Services
{
    public class UserService
    {
        private DataContext _dataContext;

        public UserService()
        {
            _dataContext = new DataContext();
        }

        public IEnumerable<UserModel> Get()
        {
            return _dataContext.User;
        }

        public UserModel GetById( int id )
        {
            return _dataContext.User.Find(id);
        }

        public void Delete( int id )
        {
            var user = _dataContext.User.Find(id);

            _dataContext.User.Remove(user);
            _dataContext.SaveChanges();
        }

        public void Put( UserModel user ) 
        {
            _dataContext.Entry(user).State = EntityState.Modified;
            _dataContext.SaveChanges();
        }

        public void Post( UserModel user )
        {
            _dataContext.User.Add(user);
            _dataContext.SaveChanges();
        }
    }
}