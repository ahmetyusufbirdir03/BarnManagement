using FarmShoppingForm.Entities.BaseEntities;
using FarmShoppingForm.Management;

namespace FarmShoppingForm
{
    public partial class ShopForm : Form
    {
        public event Action<Animal>? OnAnimalPurchased;
        public event Action<int, string>? OnPurchaseUpdate;
        public string? CurrentSelectedAnimal { get; private set; }

        public ShopForm()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var buyForm = new BuyForm();
            buyForm.OnAnimalPurchased += HandleAnimalPurchase; 
            buyForm.ShowDialog();
        }

        private void HandleAnimalPurchase(Animal animal)
        {          
            OnPurchaseUpdate?.Invoke(animal.Price,"-");
            OnAnimalPurchased?.Invoke(animal);
        }
    }
}
