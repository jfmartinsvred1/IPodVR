using Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.EfCore
{
  public class PodContext:DbContext
  {
    public PodContext(DbContextOptions<PodContext> opts): base(opts)
    {
        
    }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Pod> Pods { get; set; }
  }
}
