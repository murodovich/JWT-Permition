﻿using JWT.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWT.Infrastructure.Persistance;
public class JWTDbContext : DbContext
{
    public JWTDbContext(DbContextOptions<JWTDbContext> options) 
        : base(options)
    {        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasMany(x => x.Roles)
            .WithMany(x => x.Users)
            .UsingEntity(nameof(UserRole));

        modelBuilder.Entity<Role>()
            .HasMany(x => x.Permissions)
            .WithMany(x => x.Roles)
            .UsingEntity(nameof(RolePermission));
    }
}
