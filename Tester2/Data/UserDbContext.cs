using Microsoft.EntityFrameworkCore;
using Tester2.Models;

namespace Tester2.Data
{
    public class UserDbContext: DbContext
    {
        DbSet<Profile> Profiles { get; set; }
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {

        }
    }
}
