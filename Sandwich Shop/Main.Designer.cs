
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
            this.OrderButton = new System.Windows.Forms.Button();
            this.SandwichOrderLabel = new System.Windows.Forms.Label();
            this.BreadFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IngredientsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BreadFlowLayoutPanel.SuspendLayout();
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
            this.SandwichListBox.Size = new System.Drawing.Size(157, 264);
            this.SandwichListBox.TabIndex = 2;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(197, 381);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 13);
            this.PriceLabel.TabIndex = 3;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(32, 371);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(75, 23);
            this.OrderButton.TabIndex = 4;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IngredientsFlowLayoutPanel);
            this.Controls.Add(this.BreadFlowLayoutPanel);
            this.Controls.Add(this.SandwichOrderLabel);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SandwichListBox);
            this.Controls.Add(this.IngredientsGroupBox);
            this.Name = "MainForm";
            this.Text = "Sandwich Order";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BreadFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BreadGroupBox;
        private System.Windows.Forms.GroupBox IngredientsGroupBox;
        private System.Windows.Forms.ListBox SandwichListBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label SandwichOrderLabel;
        private System.Windows.Forms.FlowLayoutPanel BreadFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel IngredientsFlowLayoutPanel;
    }
}

