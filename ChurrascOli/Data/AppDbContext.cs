using ChurrascOli.Models;
using Microsoft.EntityFrameworkCore;

namespace ChurrascOli.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Tipo> Tipos { get; set; }
    public DbSet<Churrasco> Churrascos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
	optionsBuilder.UseMySql("server=localhost;database=ChurrascOli;uid=root;pwd=''",
    new MySqlServerVersion(new Version (8, 0, 21)));
	}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Tipo>()
        .HasMany(t => t.Churrascos)
        .WithOne(c => c.Tipo)
        .HasForeignKey(c => c.TipoId);
        
        base.OnModelCreating(modelBuilder);
    }

}
