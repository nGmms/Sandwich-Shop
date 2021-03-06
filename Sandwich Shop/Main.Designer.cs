
namespace Sandwich_Shop
{
    partial class MainForm
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
            this.BreadGroupBox = new System.Windows.Forms.GroupBox();
            this.IngredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.SandwichListBox = new System.Windows.Forms.ListBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SandwichOrderLabel = new System.Windows.Forms.Label();
            this.BreadFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IngredientsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PriceLabelBox = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BreadFlowLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BreadGroupBox
            // 
            this.BreadGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BreadGroupBox.Name = "BreadGroupBox";
            this.BreadGroupBox.Size = new System.Drawing.Size(268, 119);
            this.BreadGroupBox.TabIndex = 0;
            this.BreadGroupBox.TabStop = false;
            // 
            // IngredientsGroupBox
            // 
            this.IngredientsGroupBox.Location = new System.Drawing.Point(39, 244);
            this.IngredientsGroupBox.Name = "IngredientsGroupBox";
            this.IngredientsGroupBox.Size = new System.Drawing.Size(186, 100);
            this.IngredientsGroupBox.TabIndex = 1;
            this.IngredientsGroupBox.TabStop = false;
            // 
            // SandwichListBox
            // 
            this.SandwichListBox.FormattingEnabled = true;
            this.SandwichListBox.Location = new System.Drawing.Point(327, 106);
            this.SandwichListBox.Name = "SandwichListBox";
            this.SandwichListBox.Size = new System.Drawing.Size(300, 264);
            this.SandwichListBox.TabIndex = 2;
            this.SandwichListBox.SelectedIndexChanged += new System.EventHandler(this.SandwichListBox_SelectedIndexChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(197, 381);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 13);
            this.PriceLabel.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(32, 371);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SandwichOrderLabel
            // 
            this.SandwichOrderLabel.AutoSize = true;
            this.SandwichOrderLabel.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SandwichOrderLabel.Location = new System.Drawing.Point(31, 33);
            this.SandwichOrderLabel.Name = "SandwichOrderLabel";
            this.SandwichOrderLabel.Size = new System.Drawing.Size(237, 43);
            this.SandwichOrderLabel.TabIndex = 5;
            this.SandwichOrderLabel.Text = "Sandwich Order";
            // 
            // BreadFlowLayoutPanel
            // 
            this.BreadFlowLayoutPanel.Controls.Add(this.BreadGroupBox);
            this.BreadFlowLayoutPanel.Location = new System.Drawing.Point(32, 110);
            this.BreadFlowLayoutPanel.Name = "BreadFlowLayoutPanel";
            this.BreadFlowLayoutPanel.Size = new System.Drawing.Size(271, 128);
            this.BreadFlowLayoutPanel.TabIndex = 6;
            // 
            // IngredientsFlowLayoutPanel
            // 
            this.IngredientsFlowLayoutPanel.Location = new System.Drawing.Point(35, 244);
            this.IngredientsFlowLayoutPanel.Name = "IngredientsFlowLayoutPanel";
            this.IngredientsFlowLayoutPanel.Size = new System.Drawing.Size(268, 121);
            this.IngredientsFlowLayoutPanel.TabIndex = 7;
            // 
            // PriceLabelBox
            // 
            this.PriceLabelBox.AutoSize = true;
            this.PriceLabelBox.Location = new System.Drawing.Point(324, 381);
            this.PriceLabelBox.Name = "PriceLabelBox";
            this.PriceLabelBox.Size = new System.Drawing.Size(35, 13);
            this.PriceLabelBox.TabIndex = 8;
            this.PriceLabelBox.Text = "label1";
            this.PriceLabelBox.Click += new System.EventHandler(this.PriceLabelBox_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(365, 376);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 9;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabelBox);
            this.Controls.Add(this.IngredientsFlowLayoutPanel);
            this.Controls.Add(this.BreadFlowLayoutPanel);
            this.Controls.Add(this.SandwichOrderLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SandwichListBox);
            this.Controls.Add(this.IngredientsGroupBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sandwich Order";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BreadFlowLayoutPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BreadGroupBox;
        private System.Windows.Forms.GroupBox IngredientsGroupBox;
        private System.Windows.Forms.ListBox SandwichListBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SandwichOrderLabel;
        private System.Windows.Forms.FlowLayoutPanel BreadFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel IngredientsFlowLayoutPanel;
        private System.Windows.Forms.Label PriceLabelBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}

