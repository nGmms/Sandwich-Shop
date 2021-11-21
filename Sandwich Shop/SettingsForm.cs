using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Sandwich_Shop
{
    public partial class SettingsForm : Form
    {
        List<SandwichBread> sandwichBread = new List<SandwichBread>();
        List<SandwichIngredients> sandwichIngredients = new List<SandwichIngredients>();
        const string sandiwchBreadsFile = "SandwichBreads.json"; //needed to save size

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            sandwichBread.Add(new SandwichBread("White Bread", 2, 3));
            sandwichBread.Add(new SandwichBread("Whole Grain Braid", 3, 3));
            sandwichBread.Add(new SandwichBread("Baguette", 4, 4));

            BreadDataGridView.DataSource = new BindingList<SandwichBread>(sandwichBread);

            sandwichIngredients.Add(new SandwichIngredients("Lettuce", 0.10));
            sandwichIngredients.Add(new SandwichIngredients("Ham", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Cheese", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Tomatoes", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Mayonnaise", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Turkey", 0.25));

            IngredientDataGridView.DataSource = new BindingList<SandwichIngredients>(sandwichIngredients);
        }
        private void SaveSizes()
        {
            var serializedSize = JsonConvert.SerializeObject(sandwichBread);
            //File.WriteAllText(SandwichBreadFile, serializedSize, Encoding.UTF8);
        }
        private void SaveIngredients()
        {
            var serializedIngredient = JsonConvert.SerializeObject(sandwichIngredients);
        }

        private void BreadSaveButton_Click(object sender, EventArgs e)
        {
            SaveSizes();
            MessageBox.Show("Successfully saved Bread", "Success", MessageBoxButtons.OK);
        }

        private void IngredientSaveButton_Click(object sender, EventArgs e)
        {
            SaveSizes();
            MessageBox.Show("Successfully saved Ingredients", "Success", MessageBoxButtons.OK);
        }
        private void LoadSizes()
        {
            BreadDataGridView.DataSource = new BindingList<SandwichBread>(sandwichBread);
        }

    }
}
