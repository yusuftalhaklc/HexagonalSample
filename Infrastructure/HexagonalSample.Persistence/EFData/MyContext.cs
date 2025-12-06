using HexagonalSample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HexagonalSample.Persistence.EFData
{
    //Dikkat ediniz burada Core tarafı hala EF'ten habersiz...EF, Core'dan haberdardır...
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
