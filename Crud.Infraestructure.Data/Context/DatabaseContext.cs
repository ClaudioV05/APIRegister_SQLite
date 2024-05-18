using Crud.Infraestructure.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infraestructure.Data.Context;

/// <summary>
/// Database Context.
/// </summary>
public sealed class DatabaseContext : DbContext
{

    /// <summary>
    /// Database Context.
    /// </summary>
    /// <param name="options"></param>
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    /// <summary>
    /// Users.
    /// </summary>
    public DbSet<Users>? Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Users>().HasData(new List<Users>()
        {
            new () { Id = 1, Name = "Mary", },
            new () { Id = 2, Name = "Jhon", }
        });
    }
}