using Microsoft.EntityFrameworkCore;
using SkyShop.DAL.Database.Entities;

namespace SkyShop.DAL.Database;

public class SkyShopDbContext : DbContext
{
    private SkyShopDbContext() { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("SkyShop");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasKey(x => x.Id);
        modelBuilder.Entity<User>().HasOne(x => x.Profile).WithOne(x => x.User).HasForeignKey<Profile>(x => x.UserId);
        modelBuilder.Entity<Profile>().HasKey(x => x.Id);
        modelBuilder.Entity<Ticket>().HasKey(x => x.Id);
    }
    private static SkyShopDbContext? instance;
    public static SkyShopDbContext GetContext()
    {
        instance ??= new SkyShopDbContext();
        return instance;
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}
