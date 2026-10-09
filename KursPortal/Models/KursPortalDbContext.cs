using Microsoft.EntityFrameworkCore;

namespace KursPortal.Models
{
    public class KursPortalDbContext : DbContext
    {
        public KursPortalDbContext(DbContextOptions<KursPortalDbContext> opts) : base(opts) { }
        public DbSet<Kurs> Kurse{ get; set; }

        public DbSet<Lernziel> Lernziele { get; set; }
    }
}
 