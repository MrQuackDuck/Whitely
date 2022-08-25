using Microsoft.EntityFrameworkCore;
using Whitely.DAL.Repositories;
using Whitely.Domain.Models;

namespace Whitely.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<RealProperty> RealProperty { get; set; }
        public DbSet<User> User { get; set; }
    }
}