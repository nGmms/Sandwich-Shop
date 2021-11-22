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
      
        const string BreadsFile = "breads.json";
        const string IngredientsFile = "ingredients.json";

        public List<SandwichBread> Breads { get; set; }
        public List<SandwichIngredients> Ingredients { get; set; }
      

        public SettingsForm()
        {
            InitializeComponent();
            LoadBreads();
            LoadIngredients();

           
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
        private void SaveBreads()
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
            var jsonString = JsonConvert.SerializeObject(Breads);
            File.WriteAllText(BreadsFile, jsonString);
            MessageBox.Show("Successfully saved the Bread and the price.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IngredientSaveButton_Click(object sender, EventArgs e)
        {
            SaveBreads();
            
            MessageBox.Show("Successfully saved the Ingredients.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadBreads()
        {
            if (File.Exists(BreadsFile))
            {
                var jsonString = File.ReadAllText(BreadsFile);
                Breads = JsonConvert.DeserializeObject<List<SandwichBread>>(jsonString);
            }
            else
               // BreadSaveButton = new List<SandwichBread>();

            BreadDataGridView.DataSource = new BindingList<SandwichBread>(sandwichBread);
        }
        private void LoadIngredients()
        {
            if (File.Exists(IngredientsFile))
            {
                var jsonString = File.ReadAllText(IngredientsFile);
                Breads = JsonConvert.DeserializeObject<List<SandwichBread>>(jsonString);
            }
            else
               // IngredientSaveButton = new List<SandwichIngredients>();

            BreadDataGridView.DataSource = new BindingList<SandwichIngredients>(sandwichIngredients);
        }

    }
}
