using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tester2.Models;

namespace Tester2.Data
{
    public class UserDbContext: IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        DbSet<Profile>? Profiles { get; set; }
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
