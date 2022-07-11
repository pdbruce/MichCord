using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace MichCord.Data
{
    public class MichcordContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseNpgsql(
                "some;connection;string;arguments;"
                );
        }

    }
}
