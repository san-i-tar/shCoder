using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shCoder.Data.Products;
using shCoder.Data.Users;

namespace shCoder.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product[]
                {
                    new Product{ Id=1, Name="Bla bla", Price="100$"},
                    new Product{ Id=2, Name="KJhgfdk", Price="5500$"},
                    new Product{ Id=3, Name="Ihjudfiuy", Price="1050$"},
                    new Product{ Id=4, Name="Ihhhh jhdjjhhh", Price="1050$"},
                });
            //modelBuilder.Ignore<IdentityUser<string>>();
        }
    }
}
