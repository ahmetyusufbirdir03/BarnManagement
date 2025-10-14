namespace FarmShoppingForm
{
    partial class FarmForm
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
            panelFarmHeader = new Panel();
            labelFarmHeader = new Label();
            flowPanelFarm = new FlowLayoutPanel();
            panelFarmHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelFarmHeader
            // 
            panelFarmHeader.BackColor = Color.FromArgb(192, 192, 255);
            panelFarmHeader.Controls.Add(labelFarmHeader);
            panelFarmHeader.Dock = DockStyle.Top;
            panelFarmHeader.Location = new Point(0, 0);
            panelFarmHeader.Name = "panelFarmHeader";
            panelFarmHeader.Padding = new Padding(10);
            panelFarmHeader.Size = new Size(1388, 120);
            panelFarmHeader.TabIndex = 0;
            // 
            // labelFarmHeader
            // 
            labelFarmHeader.Dock = DockStyle.Fill;
            labelFarmHeader.Font = new Font("Comic Sans MS", 28.8000011F, FontStyle.Bold);
            labelFarmHeader.Location = new Point(10, 10);
            labelFarmHeader.Name = "labelFarmHeader";
            labelFarmHeader.RightToLeft = RightToLeft.No;
            labelFarmHeader.Size = new Size(1368, 100);
            labelFarmHeader.TabIndex = 0;
            labelFarmHeader.Text = "FARM";
            labelFarmHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowPanelFarm
            // 
            flowPanelFarm.AutoScroll = true;
            flowPanelFarm.BackColor = Color.FromArgb(192, 192, 255);
            flowPanelFarm.Dock = DockStyle.Fill;
            flowPanelFarm.Location = new Point(0, 120);
            flowPanelFarm.Margin = new Padding(0);
            flowPanelFarm.Name = "flowPanelFarm";
            flowPanelFarm.Padding = new Padding(50, 0, 20, 20);
            flowPanelFarm.Size = new Size(1388, 682);
            flowPanelFarm.TabIndex = 1;
            // 
            // FarmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1388, 802);
            Controls.Add(flowPanelFarm);
            Controls.Add(panelFarmHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FarmForm";
            Text = "FarmForm";
            Load += FarmForm_Load;
            panelFarmHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFarmHeader;
        private Label labelFarmHeader;
        private FlowLayoutPanel flowPanelFarm;
    }
}