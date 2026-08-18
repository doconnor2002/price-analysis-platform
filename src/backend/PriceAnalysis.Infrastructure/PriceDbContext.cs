using Microsoft.EntityFrameworkCore;
using PriceAnalysis.Domain.Models;

namespace PriceAnalysis.Infrastructure;

public class PriceDbContext : DbContext
{
    public PriceDbContext(DbContextOptions<PriceDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<PricePoint> PricePoints { get; set; } = null!;
}
