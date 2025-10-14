using FarmShoppingForm.Entities.BaseEntities;
using FarmShoppingForm.Management;

namespace FarmShoppingForm
{
    public partial class FarmForm : Form
    {
        public List<Animal> animals = new List<Animal>();
        public Dictionary<int, Panel> animalPanels = new Dictionary<int, Panel>();

        public FarmForm()
        {
            InitializeComponent();
        }


        public void AddAnimalPanel(Panel animalPanel, Animal animal)
        {
            animals.Add(animal);
            animalPanels[animal.Id] = animalPanel;
            flowPanelFarm.Controls.Add(animalPanel);
        }

        public void AnimalDiedHandler(int animalId)
        {

            if (InvokeRequired)
            {
                Invoke(new Action(() => AnimalDiedHandler(animalId)));
                return;
            }

            var panelToRemove = flowPanelFarm.Controls
                .OfType<Panel>()
                .FirstOrDefault(p => p.Name == $"panel{animalId}Main");

            if (panelToRemove != null)
            {
                flowPanelFarm.Controls.Remove(panelToRemove);
                panelToRemove.Dispose();
                MessageBox.Show($"Animal {animalId} has died 💀");
            }
        }

        public async Task RunFarmAsync()
        {
            while (true)
            {

                foreach (var animal in animals.ToList())
                {
                    // 1. Yaşam süresini azalt
                    if (animal.TimesLeftSeconds > 0)
                    {
                        animal.TimesLeftSeconds--;
                    }
                    else
                    {
                        animal.AnimalDeath();
                        animals.Remove(animal);

                        if (animalPanels.TryGetValue(animal.Id, out var panel))
                        {
                            flowPanelFarm.Controls.Remove(panel);
                            panel.Dispose();
                            animalPanels.Remove(animal.Id);
                        }

                        continue;
                    }

                    // 2. UI güncelleme
                    if (animalPanels.TryGetValue(animal.Id, out var mainPanel))
                    {
                        //Time Label
                        var timeLabel = mainPanel.Controls
                            .Find($"panel{animal.Id}Right_TimesLeft(min):", true)
                            .FirstOrDefault() as Label;
                        if (timeLabel != null)
                        {
                            int minutes = animal.TimesLeftSeconds / 60;
                            int seconds = animal.TimesLeftSeconds % 60;
                            timeLabel.Text = $"00:{minutes:D2}:{seconds:D2}";
                        }

                        // TotalProducts label
                        var totalProductsLabel = mainPanel.Controls
                            .Find($"panel{animal.Id}Right_TotalProducts:", true)
                            .FirstOrDefault() as Label;
                        if (totalProductsLabel != null)
                            totalProductsLabel.Text = animal.TotalProducts.ToString();

                        // ProgressBar
                        var progress = mainPanel.Controls
                            .OfType<ProgressBar>()
                            .FirstOrDefault(p => p.Name == $"panel{animal.Id}Progress");

                        
                    }
                }

                await Task.Delay(1000);
            }
        }

        public void AddAnimalToFarm(Animal animal)
        {
            animal.OnAnimalDied += AnimalDiedHandler;

            switch (animal.AnimalType)
            {
                case "Cow":
                    animal.Product = StorageForm.products.First(p => p.Name == "CowMilk");
                    break;
                case "Goat":
                    animal.Product = StorageForm.products.First(p => p.Name == "GoatMilk");
                    break;
                case "Chicken":
                    animal.Product = StorageForm.products.First(p => p.Name == "Egg");
                    break;
                case "Bee":
                    animal.Product = StorageForm.products.First(p => p.Name == "HoneyJar");
                    break;
                case "Lamb":
                    animal.Product = StorageForm.products.First(p => p.Name == "Wool");
                    break;
                default:
                    throw new Exception("Unknown animal type");
            }


            Panel panel = PanelManager.CreateAnimalPanel(animal);
            AddAnimalPanel(panel, animal);
            animal.LifeCycleAsync(panel);

            animal.ProduceAsync(panel, new CancellationToken());
        }

        private async void FarmForm_Load(object sender, EventArgs e)
        {
        }
    }
}
