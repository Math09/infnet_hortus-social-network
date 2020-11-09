namespace hortus
{
    using hortus.Models;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext()
            : base( "name=hortus_db" )
        {

        }

        public DbSet<UserModel> User { get; set; }
        public DbSet<FriendsModel> Friends { get; set; }
        public DbSet<PostModel> Post { get; set; }
        public DbSet<CommentModel> Comment { get; set; }

    }
}