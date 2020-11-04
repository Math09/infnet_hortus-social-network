namespace hortus
{
    using hortus.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=hortus_db")
        {

        }

        public DbSet<UserModel> User { get; set; }
        public DbSet<FriendsModel> Friends { get; set; }
        public DbSet<PostModel> Post { get; set; }
        public DbSet<CommentModel> Comment { get; set; }

    }
}