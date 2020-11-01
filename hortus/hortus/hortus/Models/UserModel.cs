using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace hortus.Models
{
    [Table("dbo.users")]
    public class UserModel
    {

        [Key]
        [Column("id_user")]
        public int UserId { get; set; }

        [Column("photo")]
        public string Photo { get; set; }

        [Column("name_user")]
        public string UserName { get; set; }

        [Column("email")]
        public string UserEmail { get; set; }

        [Column("password_user")]
        public string UserPassword { get; set; }

    }
}