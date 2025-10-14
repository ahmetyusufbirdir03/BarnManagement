using FarmShoppingForm.Entities.BaseEntities;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;

namespace FarmShoppingForm;

public partial class Form1 : Form
{
    private FarmForm _farmForm;
    private ShopForm _shopForm;
    private StorageForm _storageForm;
    public AppUser DefaultUser;
    
    public Form1()
    {
        InitializeComponent();

        DefaultUser = new AppUser();
        _storageForm = new StorageForm(this);
        _farmForm = new FarmForm();
        _shopForm = new ShopForm();

        _shopForm.OnPurchaseUpdate += UpdateMoney;
        _shopForm.OnAnimalPurchased += _farmForm.AddAnimalToFarm;

    }

    private void loadForm(object Form)
    {
        if (this.panelMain.Controls.Count > 0)
            this.panelMain.Controls.RemoveAt(0);
        Form? f = Form as Form;
        f.TopLevel = false;
        f.Dock = DockStyle.Fill;
        this.panelMain.Controls.Add(f);
        this.panelMain.Tag = f;
        f.Show();

    }

    private void btnRouterFarm_Click(object sender, EventArgs e)
    {
        if (_farmForm == null)
            _farmForm = new FarmForm();

        loadForm(_farmForm);
    }

    private void btnRouterShop_Click(object sender, EventArgs e)
    {
        if (_shopForm == null)
            _shopForm = new ShopForm();

        loadForm(_shopForm);
    }

    private void btnRouterStorage_Click(object sender, EventArgs e)
    {
        if (_storageForm == null)
            _storageForm = new StorageForm(this);
        loadForm(_storageForm);
    }

    public void UpdateMoney(int amount, string method)
    {
        if (DefaultUser.Credit < amount)
        {
            MessageBox.Show("Not enough credits!");
            return;
        }
        if(method == "+")
        {
            DefaultUser.increaseMoney(amount);
        }
        else if(method == "-")
        {
            DefaultUser.decreaseMoney(amount);
        }

        labelMoneyValue.Text = DefaultUser.Credit.ToString() + "$";

        MessageBox.Show(
                $"Your process has been completed successfully.");
        return;
    }

    
}
