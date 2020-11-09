using hortus.Models;
using hortus.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace hortus.Controllers
{
    [Authorize]
    [Route("user/")]
    public class UserController : ApiController
    {
        private UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _userService.Get();
        }

        [Route( "user/{id:int}" )]
        public UserModel GetUser( int id )
        {
            return _userService.GetById( id );
        }

        [Route( "user/delete/{id:int}" )]
        public void Delete( int id )
        {
            _userService.Delete( id );
        }

        [HttpPut]
        public void Put( UserModel model )
        {
            _userService.Put( model );
        }

        [HttpPost]
        public void Post( UserModel model )
        {
            if( model.UserEmail != null && model.UserName != null && model.UserPassword != null )
            {
                _userService.Post( model );
            }
        }
    }
}
