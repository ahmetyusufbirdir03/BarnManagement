using FarmShoppingForm.Entities.BaseEntities;

namespace FarmShoppingForm.Management;

public class PanelManager
{
    private static int animalCounter = 1;

    public static Panel CreateAnimalPanel(Animal animal)
    {
        string animalId = animalCounter.ToString();
        animalCounter++;

        Panel mainPanel = new Panel();
        mainPanel.Name = $"panel{animal.Id}Main";
        mainPanel.Size = new Size(400, 320);
        mainPanel.Margin = new Padding(50, 20, 0, 0);
        mainPanel.BorderStyle = BorderStyle.Fixed3D;
        mainPanel.BackColor = Color.FromArgb(192, 192, 255);

        Panel specPanel = new Panel();
        specPanel.Name = $"panel{animal.Id}Spec";
        specPanel.Size = new Size(360, 240);
        specPanel.Location = new Point(20, 20);
        specPanel.Margin = new Padding(10);
        specPanel.BackColor = Color.FromArgb(255, 192, 128);
        mainPanel.Controls.Add(specPanel);

        Panel headerPanel = new Panel();
        headerPanel.Name = $"panel{animal.Id}Header";
        headerPanel.Size = new Size(330, 30);
        headerPanel.Location = new Point(15, 10);
        headerPanel.BackColor = Color.Transparent;

        Label headerLabel = new Label();
        headerLabel.Dock = DockStyle.Fill;
        headerLabel.TextAlign = ContentAlignment.MiddleCenter;
        headerLabel.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
        headerLabel.Text = $"Animal {animal.Id}";
        headerPanel.Controls.Add(headerLabel);

        specPanel.Controls.Add(headerPanel);

        
        string[] leftTexts = { "Name:", "Age:", "Origin:", "Production(min):", "TotalProducts:", "Times Left(min):" };
        int startY = 50;
        for (int i = 0; i < leftTexts.Length; i++)
        {
            Label lbl = new Label();
            lbl.Name = $"panel{animal.Id}Left_{leftTexts[i].Replace(" ", "")}";
            lbl.Text = leftTexts[i];
            lbl.Size = new Size(170, 30);
            lbl.Location = new Point(15, startY + i * 30);
            lbl.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
            lbl.TextAlign = ContentAlignment.MiddleRight;
            specPanel.Controls.Add(lbl);
        }

        for (int i = 0; i < leftTexts.Length; i++)
        {
            Label lbl = new Label();
            lbl.Name = $"panel{animal.Id}Right_{leftTexts[i].Replace(" ", "")}";
            lbl.Size = new Size(150, 30);
            lbl.Location = new Point(180, startY + i * 30);
            lbl.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            switch (leftTexts[i])
            {
                case "Name:":
                    lbl.Text = animal.Name;
                    break;
                case "Age:":
                    lbl.Text = $"{animal.Age} yıl";
                    break;
                case "Origin:":
                    lbl.Text = animal.Origin; 
                    break;
                case "Production(min):":
                    lbl.Text = (60000/animal.ProductionTime).ToString();
                    break;
                case "TotalProducts:":
                    lbl.Text = animal.TotalProducts.ToString();
                    break;
                case "Times Left(min):":
                    lbl.Text = $"00:{animal.TimesLeftSeconds/60}:{animal.TimesLeftSeconds % 60}";
                    break;
                default:
                    lbl.Text = "-";
                    break;
            }

            specPanel.Controls.Add(lbl);
        }


        ProgressBar progress = new ProgressBar();
        progress.Name = $"panel{animal.Id}Progress";
        progress.Size = new Size(360, 20);
        progress.Location = new Point(20, 280);
        progress.Value = 0;
        mainPanel.Controls.Add(progress);


        return mainPanel;
    }

}
