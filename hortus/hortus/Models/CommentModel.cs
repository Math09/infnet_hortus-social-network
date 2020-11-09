using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hortus.Models
{
    [Table("comment")]
    public class CommentModel
    {

        [Key]
        [Column("id_comment")]
        public int IdComment { get; set; }

        [Column("id_post")]
        public PostModel Post { get; set; }

        [Column("comment")]
        public string Comment { get; set; }

    }
}