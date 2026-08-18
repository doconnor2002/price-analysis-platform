namespace PriceAnalysis.Domain.Models;

public class PricePoint
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public decimal Price { get; set; }
    public DateTime TimestampUtc { get; set; }
}
