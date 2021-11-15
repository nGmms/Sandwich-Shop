﻿using System;
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
        public static double Cost = 0.0;

        public MainForm()
        {
            InitializeComponent();
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
            sandwichIngredients.Add(new SandwichIngredients("Turkey", 0.25));
            sandwichIngredients.Add(new SandwichIngredients("Cheese", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Tomatoes", 0.20));
            sandwichIngredients.Add(new SandwichIngredients("Mayonnaise",0.20 ));
        }

        private void BreadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton breadRadioButton = sender as RadioButton;
            SandwichBread bread = breadRadioButton.Tag as SandwichBread;

            if (breadRadioButton.Checked)
            {
                MessageBox.Show(bread.Name);
            }
        }
    }
}
