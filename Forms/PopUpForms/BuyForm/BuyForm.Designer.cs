namespace FarmShoppingForm
{
    partial class BuyForm
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
            panelBuyForm = new Panel();
            labelHeaderBuyForm = new Label();
            panelSpec = new Panel();
            panel1 = new Panel();
            comboBoxAnimalType = new ComboBox();
            label1 = new Label();
            panelOriginSpec = new Panel();
            labelOriginHeader = new Label();
            panelAgeSpec = new Panel();
            numericBoxAgeValue = new NumericUpDown();
            labelAgeHeader = new Label();
            panelNameSpec = new Panel();
            textBoxNameValue = new TextBox();
            labelNameHeader = new Label();
            btnBuyForm = new Button();
            comboBoxOriginValue = new ComboBox();
            panelBuyForm.SuspendLayout();
            panelSpec.SuspendLayout();
            panel1.SuspendLayout();
            panelOriginSpec.SuspendLayout();
            panelAgeSpec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericBoxAgeValue).BeginInit();
            panelNameSpec.SuspendLayout();
            SuspendLayout();
            // 
            // panelBuyForm
            // 
            panelBuyForm.BackColor = SystemColors.ActiveCaption;
            panelBuyForm.Controls.Add(labelHeaderBuyForm);
            panelBuyForm.Controls.Add(panelSpec);
            panelBuyForm.Dock = DockStyle.Fill;
            panelBuyForm.Location = new Point(0, 0);
            panelBuyForm.Name = "panelBuyForm";
            panelBuyForm.Padding = new Padding(20);
            panelBuyForm.Size = new Size(500, 509);
            panelBuyForm.TabIndex = 0;
            // 
            // labelHeaderBuyForm
            // 
            labelHeaderBuyForm.Dock = DockStyle.Top;
            labelHeaderBuyForm.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelHeaderBuyForm.ForeColor = Color.Indigo;
            labelHeaderBuyForm.Location = new Point(20, 20);
            labelHeaderBuyForm.Name = "labelHeaderBuyForm";
            labelHeaderBuyForm.Size = new Size(460, 50);
            labelHeaderBuyForm.TabIndex = 1;
            labelHeaderBuyForm.Text = "Specialize Your Animal";
            labelHeaderBuyForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSpec
            // 
            panelSpec.Controls.Add(panel1);
            panelSpec.Controls.Add(panelOriginSpec);
            panelSpec.Controls.Add(panelAgeSpec);
            panelSpec.Controls.Add(panelNameSpec);
            panelSpec.Controls.Add(btnBuyForm);
            panelSpec.Dock = DockStyle.Bottom;
            panelSpec.Location = new Point(20, 94);
            panelSpec.Name = "panelSpec";
            panelSpec.Padding = new Padding(10);
            panelSpec.Size = new Size(460, 395);
            panelSpec.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxAnimalType);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 249);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(440, 70);
            panel1.TabIndex = 7;
            // 
            // comboBoxAnimalType
            // 
            comboBoxAnimalType.FormattingEnabled = true;
            comboBoxAnimalType.Location = new Point(110, 27);
            comboBoxAnimalType.Name = "comboBoxAnimalType";
            comboBoxAnimalType.Size = new Size(320, 28);
            comboBoxAnimalType.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(110, 50);
            label1.TabIndex = 1;
            label1.Text = "Type:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelOriginSpec
            // 
            panelOriginSpec.Controls.Add(comboBoxOriginValue);
            panelOriginSpec.Controls.Add(labelOriginHeader);
            panelOriginSpec.Location = new Point(10, 170);
            panelOriginSpec.Name = "panelOriginSpec";
            panelOriginSpec.Padding = new Padding(10);
            panelOriginSpec.Size = new Size(440, 70);
            panelOriginSpec.TabIndex = 6;
            // 
            // labelOriginHeader
            // 
            labelOriginHeader.Dock = DockStyle.Left;
            labelOriginHeader.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelOriginHeader.ForeColor = Color.Indigo;
            labelOriginHeader.Location = new Point(10, 10);
            labelOriginHeader.Name = "labelOriginHeader";
            labelOriginHeader.Size = new Size(110, 50);
            labelOriginHeader.TabIndex = 1;
            labelOriginHeader.Text = "Origin:";
            labelOriginHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelAgeSpec
            // 
            panelAgeSpec.Controls.Add(numericBoxAgeValue);
            panelAgeSpec.Controls.Add(labelAgeHeader);
            panelAgeSpec.Location = new Point(10, 90);
            panelAgeSpec.Name = "panelAgeSpec";
            panelAgeSpec.Padding = new Padding(10);
            panelAgeSpec.Size = new Size(440, 70);
            panelAgeSpec.TabIndex = 5;
            // 
            // numericBoxAgeValue
            // 
            numericBoxAgeValue.Location = new Point(110, 28);
            numericBoxAgeValue.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericBoxAgeValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericBoxAgeValue.Name = "numericBoxAgeValue";
            numericBoxAgeValue.Size = new Size(320, 27);
            numericBoxAgeValue.TabIndex = 2;
            numericBoxAgeValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelAgeHeader
            // 
            labelAgeHeader.Dock = DockStyle.Left;
            labelAgeHeader.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelAgeHeader.ForeColor = Color.Indigo;
            labelAgeHeader.Location = new Point(10, 10);
            labelAgeHeader.Name = "labelAgeHeader";
            labelAgeHeader.Size = new Size(110, 50);
            labelAgeHeader.TabIndex = 1;
            labelAgeHeader.Text = "Age:";
            labelAgeHeader.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelNameSpec
            // 
            panelNameSpec.Controls.Add(textBoxNameValue);
            panelNameSpec.Controls.Add(labelNameHeader);
            panelNameSpec.Location = new Point(10, 10);
            panelNameSpec.Name = "panelNameSpec";
            panelNameSpec.Padding = new Padding(10);
            panelNameSpec.Size = new Size(440, 70);
            panelNameSpec.TabIndex = 4;
            // 
            // textBoxNameValue
            // 
            textBoxNameValue.Location = new Point(110, 27);
            textBoxNameValue.Name = "textBoxNameValue";
            textBoxNameValue.Size = new Size(320, 27);
            textBoxNameValue.TabIndex = 1;
            textBoxNameValue.KeyPress += textBoxNameValue_KeyPress;
            // 
            // labelNameHeader
            // 
            labelNameHeader.Dock = DockStyle.Left;
            labelNameHeader.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelNameHeader.ForeColor = Color.Indigo;
            labelNameHeader.Location = new Point(10, 10);
            labelNameHeader.Name = "labelNameHeader";
            labelNameHeader.Size = new Size(110, 50);
            labelNameHeader.TabIndex = 0;
            labelNameHeader.Text = "Name:";
            labelNameHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBuyForm
            // 
            btnBuyForm.AccessibleRole = AccessibleRole.None;
            btnBuyForm.BackColor = Color.Indigo;
            btnBuyForm.Dock = DockStyle.Bottom;
            btnBuyForm.FlatStyle = FlatStyle.Flat;
            btnBuyForm.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBuyForm.ForeColor = Color.White;
            btnBuyForm.Location = new Point(10, 325);
            btnBuyForm.Name = "btnBuyForm";
            btnBuyForm.Size = new Size(440, 60);
            btnBuyForm.TabIndex = 3;
            btnBuyForm.Text = "Buy";
            btnBuyForm.UseVisualStyleBackColor = false;
            btnBuyForm.Click += btnBuyForm_Click;
            // 
            // comboBoxOriginValue
            // 
            comboBoxOriginValue.FormattingEnabled = true;
            comboBoxOriginValue.Location = new Point(110, 27);
            comboBoxOriginValue.Name = "comboBoxOriginValue";
            comboBoxOriginValue.Size = new Size(320, 28);
            comboBoxOriginValue.TabIndex = 2;
            // 
            // BuyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 509);
            Controls.Add(panelBuyForm);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BuyForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BuyForm";
            panelBuyForm.ResumeLayout(false);
            panelSpec.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelOriginSpec.ResumeLayout(false);
            panelAgeSpec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericBoxAgeValue).EndInit();
            panelNameSpec.ResumeLayout(false);
            panelNameSpec.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBuyForm;
        private Panel panelSpec;
        private Button btnBuyForm;
        private Label labelHeaderBuyForm;
        private Panel panelAgeSpec;
        private Panel panelNameSpec;
        private Panel panelOriginSpec;
        private Label labelOriginHeader;
        private Label labelAgeHeader;
        private Label labelNameHeader;
        private NumericUpDown numericBoxAgeValue;
        private TextBox textBoxNameValue;
        private Panel panel1;
        private ComboBox comboBoxAnimalType;
        private Label label1;
        private ComboBox comboBoxOriginValue;
    }
}