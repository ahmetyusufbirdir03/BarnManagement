namespace FarmShoppingForm
{
    partial class SellForm
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
            lblSellText = new Label();
            numSell = new NumericUpDown();
            pnlSell = new Panel();
            comboBoxProduct = new ComboBox();
            labelProduct = new Label();
            btnSellAccept = new Button();
            ((System.ComponentModel.ISupportInitialize)numSell).BeginInit();
            pnlSell.SuspendLayout();
            SuspendLayout();
            // 
            // lblSellText
            // 
            lblSellText.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSellText.Location = new Point(20, 20);
            lblSellText.Name = "lblSellText";
            lblSellText.Size = new Size(270, 50);
            lblSellText.TabIndex = 0;
            lblSellText.Text = "Enter an amount :";
            lblSellText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numSell
            // 
            numSell.Location = new Point(290, 38);
            numSell.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSell.Name = "numSell";
            numSell.Size = new Size(270, 27);
            numSell.TabIndex = 1;
            numSell.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pnlSell
            // 
            pnlSell.Controls.Add(comboBoxProduct);
            pnlSell.Controls.Add(labelProduct);
            pnlSell.Controls.Add(btnSellAccept);
            pnlSell.Controls.Add(numSell);
            pnlSell.Controls.Add(lblSellText);
            pnlSell.Dock = DockStyle.Fill;
            pnlSell.Location = new Point(0, 0);
            pnlSell.Name = "pnlSell";
            pnlSell.Padding = new Padding(20);
            pnlSell.Size = new Size(580, 230);
            pnlSell.TabIndex = 2;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(290, 107);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(270, 28);
            comboBoxProduct.TabIndex = 4;
            // 
            // labelProduct
            // 
            labelProduct.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelProduct.Location = new Point(20, 90);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(270, 50);
            labelProduct.TabIndex = 3;
            labelProduct.Text = "Select Product:";
            labelProduct.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSellAccept
            // 
            btnSellAccept.BackColor = Color.Black;
            btnSellAccept.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSellAccept.ForeColor = Color.White;
            btnSellAccept.Location = new Point(240, 160);
            btnSellAccept.Name = "btnSellAccept";
            btnSellAccept.Size = new Size(120, 50);
            btnSellAccept.TabIndex = 2;
            btnSellAccept.Text = "Accept";
            btnSellAccept.UseVisualStyleBackColor = false;
            btnSellAccept.Click += btnSellAccept_Click;
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(580, 230);
            Controls.Add(pnlSell);
            Name = "SellForm";
            Text = "SellForm";
            ((System.ComponentModel.ISupportInitialize)numSell).EndInit();
            pnlSell.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSellText;
        private NumericUpDown numSell;
        private Panel pnlSell;
        private Button btnSellAccept;
        private ComboBox comboBoxProduct;
        private Label labelProduct;
    }
}