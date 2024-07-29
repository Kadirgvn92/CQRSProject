namespace CQRSProject.CQRS.Commands.Product;

public class CreateProductCommand
{
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
}
