using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace hortus.Models
{
    [Table("dbo.post")]
    public class PostModel
    {

        [Key]
        [Column("id_post")]
        public int IdPost { get; set; }

        [Column("id_user")]
        public UserModel User { get; set; }

        [Column("photo")]
        public string Photo { get; set; }

        [Column("description_post")]
        public string Description { get; set; }

        [Column("like_post")]
        public int Like { get; set; }

    }
}