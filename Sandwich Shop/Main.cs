using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandwich_Shop
{
    public partial class MainForm : Form
    {
        //Creating the lists from the classes
        List<SandwichBread> sandwichBread = new List<SandwichBread>();
        List<SandwichIngredients> sandwichIngredients = new List<SandwichIngredients>();
        


        public MainForm()
        {
            
            InitializeComponent();
            PriceTextBox.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Creating each bread type, cost and max ingredients
            sandwichBread.Add(new SandwichBread("White Bread", 2, 3));
            sandwichBread.Add(new SandwichBread("Whole Grain Braid", 3, 3));
            sandwichBread.Add(new SandwichBread("Baguette", 4, 4));

            BreadFlowLayoutPanel.Controls.Clear();

            //We generate the radio buttons inside the flow layout panel
            foreach(var bread in sandwichBread)
            {
                RadioButton BreadRadioButton = new RadioButton();
                BreadRadioButton.Text = bread.Name;
                BreadRadioButton.Tag = bread;
                BreadRadioButton.AutoSize = true;
                BreadRadioButton.CheckedChanged += BreadRadioButton_CheckedChanged;
                BreadFlowLayoutPanel.Controls.Add(BreadRadioButton);
            }

            //Creating each ingredient and cost 
            sandwichIngredients.Add(new SandwichIngredients("Lettuce", 0.10));
            sandwichIngredients.Add(new SandwichIngredients("Ham",0.20));
            sandwichIngredients.Add(new SandwichIngredients("Cheese", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Tomatoes", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Mayonnaise",0.20 ));
            sandwichIngredients.Add(new SandwichIngredients("Turkey", 0.25));

            //We generate the check boxes inside the flow layout panel
            foreach (var ingredients in sandwichIngredients)
            {
                CheckBox IngredientsCheckBox = new CheckBox();
                IngredientsCheckBox.Text = ingredients.Name;
                IngredientsCheckBox.Tag = ingredients;
                IngredientsCheckBox.AutoSize = true;
                IngredientsCheckBox.CheckedChanged += IngredientsCheckBox_CheckedChanged;
                IngredientsFlowLayoutPanel.Controls.Add(IngredientsCheckBox);
            }
        }

        private void IngredientsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox ingredientCheckBox = sender as CheckBox;
            SandwichIngredients ingredients = ingredientCheckBox.Tag as SandwichIngredients;

            //If ingredient is checked we display the price without clicking the order button
            if (ingredientCheckBox.Checked)
            {
                PriceDisplayer();
            }
        }

        private void BreadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton breadRadioButton = sender as RadioButton;
            SandwichBread bread = breadRadioButton.Tag as SandwichBread;

            if (breadRadioButton.Checked)
            {
                PriceDisplayer();
            }
        }
      
        private void PriceDisplayer()
        {

            double price = 0;
            
            foreach (RadioButton breadRadioButton in BreadFlowLayoutPanel.Controls)
            {
                if (breadRadioButton.Checked)
                {
                  
                  SandwichBread sandwichBread = breadRadioButton.Tag as SandwichBread;
                  price += sandwichBread.Price;
                    
                   
                }
            }

            
            foreach (CheckBox ingredientsCheckBox in IngredientsFlowLayoutPanel.Controls)
            {
                if (ingredientsCheckBox.Checked)
                {

                    SandwichIngredients sandwichIngredients = ingredientsCheckBox.Tag as SandwichIngredients;
                    price += sandwichIngredients.Price;
                    

                }

            }
            PriceTextBox.Text = "$" + price.ToString();
            



        }

        private Sandwich GetSandwich()
        {
            Sandwich sandwich = new Sandwich();
            foreach(RadioButton entry in BreadFlowLayoutPanel.Controls)
            {
                if (entry.Checked)
                {
                    sandwich.Bread = entry.Tag as SandwichBread;
                }
            }

            //Don't continue if no bread is selected
            if (sandwich.Bread == null)
                return null;

            foreach(CheckBox entry in IngredientsFlowLayoutPanel.Controls)
            {
                if (entry.Checked)
                {
                    var ingredient = entry.Tag as SandwichIngredients;
                    sandwich.Ingredients.Add(ingredient);
                }
            }
            
            return sandwich;

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            PriceDisplayer();
        }

        private void PriceLabelBox_Click(object sender, EventArgs e)
        {
            
        }

        private void SandwichListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            SandwichListBox.Items.Add(GetSandwich());

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutUsForm = new AboutScreen();
            aboutUsForm.ShowDialog();
        }

        //Delivery time
        /*private void maskedDeliveryTimeTextBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            var deliveryTime = sender as MaskedTextBox;

            DateTime now = DateTime.Now; //Current time
            DateTime delTime = DateTime.Parse(deliveryTime.Text);

            if (delTime <= now)
            {

                MessageBox.Show($"Invalid time {delTime.ToShortTimeString()} (Past time)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult r1 = MessageBox.Show($"The total for your pizza is ${Cost} (to be delivered at {delTime}) are you sure you want to order?", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r1 == DialogResult.Yes) { MessageBox.Show($"The order is succesful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                if (r1 == DialogResult.No) { MessageBox.Show($"The order is cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        
            }
        
        }
        */
    }
}
