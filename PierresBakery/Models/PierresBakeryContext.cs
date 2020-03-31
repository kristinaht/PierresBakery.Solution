
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresBakery.Models
{
  public class PierresBakeryContext : DbContext
  // : DbContext to be replaced with IdentityDbContext<ApplicationUser> when Authentication is added !!!
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public PierresBakeryContext(DbContextOptions options) : base(options) { }
  }
}