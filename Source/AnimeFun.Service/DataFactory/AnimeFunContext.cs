using AnimeFun.Core.Models.AnimeFun;
using Microsoft.EntityFrameworkCore;

namespace AnimeFun.Service.DataFactory
{
    public class AnimeFunContext : DbContext
    {
        public AnimeFunContext()
        {
            ChangeTracker.StateChanged += (sender, args) =>
            {
                if (args.NewState == EntityState.Modified)
                {
                    args.Entry.Property(nameof(BaseModel.UpdateTime)).CurrentValue = DateTime.Now;
                }
            };
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Update-Database -Migration:0
            // Remove-Migration
            // Add-Migration InitialCreate -OutputDir .\DataFactory\Migrations
            // Update-Database InitialCreate
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=AnimeFun;Persist Security Info=True;User ID=sa;Password=wangxi55;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
