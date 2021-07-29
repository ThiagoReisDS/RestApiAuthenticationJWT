using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Model;

namespace RestApiAuthenticationJwt.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
        
        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
