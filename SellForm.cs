using FarmShoppingForm.Entities.BaseEntities;

namespace FarmShoppingForm
{
    public partial class SellForm : Form
    {

        public event Action<Product>? OnSellAccept;
        public Form1 _mainForm;
        public SellForm(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            comboBoxProduct.Items.AddRange(new[] { "CowMilk", "HoneyJar", "GoatMilk",
                "Egg", "Wool"});
        }

        private void btnSellAccept_Click(object sender, EventArgs e)
        {
            string? type = comboBoxProduct.SelectedItem?.ToString();
            int amount = (int)numSell.Value;

            if(string.IsNullOrEmpty(type) || amount <= 0 )
            {
                MessageBox.Show("Please fill all areas"); return;
            }

            var product = StorageForm.products.FirstOrDefault(p => p.Name == type);
            if (product == null )
            {
                MessageBox.Show("Product not found!"); return;
            }
            else if (product.Amount < amount) 
            {
                MessageBox.Show("Not Enough Products"); return;
            }
         
            product.Amount -= amount;
            _mainForm.UpdateMoney(product.Price*amount,"+");
            OnSellAccept?.Invoke(product);
            Close(); 
        }
    }
}
