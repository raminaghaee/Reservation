using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PoolBL;
using PoolBL.IContext;
using PoolDA.Config;


namespace PoolDA.Contexts;
public class PoolDbContext : DbContext, IPoolDbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Ticket> Ticket { get; set; }
    public DbSet<Pool> Pool { get; set; }
    public DbSet<Reserved> Reserved { get; set; }
    public DbSet<Pool> Sans { get; set; }
    public DbSet<Pay> Pay { get; set; }
    public DbSet<Constant> Constant { get; set; }

    public PoolDbContext(DbContextOptions<PoolDbContext> dbContextOptions):base(dbContextOptions)
    {

    }
    public PoolDbContext()
    {
        
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<decimal>().HavePrecision(11,2);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfig).Assembly);  
    }
 
}
