namespace FarmShoppingForm
{
    partial class ShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            labelHeaderShop = new Label();
            shopFlowPanel = new FlowLayoutPanel();
            panelCow = new Panel();
            labelCowProduct = new Label();
            labelPriceCow = new Label();
            pictureBoxCow = new PictureBox();
            labelCowDesc = new Label();
            panelBee = new Panel();
            labelBeeProduct = new Label();
            labelPriceBee = new Label();
            pictureBoxBee = new PictureBox();
            labelBeeDesc = new Label();
            panelChicken = new Panel();
            labelChickenProduct = new Label();
            labelPriceChicken = new Label();
            pictureBoxChicken = new PictureBox();
            labelChickenDesc = new Label();
            panelGoat = new Panel();
            labelGoatProduct = new Label();
            labelPriceGoat = new Label();
            pictureBoxGoat = new PictureBox();
            labelGoatDesc = new Label();
            panelLamb = new Panel();
            labelLambProduct = new Label();
            labelPriceLamb = new Label();
            pictureBoxLamb = new PictureBox();
            labelLambDesc = new Label();
            pnlShopHeader = new Panel();
            btnBuy = new Button();
            shopFlowPanel.SuspendLayout();
            panelCow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCow).BeginInit();
            panelBee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBee).BeginInit();
            panelChicken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChicken).BeginInit();
            panelGoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoat).BeginInit();
            panelLamb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLamb).BeginInit();
            pnlShopHeader.SuspendLayout();
            SuspendLayout();
            // 
            // labelHeaderShop
            // 
            labelHeaderShop.Dock = DockStyle.Left;
            labelHeaderShop.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelHeaderShop.Location = new Point(10, 10);
            labelHeaderShop.Name = "labelHeaderShop";
            labelHeaderShop.Size = new Size(1043, 100);
            labelHeaderShop.TabIndex = 0;
            labelHeaderShop.Text = "SHOP";
            labelHeaderShop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // shopFlowPanel
            // 
            shopFlowPanel.AutoScroll = true;
            shopFlowPanel.Controls.Add(panelCow);
            shopFlowPanel.Controls.Add(panelBee);
            shopFlowPanel.Controls.Add(panelChicken);
            shopFlowPanel.Controls.Add(panelGoat);
            shopFlowPanel.Controls.Add(panelLamb);
            shopFlowPanel.Location = new Point(12, 157);
            shopFlowPanel.Name = "shopFlowPanel";
            shopFlowPanel.Size = new Size(1041, 612);
            shopFlowPanel.TabIndex = 4;
            // 
            // panelCow
            // 
            panelCow.Controls.Add(labelCowProduct);
            panelCow.Controls.Add(labelPriceCow);
            panelCow.Controls.Add(pictureBoxCow);
            panelCow.Controls.Add(labelCowDesc);
            panelCow.Location = new Point(3, 3);
            panelCow.Name = "panelCow";
            panelCow.Size = new Size(1006, 270);
            panelCow.TabIndex = 4;
            // 
            // labelCowProduct
            // 
            labelCowProduct.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelCowProduct.ForeColor = SystemColors.ControlText;
            labelCowProduct.Location = new Point(326, 197);
            labelCowProduct.Name = "labelCowProduct";
            labelCowProduct.Size = new Size(669, 62);
            labelCowProduct.TabIndex = 4;
            labelCowProduct.Text = "Production per Hour: 3 glass of milk";
            labelCowProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPriceCow
            // 
            labelPriceCow.BackColor = Color.Transparent;
            labelPriceCow.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelPriceCow.Location = new Point(816, 8);
            labelPriceCow.Name = "labelPriceCow";
            labelPriceCow.Size = new Size(179, 51);
            labelPriceCow.TabIndex = 3;
            labelPriceCow.Text = "Price : 500$";
            labelPriceCow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCow
            // 
            pictureBoxCow.BackColor = Color.DarkGray;
            pictureBoxCow.Dock = DockStyle.Left;
            pictureBoxCow.Image = (Image)resources.GetObject("pictureBoxCow.Image");
            pictureBoxCow.Location = new Point(0, 0);
            pictureBoxCow.Name = "pictureBoxCow";
            pictureBoxCow.Size = new Size(320, 270);
            pictureBoxCow.TabIndex = 0;
            pictureBoxCow.TabStop = false;
            // 
            // labelCowDesc
            // 
            labelCowDesc.BackColor = Color.Transparent;
            labelCowDesc.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            labelCowDesc.Location = new Point(326, 8);
            labelCowDesc.Name = "labelCowDesc";
            labelCowDesc.Size = new Size(484, 251);
            labelCowDesc.TabIndex = 1;
            labelCowDesc.Text = resources.GetString("labelCowDesc.Text");
            // 
            // panelBee
            // 
            panelBee.Controls.Add(labelBeeProduct);
            panelBee.Controls.Add(labelPriceBee);
            panelBee.Controls.Add(pictureBoxBee);
            panelBee.Controls.Add(labelBeeDesc);
            panelBee.Location = new Point(3, 279);
            panelBee.Name = "panelBee";
            panelBee.Size = new Size(1006, 270);
            panelBee.TabIndex = 5;
            // 
            // labelBeeProduct
            // 
            labelBeeProduct.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelBeeProduct.ForeColor = SystemColors.ControlText;
            labelBeeProduct.Location = new Point(326, 197);
            labelBeeProduct.Name = "labelBeeProduct";
            labelBeeProduct.Size = new Size(669, 62);
            labelBeeProduct.TabIndex = 5;
            labelBeeProduct.Text = "Production per Hour: 1 Jar of Honey";
            labelBeeProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPriceBee
            // 
            labelPriceBee.BackColor = Color.Transparent;
            labelPriceBee.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelPriceBee.Location = new Point(816, 8);
            labelPriceBee.Name = "labelPriceBee";
            labelPriceBee.Size = new Size(179, 51);
            labelPriceBee.TabIndex = 3;
            labelPriceBee.Text = "Price : 500$";
            labelPriceBee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBee
            // 
            pictureBoxBee.BackColor = Color.DarkGray;
            pictureBoxBee.Dock = DockStyle.Left;
            pictureBoxBee.Image = (Image)resources.GetObject("pictureBoxBee.Image");
            pictureBoxBee.Location = new Point(0, 0);
            pictureBoxBee.Name = "pictureBoxBee";
            pictureBoxBee.Size = new Size(320, 270);
            pictureBoxBee.TabIndex = 0;
            pictureBoxBee.TabStop = false;
            // 
            // labelBeeDesc
            // 
            labelBeeDesc.BackColor = Color.Transparent;
            labelBeeDesc.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            labelBeeDesc.Location = new Point(326, 8);
            labelBeeDesc.Name = "labelBeeDesc";
            labelBeeDesc.Size = new Size(484, 251);
            labelBeeDesc.TabIndex = 1;
            labelBeeDesc.Text = resources.GetString("labelBeeDesc.Text");
            // 
            // panelChicken
            // 
            panelChicken.Controls.Add(labelChickenProduct);
            panelChicken.Controls.Add(labelPriceChicken);
            panelChicken.Controls.Add(pictureBoxChicken);
            panelChicken.Controls.Add(labelChickenDesc);
            panelChicken.Location = new Point(3, 555);
            panelChicken.Name = "panelChicken";
            panelChicken.Size = new Size(1006, 270);
            panelChicken.TabIndex = 6;
            // 
            // labelChickenProduct
            // 
            labelChickenProduct.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelChickenProduct.ForeColor = SystemColors.ControlText;
            labelChickenProduct.Location = new Point(326, 197);
            labelChickenProduct.Name = "labelChickenProduct";
            labelChickenProduct.Size = new Size(669, 62);
            labelChickenProduct.TabIndex = 5;
            labelChickenProduct.Text = "Production per Hour: 3 Eggs";
            labelChickenProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPriceChicken
            // 
            labelPriceChicken.BackColor = Color.Transparent;
            labelPriceChicken.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelPriceChicken.Location = new Point(816, 8);
            labelPriceChicken.Name = "labelPriceChicken";
            labelPriceChicken.Size = new Size(179, 51);
            labelPriceChicken.TabIndex = 3;
            labelPriceChicken.Text = "Price : 500$";
            labelPriceChicken.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxChicken
            // 
            pictureBoxChicken.BackColor = Color.DarkGray;
            pictureBoxChicken.Dock = DockStyle.Left;
            pictureBoxChicken.Image = (Image)resources.GetObject("pictureBoxChicken.Image");
            pictureBoxChicken.Location = new Point(0, 0);
            pictureBoxChicken.Name = "pictureBoxChicken";
            pictureBoxChicken.Size = new Size(320, 270);
            pictureBoxChicken.TabIndex = 0;
            pictureBoxChicken.TabStop = false;
            // 
            // labelChickenDesc
            // 
            labelChickenDesc.BackColor = Color.Transparent;
            labelChickenDesc.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            labelChickenDesc.Location = new Point(326, 8);
            labelChickenDesc.Name = "labelChickenDesc";
            labelChickenDesc.Size = new Size(484, 251);
            labelChickenDesc.TabIndex = 1;
            labelChickenDesc.Text = resources.GetString("labelChickenDesc.Text");
            // 
            // panelGoat
            // 
            panelGoat.Controls.Add(labelGoatProduct);
            panelGoat.Controls.Add(labelPriceGoat);
            panelGoat.Controls.Add(pictureBoxGoat);
            panelGoat.Controls.Add(labelGoatDesc);
            panelGoat.Location = new Point(3, 831);
            panelGoat.Name = "panelGoat";
            panelGoat.Size = new Size(1006, 270);
            panelGoat.TabIndex = 7;
            // 
            // labelGoatProduct
            // 
            labelGoatProduct.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelGoatProduct.ForeColor = SystemColors.ControlText;
            labelGoatProduct.Location = new Point(326, 197);
            labelGoatProduct.Name = "labelGoatProduct";
            labelGoatProduct.Size = new Size(669, 62);
            labelGoatProduct.TabIndex = 5;
            labelGoatProduct.Text = "Production per Hour: A glass of milk";
            labelGoatProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPriceGoat
            // 
            labelPriceGoat.BackColor = Color.Transparent;
            labelPriceGoat.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelPriceGoat.Location = new Point(816, 8);
            labelPriceGoat.Name = "labelPriceGoat";
            labelPriceGoat.Size = new Size(179, 51);
            labelPriceGoat.TabIndex = 3;
            labelPriceGoat.Text = "Price : 500$";
            labelPriceGoat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxGoat
            // 
            pictureBoxGoat.BackColor = Color.DarkGray;
            pictureBoxGoat.Dock = DockStyle.Left;
            pictureBoxGoat.Image = (Image)resources.GetObject("pictureBoxGoat.Image");
            pictureBoxGoat.Location = new Point(0, 0);
            pictureBoxGoat.Name = "pictureBoxGoat";
            pictureBoxGoat.Size = new Size(320, 270);
            pictureBoxGoat.TabIndex = 0;
            pictureBoxGoat.TabStop = false;
            // 
            // labelGoatDesc
            // 
            labelGoatDesc.BackColor = Color.Transparent;
            labelGoatDesc.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            labelGoatDesc.Location = new Point(326, 8);
            labelGoatDesc.Name = "labelGoatDesc";
            labelGoatDesc.Size = new Size(484, 251);
            labelGoatDesc.TabIndex = 1;
            labelGoatDesc.Text = resources.GetString("labelGoatDesc.Text");
            // 
            // panelLamb
            // 
            panelLamb.Controls.Add(labelLambProduct);
            panelLamb.Controls.Add(labelPriceLamb);
            panelLamb.Controls.Add(pictureBoxLamb);
            panelLamb.Controls.Add(labelLambDesc);
            panelLamb.Location = new Point(3, 1107);
            panelLamb.Name = "panelLamb";
            panelLamb.Size = new Size(1006, 270);
            panelLamb.TabIndex = 8;
            // 
            // labelLambProduct
            // 
            labelLambProduct.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelLambProduct.ForeColor = SystemColors.ControlText;
            labelLambProduct.Location = new Point(326, 197);
            labelLambProduct.Name = "labelLambProduct";
            labelLambProduct.Size = new Size(669, 62);
            labelLambProduct.TabIndex = 5;
            labelLambProduct.Text = "Production per Hour: 5 kg of wool";
            labelLambProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPriceLamb
            // 
            labelPriceLamb.BackColor = Color.Transparent;
            labelPriceLamb.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelPriceLamb.Location = new Point(816, 8);
            labelPriceLamb.Name = "labelPriceLamb";
            labelPriceLamb.Size = new Size(179, 51);
            labelPriceLamb.TabIndex = 3;
            labelPriceLamb.Text = "Price : 500$";
            labelPriceLamb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLamb
            // 
            pictureBoxLamb.BackColor = Color.DarkGray;
            pictureBoxLamb.Dock = DockStyle.Left;
            pictureBoxLamb.Image = (Image)resources.GetObject("pictureBoxLamb.Image");
            pictureBoxLamb.Location = new Point(0, 0);
            pictureBoxLamb.Name = "pictureBoxLamb";
            pictureBoxLamb.Size = new Size(320, 270);
            pictureBoxLamb.TabIndex = 0;
            pictureBoxLamb.TabStop = false;
            // 
            // labelLambDesc
            // 
            labelLambDesc.BackColor = Color.Transparent;
            labelLambDesc.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            labelLambDesc.Location = new Point(326, 8);
            labelLambDesc.Name = "labelLambDesc";
            labelLambDesc.Size = new Size(484, 251);
            labelLambDesc.TabIndex = 1;
            labelLambDesc.Text = resources.GetString("labelLambDesc.Text");
            // 
            // pnlShopHeader
            // 
            pnlShopHeader.Controls.Add(btnBuy);
            pnlShopHeader.Controls.Add(labelHeaderShop);
            pnlShopHeader.Dock = DockStyle.Top;
            pnlShopHeader.Location = new Point(0, 0);
            pnlShopHeader.Margin = new Padding(0);
            pnlShopHeader.Name = "pnlShopHeader";
            pnlShopHeader.Padding = new Padding(10);
            pnlShopHeader.Size = new Size(1335, 120);
            pnlShopHeader.TabIndex = 5;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.Black;
            btnBuy.Dock = DockStyle.Right;
            btnBuy.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBuy.ForeColor = Color.White;
            btnBuy.Location = new Point(1116, 10);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(209, 100);
            btnBuy.TabIndex = 1;
            btnBuy.Text = "Buy Now";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1335, 840);
            Controls.Add(pnlShopHeader);
            Controls.Add(shopFlowPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShopForm";
            Text = "ShopForm";
            shopFlowPanel.ResumeLayout(false);
            panelCow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCow).EndInit();
            panelBee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBee).EndInit();
            panelChicken.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxChicken).EndInit();
            panelGoat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGoat).EndInit();
            panelLamb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLamb).EndInit();
            pnlShopHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelHeaderShop;
        private FlowLayoutPanel shopFlowPanel;
        private Panel panelCow;
        private Label labelPriceCow;
        private PictureBox pictureBoxCow;
        private Label labelCowDesc;
        private Panel panelBee;
        private Label labelPriceBee;
        private PictureBox pictureBoxBee;
        private Label labelBeeDesc;
        private Panel panelChicken;
        private Label labelPriceChicken;
        private PictureBox pictureBoxChicken;
        private Label labelChickenDesc;
        private Panel panelGoat;
        private Label labelPriceGoat;
        private PictureBox pictureBoxGoat;
        private Label labelGoatDesc;
        private Panel panelLamb;
        private Label labelPriceLamb;
        private PictureBox pictureBoxLamb;
        private Label labelLambDesc;
        private Label labelCowProduct;
        private Label labelBeeProduct;
        private Label labelChickenProduct;
        private Label labelGoatProduct;
        private Label labelLambProduct;
        private Panel pnlShopHeader;
        private Button btnBuy;
    }
}