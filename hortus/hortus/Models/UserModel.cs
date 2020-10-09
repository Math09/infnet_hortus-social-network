using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace hortus.Models
{
    public class UserModel
    {
        private int id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string password { get; set; }
    }
}