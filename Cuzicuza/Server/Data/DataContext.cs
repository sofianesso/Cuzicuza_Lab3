using Microsoft.EntityFrameworkCore;
using Cuzicuza.Server.Models;


namespace Cuzicuza.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
