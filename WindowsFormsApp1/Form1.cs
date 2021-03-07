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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            // Add group box: Speed
            // Add group box: Height
            // Add group box: Depth
            // Add group box: Properties (visible if toy is selected)

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Toy selectedToy = toysListBox.SelectedItem as Toy;

            if (selectedToy == null)
            {
                return;
            }

            Toys.Remove(selectedToy);
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
    }
}
