namespace FarmShoppingForm
{
    partial class StorageForm
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
            pnlStorageHeader = new Panel();
            lblHeader = new Label();
            btnSell = new Button();
            panel1 = new Panel();
            pnlWool = new Panel();
            lblWool = new Label();
            lblWoolPrice = new Label();
            lblWoolHeader = new Label();
            pnlEgg = new Panel();
            lblEgg = new Label();
            lblEggPrice = new Label();
            lblEggHeader = new Label();
            ppnlHoneyJar = new Panel();
            lblHoneyJar = new Label();
            lblHoneyJarPrice = new Label();
            lblHoneyJarHeader = new Label();
            pnlGoatMilk = new Panel();
            lblGoatMilk = new Label();
            lblGoatMilkPrice = new Label();
            lblGoatMilkHeader = new Label();
            pnlCowMilk = new Panel();
            lblCowMilk = new Label();
            lblCowMilkPrice = new Label();
            lblCowMilkHeader = new Label();
            pnlStorageHeader.SuspendLayout();
            panel1.SuspendLayout();
            pnlWool.SuspendLayout();
            pnlEgg.SuspendLayout();
            ppnlHoneyJar.SuspendLayout();
            pnlGoatMilk.SuspendLayout();
            pnlCowMilk.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStorageHeader
            // 
            pnlStorageHeader.BackColor = Color.FromArgb(192, 192, 255);
            pnlStorageHeader.BorderStyle = BorderStyle.Fixed3D;
            pnlStorageHeader.Controls.Add(lblHeader);
            pnlStorageHeader.Controls.Add(btnSell);
            pnlStorageHeader.Dock = DockStyle.Top;
            pnlStorageHeader.Location = new Point(0, 0);
            pnlStorageHeader.Margin = new Padding(0);
            pnlStorageHeader.Name = "pnlStorageHeader";
            pnlStorageHeader.Padding = new Padding(10);
            pnlStorageHeader.Size = new Size(1062, 120);
            pnlStorageHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Left;
            lblHeader.Font = new Font("Comic Sans MS", 28.8000011F, FontStyle.Bold);
            lblHeader.Location = new Point(10, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(762, 96);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "STORAGE";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.Black;
            btnSell.Dock = DockStyle.Right;
            btnSell.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSell.ForeColor = Color.White;
            btnSell.Location = new Point(818, 10);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(230, 96);
            btnSell.TabIndex = 2;
            btnSell.Text = "Sell";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pnlWool);
            panel1.Controls.Add(pnlEgg);
            panel1.Controls.Add(ppnlHoneyJar);
            panel1.Controls.Add(pnlGoatMilk);
            panel1.Controls.Add(pnlCowMilk);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 673);
            panel1.TabIndex = 1;
            // 
            // pnlWool
            // 
            pnlWool.AutoScroll = true;
            pnlWool.BackColor = Color.FromArgb(255, 224, 192);
            pnlWool.BorderStyle = BorderStyle.FixedSingle;
            pnlWool.Controls.Add(lblWool);
            pnlWool.Controls.Add(lblWoolPrice);
            pnlWool.Controls.Add(lblWoolHeader);
            pnlWool.Location = new Point(20, 20);
            pnlWool.Name = "pnlWool";
            pnlWool.Padding = new Padding(15);
            pnlWool.Size = new Size(250, 215);
            pnlWool.TabIndex = 14;
            // 
            // lblWool
            // 
            lblWool.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWool.Location = new Point(25, 155);
            lblWool.Name = "lblWool";
            lblWool.Size = new Size(200, 50);
            lblWool.TabIndex = 6;
            lblWool.Text = "Count : 0";
            lblWool.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWoolPrice
            // 
            lblWoolPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWoolPrice.Location = new Point(25, 90);
            lblWoolPrice.Name = "lblWoolPrice";
            lblWoolPrice.Size = new Size(200, 50);
            lblWoolPrice.TabIndex = 3;
            lblWoolPrice.Text = "Price : 5$";
            lblWoolPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWoolHeader
            // 
            lblWoolHeader.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblWoolHeader.Location = new Point(25, 25);
            lblWoolHeader.Name = "lblWoolHeader";
            lblWoolHeader.Size = new Size(200, 50);
            lblWoolHeader.TabIndex = 0;
            lblWoolHeader.Text = "Wool";
            lblWoolHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEgg
            // 
            pnlEgg.AutoScroll = true;
            pnlEgg.BackColor = Color.FromArgb(255, 224, 192);
            pnlEgg.BorderStyle = BorderStyle.FixedSingle;
            pnlEgg.Controls.Add(lblEgg);
            pnlEgg.Controls.Add(lblEggPrice);
            pnlEgg.Controls.Add(lblEggHeader);
            pnlEgg.Location = new Point(406, 189);
            pnlEgg.Name = "pnlEgg";
            pnlEgg.Padding = new Padding(25);
            pnlEgg.Size = new Size(250, 215);
            pnlEgg.TabIndex = 13;
            // 
            // lblEgg
            // 
            lblEgg.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEgg.Location = new Point(25, 155);
            lblEgg.Name = "lblEgg";
            lblEgg.Size = new Size(200, 50);
            lblEgg.TabIndex = 4;
            lblEgg.Text = "Count : 0";
            lblEgg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEggPrice
            // 
            lblEggPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEggPrice.Location = new Point(25, 90);
            lblEggPrice.Name = "lblEggPrice";
            lblEggPrice.Size = new Size(200, 50);
            lblEggPrice.TabIndex = 3;
            lblEggPrice.Text = "Price : 5$";
            lblEggPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEggHeader
            // 
            lblEggHeader.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblEggHeader.Location = new Point(25, 25);
            lblEggHeader.Name = "lblEggHeader";
            lblEggHeader.Size = new Size(200, 50);
            lblEggHeader.TabIndex = 0;
            lblEggHeader.Text = "Egg";
            lblEggHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ppnlHoneyJar
            // 
            ppnlHoneyJar.AutoScroll = true;
            ppnlHoneyJar.BackColor = Color.FromArgb(255, 224, 192);
            ppnlHoneyJar.BorderStyle = BorderStyle.FixedSingle;
            ppnlHoneyJar.Controls.Add(lblHoneyJar);
            ppnlHoneyJar.Controls.Add(lblHoneyJarPrice);
            ppnlHoneyJar.Controls.Add(lblHoneyJarHeader);
            ppnlHoneyJar.Location = new Point(792, 20);
            ppnlHoneyJar.Name = "ppnlHoneyJar";
            ppnlHoneyJar.Padding = new Padding(20, 10, 10, 10);
            ppnlHoneyJar.Size = new Size(250, 215);
            ppnlHoneyJar.TabIndex = 12;
            // 
            // lblHoneyJar
            // 
            lblHoneyJar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHoneyJar.Location = new Point(25, 155);
            lblHoneyJar.Name = "lblHoneyJar";
            lblHoneyJar.Size = new Size(200, 50);
            lblHoneyJar.TabIndex = 5;
            lblHoneyJar.Text = "Count : 0";
            lblHoneyJar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoneyJarPrice
            // 
            lblHoneyJarPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHoneyJarPrice.Location = new Point(25, 90);
            lblHoneyJarPrice.Name = "lblHoneyJarPrice";
            lblHoneyJarPrice.Size = new Size(200, 50);
            lblHoneyJarPrice.TabIndex = 3;
            lblHoneyJarPrice.Text = "Price : 5$";
            lblHoneyJarPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoneyJarHeader
            // 
            lblHoneyJarHeader.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblHoneyJarHeader.Location = new Point(25, 25);
            lblHoneyJarHeader.Name = "lblHoneyJarHeader";
            lblHoneyJarHeader.Size = new Size(200, 50);
            lblHoneyJarHeader.TabIndex = 0;
            lblHoneyJarHeader.Text = "Honey Jar";
            lblHoneyJarHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlGoatMilk
            // 
            pnlGoatMilk.AutoScroll = true;
            pnlGoatMilk.BackColor = Color.FromArgb(255, 224, 192);
            pnlGoatMilk.BorderStyle = BorderStyle.FixedSingle;
            pnlGoatMilk.Controls.Add(lblGoatMilk);
            pnlGoatMilk.Controls.Add(lblGoatMilkPrice);
            pnlGoatMilk.Controls.Add(lblGoatMilkHeader);
            pnlGoatMilk.Location = new Point(20, 363);
            pnlGoatMilk.Name = "pnlGoatMilk";
            pnlGoatMilk.Padding = new Padding(20, 10, 10, 10);
            pnlGoatMilk.Size = new Size(250, 215);
            pnlGoatMilk.TabIndex = 11;
            // 
            // lblGoatMilk
            // 
            lblGoatMilk.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGoatMilk.Location = new Point(25, 155);
            lblGoatMilk.Name = "lblGoatMilk";
            lblGoatMilk.Size = new Size(200, 50);
            lblGoatMilk.TabIndex = 5;
            lblGoatMilk.Text = "Count : 0";
            lblGoatMilk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGoatMilkPrice
            // 
            lblGoatMilkPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGoatMilkPrice.Location = new Point(25, 90);
            lblGoatMilkPrice.Name = "lblGoatMilkPrice";
            lblGoatMilkPrice.Size = new Size(200, 50);
            lblGoatMilkPrice.TabIndex = 3;
            lblGoatMilkPrice.Text = "Price : 5$";
            lblGoatMilkPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGoatMilkHeader
            // 
            lblGoatMilkHeader.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblGoatMilkHeader.Location = new Point(25, 25);
            lblGoatMilkHeader.Name = "lblGoatMilkHeader";
            lblGoatMilkHeader.Size = new Size(200, 50);
            lblGoatMilkHeader.TabIndex = 0;
            lblGoatMilkHeader.Text = "Goat Milk";
            lblGoatMilkHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCowMilk
            // 
            pnlCowMilk.AutoScroll = true;
            pnlCowMilk.BackColor = Color.FromArgb(255, 224, 192);
            pnlCowMilk.BorderStyle = BorderStyle.FixedSingle;
            pnlCowMilk.Controls.Add(lblCowMilk);
            pnlCowMilk.Controls.Add(lblCowMilkPrice);
            pnlCowMilk.Controls.Add(lblCowMilkHeader);
            pnlCowMilk.Location = new Point(792, 363);
            pnlCowMilk.Name = "pnlCowMilk";
            pnlCowMilk.Padding = new Padding(20, 10, 10, 10);
            pnlCowMilk.Size = new Size(250, 215);
            pnlCowMilk.TabIndex = 10;
            // 
            // lblCowMilk
            // 
            lblCowMilk.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCowMilk.Location = new Point(25, 155);
            lblCowMilk.Name = "lblCowMilk";
            lblCowMilk.Size = new Size(200, 50);
            lblCowMilk.TabIndex = 5;
            lblCowMilk.Text = "Count : 0";
            lblCowMilk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCowMilkPrice
            // 
            lblCowMilkPrice.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCowMilkPrice.Location = new Point(25, 90);
            lblCowMilkPrice.Name = "lblCowMilkPrice";
            lblCowMilkPrice.Size = new Size(200, 50);
            lblCowMilkPrice.TabIndex = 3;
            lblCowMilkPrice.Text = "Price : 5$";
            lblCowMilkPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCowMilkHeader
            // 
            lblCowMilkHeader.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblCowMilkHeader.Location = new Point(25, 25);
            lblCowMilkHeader.Name = "lblCowMilkHeader";
            lblCowMilkHeader.Size = new Size(200, 50);
            lblCowMilkHeader.TabIndex = 0;
            lblCowMilkHeader.Text = "Cow Milk";
            lblCowMilkHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StorageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 793);
            Controls.Add(panel1);
            Controls.Add(pnlStorageHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StorageForm";
            Text = "StorageForm";
            pnlStorageHeader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlWool.ResumeLayout(false);
            pnlEgg.ResumeLayout(false);
            ppnlHoneyJar.ResumeLayout(false);
            pnlGoatMilk.ResumeLayout(false);
            pnlCowMilk.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlStorageHeader;
        private Label lblHeader;
        private Panel panel1;
        private Panel pnlWool;
        private Label lblWoolPrice;
        private Button btnSellWool;
        private Label lblWoolHeader;
        private Panel pnlEgg;
        private Label lblEggPrice;
        private Button btnSellEgg;
        private Label lblEggHeader;
        private Panel ppnlHoneyJar;
        private Label lblHoneyJarPrice;
        private Button btnSellHoneyJar;
        private Label lblHoneyJarHeader;
        private Panel pnlGoatMilk;
        private Label lblGoatMilkPrice;
        private Button btnSell;
        private Label lblGoatMilkHeader;
        private Panel pnlCowMilk;
        private Label lblCowMilkPrice;
        private Button btnSellCowMilk;
        private Label lblCowMilkHeader;
        private Label lblEgg;
        private Label lblWool;
        private Label lblGoatMilk;
        private Label lblHoneyJar;
        private Label lblCowMilk;
    }
}