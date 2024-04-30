using Microsoft.EntityFrameworkCore;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext:DbContext
    {
        public ShopOnlineDbContext(DbContextOptions <ShopOnlineDbContext> options) :base(options) { }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
