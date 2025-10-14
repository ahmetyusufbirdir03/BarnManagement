using FarmShoppingForm.Entities.BaseEntities;

namespace FarmShoppingForm
{
    public partial class StorageForm : Form
    {
        public int sellAmount { get; set; }
        public static List<Product> products = new List<Product>();
        public static Dictionary<string, Label> productLabels = new();
        public Form1 _mainForm;

        public StorageForm(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            products.AddRange(new List<Product>
            {
                new Product("CowMilk", 20),
                new Product("Wool", 10),
                new Product("GoatMilk", 25),
                new Product("HoneyJar", 10),
                new Product("Egg", 2)
            });

            productLabels.Add("CowMilk", lblCowMilk);
            productLabels.Add("HoneyJar", lblHoneyJar);
            productLabels.Add("GoatMilk", lblGoatMilk);
            productLabels.Add("Egg", lblEgg);
            productLabels.Add("Wool", lblWool);
        }

        public static void UpdateProductCounts(Product product)
        {
            if (product != null && productLabels.TryGetValue(product.Name, out var label))
            {
                label.Text = "Count: " + product.Amount.ToString();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellForm sellForm = new SellForm(_mainForm);
            sellForm.OnSellAccept += UpdateProductCounts;
            sellForm.ShowDialog();

        }
    }
}
