
namespace Sandwich_Shop
{
    partial class SettingsForm
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
            this.BreadSaveButton = new System.Windows.Forms.Button();
            this.BreadResetButton = new System.Windows.Forms.Button();
            this.IngredientSaveButton = new System.Windows.Forms.Button();
            this.IngredientResetButton = new System.Windows.Forms.Button();
            this.BreadDataGridView = new System.Windows.Forms.DataGridView();
            this.IngredientDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BreadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BreadSaveButton
            // 
            this.BreadSaveButton.Location = new System.Drawing.Point(55, 253);
            this.BreadSaveButton.Name = "BreadSaveButton";
            this.BreadSaveButton.Size = new System.Drawing.Size(75, 23);
            this.BreadSaveButton.TabIndex = 0;
            this.BreadSaveButton.Text = "Save";
            this.BreadSaveButton.UseVisualStyleBackColor = true;
            this.BreadSaveButton.Click += new System.EventHandler(this.BreadSaveButton_Click);
            // 
            // BreadResetButton
            // 
            this.BreadResetButton.Location = new System.Drawing.Point(220, 253);
            this.BreadResetButton.Name = "BreadResetButton";
            this.BreadResetButton.Size = new System.Drawing.Size(75, 23);
            this.BreadResetButton.TabIndex = 1;
            this.BreadResetButton.Text = "Reset";
            this.BreadResetButton.UseVisualStyleBackColor = true;
            // 
            // IngredientSaveButton
            // 
            this.IngredientSaveButton.Location = new System.Drawing.Point(456, 253);
            this.IngredientSaveButton.Name = "IngredientSaveButton";
            this.IngredientSaveButton.Size = new System.Drawing.Size(75, 23);
            this.IngredientSaveButton.TabIndex = 2;
            this.IngredientSaveButton.Text = "Save";
            this.IngredientSaveButton.UseVisualStyleBackColor = true;
            this.IngredientSaveButton.Click += new System.EventHandler(this.IngredientSaveButton_Click);
            // 
            // IngredientResetButton
            // 
            this.IngredientResetButton.Location = new System.Drawing.Point(621, 253);
            this.IngredientResetButton.Name = "IngredientResetButton";
            this.IngredientResetButton.Size = new System.Drawing.Size(75, 23);
            this.IngredientResetButton.TabIndex = 3;
            this.IngredientResetButton.Text = "Reset";
            this.IngredientResetButton.UseVisualStyleBackColor = true;
            // 
            // BreadDataGridView
            // 
            this.BreadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BreadDataGridView.Location = new System.Drawing.Point(55, 85);
            this.BreadDataGridView.Name = "BreadDataGridView";
            this.BreadDataGridView.Size = new System.Drawing.Size(240, 150);
            this.BreadDataGridView.TabIndex = 4;
            // 
            // IngredientDataGridView
            // 
            this.IngredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientDataGridView.Location = new System.Drawing.Point(456, 85);
            this.IngredientDataGridView.Name = "IngredientDataGridView";
            this.IngredientDataGridView.Size = new System.Drawing.Size(240, 150);
            this.IngredientDataGridView.TabIndex = 5;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 346);
            this.Controls.Add(this.IngredientDataGridView);
            this.Controls.Add(this.BreadDataGridView);
            this.Controls.Add(this.IngredientResetButton);
            this.Controls.Add(this.IngredientSaveButton);
            this.Controls.Add(this.BreadResetButton);
            this.Controls.Add(this.BreadSaveButton);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BreadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BreadSaveButton;
        private System.Windows.Forms.Button BreadResetButton;
        private System.Windows.Forms.Button IngredientSaveButton;
        private System.Windows.Forms.Button IngredientResetButton;
        private System.Windows.Forms.DataGridView BreadDataGridView;
        private System.Windows.Forms.DataGridView IngredientDataGridView;
    }
}