namespace FarmShoppingForm.Entities.BaseEntities;

public class AppUser
{
    public string UserName { get; set; }
    public int Credit { get; set; }
    public AppUser()
    {
        UserName = "Farmer";
        Credit = 500;
    }

    public void increaseMoney(int amount)
    {
        Credit += amount;
    }
    public void decreaseMoney(int amount)
    {
        Credit -= amount;
    }
}
