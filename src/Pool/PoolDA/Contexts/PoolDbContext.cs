using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PoolBL;
using PoolBL.IContext;


namespace PoolDA.Contexts;
public class PoolDbContext : DbContext, IPoolDbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Ticket> Ticket { get; set; }
    public DbSet<Pool> Pool { get; set; }
    public DbSet<Reserved> Reserved { get; set; }
    public DbSet<Sans> Sans { get; set; }
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

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {
    //        // اضافه کردن تنظیمات اتصال به پایگاه داده
    //        optionsBuilder.UseSqlServer("Server =DESKTOP-GE4QLLU; Initial Catalog = PoolDb; User Id =sa; Password = 1qaz!QAZ;TrustServerCertificate=True");
    //    }
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Sans>()
            .HasMany(r => r.Reserved)
            .WithOne()
            .HasForeignKey(s=> s.SansId)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<Pool>()
            .HasMany(r => r.Reserveds)
            .WithOne()
            .HasForeignKey(s => s.PoolId)
            .OnDelete(DeleteBehavior.NoAction);
        modelBuilder.Entity<User>()
            .HasMany(r => r.Reserveds)
            .WithOne()
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
