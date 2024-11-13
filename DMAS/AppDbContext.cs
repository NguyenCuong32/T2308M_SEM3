using System;
using DMAS.Models;
using Microsoft.EntityFrameworkCore;

namespace DMAS;

public class AppDbContext : DbContext
{
    public AppDbContext():base()
    {
        
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Class> Classes { get; set; }
}
