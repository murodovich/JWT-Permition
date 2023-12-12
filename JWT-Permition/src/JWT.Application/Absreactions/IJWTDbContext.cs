using JWT.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWT.Application.Absreactions
{
    public interface IJWTDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
