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
        List<SandwichBread> sandwichBread = new List<SandwichBread>();
        List<SandwichIngredients> sandwichIngredients = new List<SandwichIngredients>();
        
       

        public MainForm()
        {
            InitializeComponent();
            PriceTextBox.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            sandwichBread.Add(new SandwichBread("White Bread", 2, 3));
            sandwichBread.Add(new SandwichBread("Whole Grain Braid", 3, 3));
            sandwichBread.Add(new SandwichBread("Baguette", 4, 4));

            BreadFlowLayoutPanel.Controls.Clear();

            foreach(var bread in sandwichBread)
            {
                RadioButton BreadRadioButton = new RadioButton();
                BreadRadioButton.Text = bread.Name;
                BreadRadioButton.Tag = bread;
                BreadRadioButton.AutoSize = true;
                BreadRadioButton.CheckedChanged += BreadRadioButton_CheckedChanged;
                BreadFlowLayoutPanel.Controls.Add(BreadRadioButton);
            }


            sandwichIngredients.Add(new SandwichIngredients("Lettuce", 0.10));
            sandwichIngredients.Add(new SandwichIngredients("Ham",0.20));
            sandwichIngredients.Add(new SandwichIngredients("Cheese", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Tomatoes", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Mayonnaise",0.20 ));
            sandwichIngredients.Add(new SandwichIngredients("Turkey", 0.25));

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

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            PriceDisplayer();
        }

        private void PriceLabelBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
