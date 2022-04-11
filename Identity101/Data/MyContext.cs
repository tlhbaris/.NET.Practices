using Identity101.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity101.Data
{
    public class MyContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.Property(X => X.Name).HasMaxLength(50).IsRequired(false);
                entity.Property(X => X.Surname).HasMaxLength(50).IsRequired(false);
                entity.Property(X => X.RegisterDate).HasColumnType("datetime");

            });

            builder.Entity<ApplicationRole>(entity =>
            {
                entity.Property(x => x.Description).HasMaxLength(50).IsRequired(false);
            });

        }


    }
}
