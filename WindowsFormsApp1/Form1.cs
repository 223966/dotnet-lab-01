using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static BindingList<string> Categories = new BindingList<string>();
        private static BindingList<Toy> Toys = new BindingList<Toy>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (ToyCategory category in (ToyCategory[])Enum.GetValues(typeof(ToyCategory)))
            {
                Categories.Add(category.ToString());
            }
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toysListBox.SelectedItem == null)
            {
                return;
            }

            resetControls();
            string selectedCategory = toysListBox.SelectedItem.ToString().Split('.').Last();
            showControls(selectedCategory);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            object selectedCategory = categoriesListBox.SelectedItem;

            if (selectedCategory == null)
            {
                return;
            }

            Toy toy = ToyFactory.Create(selectedCategory.ToString());
            int toyIndex = getToyIndex(selectedCategory.ToString());
            string toyName = $"{selectedCategory}{toyIndex}";

            toy.Id = toyIndex;
            toy.Name = toyName;

            Toys.Add(toy);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Toy selectedToy = toysListBox.SelectedItem as Toy;

            if (selectedToy == null)
            {
                return;
            }

            Toys.Remove(selectedToy);
            resetControls();
        }

        private int getToyIndex(string selectedCategory)
        {
            IEnumerable<Toy> toysFromSelectedCategory = Toys.Where(toy => toy.GetType().ToString().Split('.').Last() == selectedCategory);
            int maxIndex = 0;
            if (toysFromSelectedCategory.Count() > 0)
            {
                maxIndex = toysFromSelectedCategory.Max(Toy => Toy.Id);
            }
            return maxIndex + 1;
        }

        private void showControls(string selectedCategory)
        {
            ToyCategory toyCategoryEnum = (ToyCategory)Enum.Parse(typeof(ToyCategory), selectedCategory);
            switch (toyCategoryEnum)
            {
                case ToyCategory.Car:
                    speedGroupBox.Visible = true;
                    break;
                case ToyCategory.Plane:
                    speedGroupBox.Visible = true;
                    heightGroupBox.Visible = true;
                    break;
                case ToyCategory.Submarine:
                    speedGroupBox.Visible = true;
                    depthGroupBox.Visible = true;
                    break;
            }
        }

        private void resetControls()
        {
            speedGroupBox.Visible = false;
            depthGroupBox.Visible = false;
            heightGroupBox.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void depthValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
