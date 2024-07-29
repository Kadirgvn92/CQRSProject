namespace CQRSProject.CQRS.Commands.Product;

public class UpdateProductCommand
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
}
