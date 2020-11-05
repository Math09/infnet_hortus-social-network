using hortus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            return _dataContext.Post;
        }

        public void Post( PostModel post )
        {
            _dataContext.Post.Add(post);
            _dataContext.SaveChanges();
        }
    }
}