
using AddrCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace AddrCRUD.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Addr> Addrs { get; set; }
    }
}