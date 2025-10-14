namespace FarmShoppingForm.Entities.BaseEntities;

public class Product
{
    public string? Name { get; set; }
    public int Price { get; set; }
    public int Amount { get; set; }

    public int TotalProduction { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
        Amount = 0;
        TotalProduction = 0;
    }
}
