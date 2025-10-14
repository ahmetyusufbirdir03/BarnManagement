using FontAwesome.Sharp;

namespace FarmShoppingForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            btnRouterFarm = new Button();
            btnRouterShop = new Button();
            btnRouterStorage = new Button();
            LabelHeaderSidebar = new Label();
            panelSideBar = new Panel();
            labelMoneyValue = new Label();
            labelHeaderMoney = new Label();
            panelMain = new Panel();
            panelSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnRouterFarm
            // 
            btnRouterFarm.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRouterFarm.Location = new Point(15, 180);
            btnRouterFarm.Name = "btnRouterFarm";
            btnRouterFarm.Size = new Size(284, 50);
            btnRouterFarm.TabIndex = 2;
            btnRouterFarm.Text = "Farm";
            btnRouterFarm.UseVisualStyleBackColor = true;
            btnRouterFarm.Click += btnRouterFarm_Click;
            // 
            // btnRouterShop
            // 
            btnRouterShop.BackColor = Color.White;
            btnRouterShop.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRouterShop.ForeColor = SystemColors.ControlText;
            btnRouterShop.Location = new Point(15, 250);
            btnRouterShop.Name = "btnRouterShop";
            btnRouterShop.Size = new Size(280, 50);
            btnRouterShop.TabIndex = 1;
            btnRouterShop.Text = "Shop";
            btnRouterShop.UseVisualStyleBackColor = false;
            btnRouterShop.Click += btnRouterShop_Click;
            // 
            // btnRouterStorage
            // 
            btnRouterStorage.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRouterStorage.Location = new Point(15, 320);
            btnRouterStorage.Name = "btnRouterStorage";
            btnRouterStorage.Size = new Size(280, 50);
            btnRouterStorage.TabIndex = 3;
            btnRouterStorage.Text = "Storage";
            btnRouterStorage.UseVisualStyleBackColor = true;
            btnRouterStorage.Click += btnRouterStorage_Click;
            // 
            // LabelHeaderSidebar
            // 
            LabelHeaderSidebar.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LabelHeaderSidebar.Location = new Point(20, 20);
            LabelHeaderSidebar.Name = "LabelHeaderSidebar";
            LabelHeaderSidebar.Size = new Size(280, 140);
            LabelHeaderSidebar.TabIndex = 4;
            LabelHeaderSidebar.Text = "Farm Shopping Simulator";
            LabelHeaderSidebar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.Transparent;
            panelSideBar.Controls.Add(labelMoneyValue);
            panelSideBar.Controls.Add(labelHeaderMoney);
            panelSideBar.Controls.Add(LabelHeaderSidebar);
            panelSideBar.Controls.Add(btnRouterStorage);
            panelSideBar.Controls.Add(btnRouterShop);
            panelSideBar.Controls.Add(btnRouterFarm);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.ForeColor = SystemColors.ActiveCaptionText;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(320, 793);
            panelSideBar.TabIndex = 0;
            // 
            // labelMoneyValue
            // 
            labelMoneyValue.Anchor = AnchorStyles.None;
            labelMoneyValue.BackColor = Color.Black;
            labelMoneyValue.BorderStyle = BorderStyle.Fixed3D;
            labelMoneyValue.Font = new Font("Comic Sans MS", 18.2F, FontStyle.Bold);
            labelMoneyValue.ForeColor = Color.Yellow;
            labelMoneyValue.Location = new Point(155, 390);
            labelMoneyValue.Name = "labelMoneyValue";
            labelMoneyValue.RightToLeft = RightToLeft.No;
            labelMoneyValue.Size = new Size(140, 50);
            labelMoneyValue.TabIndex = 5;
            labelMoneyValue.Text = "500$";
            // 
            // labelHeaderMoney
            // 
            labelHeaderMoney.Font = new Font("Comic Sans MS", 18.2F, FontStyle.Bold);
            labelHeaderMoney.Location = new Point(15, 388);
            labelHeaderMoney.Name = "labelHeaderMoney";
            labelHeaderMoney.Size = new Size(140, 50);
            labelHeaderMoney.TabIndex = 0;
            labelHeaderMoney.Text = "Money:";
            labelHeaderMoney.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(192, 192, 255);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(320, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1062, 793);
            panelMain.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1382, 793);
            Controls.Add(panelMain);
            Controls.Add(panelSideBar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Farm Shopping";
            panelSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnRouterFarm;
        private Button btnRouterShop;
        private Button btnRouterStorage;
        private Label LabelHeaderSidebar;
        private Panel panelSideBar;
        private Panel panelMain;
        private Label labelMoneyValue;
        private Label labelHeaderMoney;
    }
}
