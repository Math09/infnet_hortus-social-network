using hortus.Models;
using hortus.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace hortus.Controllers
{
    [Route("post")]
    public class PostController : ApiController
    {
        private PostService _postService;

        public PostController()
        {
            _postService = new PostService();
        }

        [HttpGet]
        public IEnumerable<PostModel> Get()
        {
            return _postService.Get();
        }

        [HttpPost]
        public void Post( PostModel post )
        {
            _postService.Post(post);
        }
    }
}
