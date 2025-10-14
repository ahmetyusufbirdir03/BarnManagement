namespace FarmShoppingForm.Entities.BaseEntities;

public abstract class Animal
{
    private static int _idCounter = 1;
    public int Id { get; set; }
    public string Name { get; set; }
    public string AnimalType { get; set; }
    public string Origin { get; set; }
    public string AnimalClass { get; set; }
    public int Price { get; set; }
    public int ProductionTime { get; set; }
    public int ProductionAmount { get; set; }
    public int TotalProducts { get; set; } = 0;
    public int Age { get; set; }           
    public int MaxAge { get; set; } = 11;  
    public int TimesLeftSeconds { get; set; }

    public Product Product { get; set; }

    public DateTime StartTime { get; private set; }

    public event Action<Product>? OnProductionUpdate;

    public Animal(string name, int age)
    {
        Id = _idCounter++;
        Name = name;
        Age = age;
        StartTime = DateTime.Now;
        TimesLeftSeconds = (MaxAge - Age) * 60;
    }

    public event Action<int> OnAnimalDied;

    public void AnimalDeath()
    {
        OnAnimalDied?.Invoke(Id);
    }

    public void UpdateProduction()
    {
        OnProductionUpdate?.Invoke(Product);
    }

    public abstract Task LifeCycleAsync(Panel panel);

    public event Action<int> Production;
    public abstract Task ProduceAsync(Panel panel, CancellationToken token);
}