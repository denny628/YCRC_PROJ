using Microsoft.EntityFrameworkCore;

public class NorthwindContext : DbContext
{
    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {

    }

    public DbSet<Product> Products { get; set; } // ���]�ڭ̾ާ@Product��
}

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}
