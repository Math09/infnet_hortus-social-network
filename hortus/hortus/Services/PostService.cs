using hortus.Models;
using System.Collections.Generic;
using System.Linq;

namespace hortus.Services
{
    public class PostService
    {
        private DataContext _dataContext;

        public PostService()
        {
            _dataContext = new DataContext();
        }

        public IEnumerable<PostModel> Get()
        {
            var posts = _dataContext.Post.Include( "User" ).ToList();
            return posts;
        }

        public void Post( PostModel post )
        {
            _dataContext.Post.Add( post );
            _dataContext.SaveChanges();
        }
    }
}