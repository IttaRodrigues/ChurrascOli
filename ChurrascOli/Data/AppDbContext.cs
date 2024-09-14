using ChurrascOli.Models;
using Microsoft.EntityFrameworkCore;

namespace ChurrascOli.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Tipo> Tipos { get; set; }
}
