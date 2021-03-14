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
        private static Toy SelectedToy;
        private static string SelectedCategory;

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

            SelectedCategory = getSelectedCategory();
            SelectedToy = getSelectedToy();

            this.toysListBox.DataSource = Toys;
            this.categoriesListBox.DataSource = Categories;
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCategory = getSelectedCategory();
        }

        private void toysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedToy = getSelectedToy();
            SelectedCategory = getSelectedToyCategory();

            if (SelectedToy == null)
            {
                return;
            }

            ToyCategory toyCategoryEnum = (ToyCategory)Enum.Parse(typeof(ToyCategory), SelectedCategory);

            resetBindings();

            switch (toyCategoryEnum)
            {
                case ToyCategory.Car:
                    this.speedValue.DataBindings.Add("Text", SelectedToy, "Speed");
                    break;
                case ToyCategory.Plane:
                    this.speedValue.DataBindings.Add("Text", SelectedToy, "Speed");
                    this.heightValue.DataBindings.Add("Text", SelectedToy, "Height");
                    break;
                case ToyCategory.Submarine:
                    this.speedValue.DataBindings.Add("Text", SelectedToy, "Speed");
                    this.depthValue.DataBindings.Add("Text", SelectedToy, "Depth");
                    break;
            }

            resetControls();
            showControls(SelectedCategory);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (SelectedCategory == null)
            {
                return;
            }

            Toy toy = ToyFactory.Create(SelectedCategory);
            int toyIndex = getToyIndex(SelectedCategory);
            string toyName = $"{SelectedCategory}{toyIndex}";

            toy.Id = toyIndex;
            toy.Name = toyName;

            Toys.Add(toy);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (SelectedToy == null)
            {
                return;
            }

            Toys.Remove(SelectedToy);
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

        private void resetBindings()
        {
            this.speedValue.DataBindings.Clear();
            this.heightValue.DataBindings.Clear();
            this.depthValue.DataBindings.Clear();
        }

        private Toy getSelectedToy()
        {
            return Toys.FirstOrDefault(x => x.Name == toysListBox.GetItemText(toysListBox.SelectedItem));
        }

        private string getSelectedCategory()
        {
            return categoriesListBox.GetItemText(categoriesListBox.SelectedItem);
        }

        private string getSelectedToyCategory()
        {
            if (SelectedToy == null)
            {
                return null;
            }
            return SelectedToy.GetType().ToString().Split('.').Last();
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
