using FarmShoppingForm.Entities;
using FarmShoppingForm.Entities.BaseEntities;

namespace FarmShoppingForm
{
    public partial class BuyForm : Form
    {
        public event Action<Animal>? OnAnimalPurchased;

        public BuyForm()
        {
            InitializeComponent();
            comboBoxAnimalType.Items.AddRange(new[] { "Cow", "Goat", "Bee", "Lamb", "Chicken" });
            comboBoxOriginValue.Items.AddRange(new[] { "Africa", "Asia", "North America", 
                "South America", "Australia", "Europe"});
        }

        private void btnBuyForm_Click(object sender, EventArgs e)
        {
            string name = textBoxNameValue.Text.Trim();
            string? origin = comboBoxOriginValue.SelectedItem?.ToString();
            int age = (int)numericBoxAgeValue.Value;
            string? type = comboBoxAnimalType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(type) || age <= 0)
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun!");
                return;
            }

            Animal? newAnimal = CreateAnimal(type, name, age, origin);

            OnAnimalPurchased?.Invoke(newAnimal);

            Close();

        }

        private Animal? CreateAnimal(string type, string name, int age, string origin)
        {
            Animal? animal = type switch
            {
                "Cow" => new Cow(name, age, origin),
                "Goat" => new Goat(name, age, origin),
                "Bee" => new Bee(name, age, origin),
                "Lamb" => new Lamb(name, age, origin),
                "Chicken" => new Chicken(name, age, origin),
                _ => null
            };

            if (animal != null)
            {
                animal.OnProductionUpdate += StorageForm.UpdateProductCounts;
            }

            return animal;
        }

        private void textBoxNameValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Harf mi? veya Boşluk mu? ya da Backspace mi?
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // izin ver
            }
            else
            {
                e.Handled = true; // engelle
            }
        }

        private void textBoxOriginValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Harf mi? veya Boşluk mu? ya da Backspace mi?
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // izin ver
            }
            else
            {
                e.Handled = true; // engelle
            }
        }
    }
}
