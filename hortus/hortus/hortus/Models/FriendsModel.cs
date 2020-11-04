using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hortus.Models
{
    [Table("dbo.friends")]
    public class FriendsModel
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("id_user")]
        public UserModel User { get; set; }

        [Column("id_friend")]
        public UserModel Friends { get; set; }

    }
}