using FarmShoppingForm.Entities.BaseEntities;

namespace FarmShoppingForm.Entities
{
    public class Goat : Animal
    {
        public Goat(string name, int age, string origin) : base(name, age)
        {
            Origin = origin;
            AnimalType = "Goat";
            AnimalClass = "Mammal";
            Price = 200;
            ProductionAmount = 1;
            ProductionTime = 15_000;
            TotalProducts = 0;
        }

        public override async Task LifeCycleAsync(Panel animalPanel)
        {
            var ageLabel = animalPanel.Controls
                .Find($"panel{Id}Right_Age:", true)
                .FirstOrDefault() as Label;

            var timeLabel = animalPanel.Controls
                    .Find($"panel{Id}Right_TimesLeft(min):", true)
                    .FirstOrDefault() as Label;

            if (timeLabel == null || ageLabel == null)
            {
                throw new ArgumentNullException();
            }

            int secondsCounter = 0;
            while (TimesLeftSeconds > 0)
            {
                await Task.Delay(1000);
                TimesLeftSeconds--;
                secondsCounter++;

                if (TimesLeftSeconds <= 0)
                {
                    TimesLeftSeconds = 0;
                    AnimalDeath();
                    break;
                }

                // yaş sayacı
                if (secondsCounter >= 60)
                {
                    Age++;
                    secondsCounter = 0;
                    ageLabel.Text = $"{Age} yıl";
                }

                timeLabel.Text = $"00:{TimesLeftSeconds / 60:D2}:{TimesLeftSeconds % 60:D2}";
            }
        }

        public override async Task ProduceAsync(Panel animalPanel, CancellationToken token)
        {
            ProgressBar? progress = animalPanel.Controls
                   .OfType<ProgressBar>()
                   .FirstOrDefault(p => p.Name == $"panel{Id}Progress");

            Label? totalProductsLabel = animalPanel.Controls
                                .Find($"panel{Id}Right_TotalProducts:", true)
                                .FirstOrDefault() as Label;

            while (TimesLeftSeconds > 0 && !token.IsCancellationRequested)
            {
                progress.Value = 0;
                int productionTimeMs = ProductionTime;
                int steps = 100;
                int stepDelay = productionTimeMs / steps;

                for (int i = 0; i < steps; i++)
                {
                    if (token.IsCancellationRequested) return;
                    progress.Value = i + 1;
                    await Task.Delay(stepDelay);
                }
                TotalProducts += ProductionAmount;
                Product.Amount += ProductionAmount;
                UpdateProduction();

                totalProductsLabel.Text = TotalProducts.ToString();
            }
        }
    }
}
