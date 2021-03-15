using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Interfaces;
using static WindowsFormsApp1.Utils.Utils;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly BindingList<string> Categories = new BindingList<string>();
        private static readonly BindingList<Toy> Toys = new BindingList<Toy>();
        private static Toy SelectedToy;
        private static string SelectedCategory;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnInit(object sender, EventArgs e)
        {
            foreach (ToyCategory category in (ToyCategory[])Enum.GetValues(typeof(ToyCategory)))
            {
                Categories.Add(category.ToString());
            }

            this.toysListBox.DataSource = Toys;
            this.categoriesListBox.DataSource = Categories;
        }

        private void OnSelectedCategoryChange(object sender, EventArgs e)
        {
            SelectedCategory = GetSelectedCategory();
        }

        private void OnSelectedToyChange(object sender, EventArgs e)
        {
            SelectedToy = GetSelectedToy();
            SelectedCategory = GetSelectedToyCategory();

            if (SelectedToy == null)
            {
                return;
            }

            RemoveAllBindings();
            AddBindingsForCategory(SelectedCategory);

            HideAllControls();
            ShowSelectedToyControls(SelectedToy);

            AdjustSliders();
        }

        private void OnToyAddClick(object sender, EventArgs e)
        {
            if (SelectedCategory == null)
            {
                return;
            }

            Toy toy = ToyFactory.Create(SelectedCategory);
            int toyIndex = GetNextAvailableToyIndex(SelectedCategory);
            string toyName = $"{SelectedCategory}{toyIndex}";

            toy.Id = toyIndex;
            toy.Name = toyName;

            Toys.Add(toy);
        }

        private void OnToyRemoveClick(object sender, EventArgs e)
        {
            if (SelectedToy == null)
            {
                return;
            }

            Toys.Remove(SelectedToy);
            HideAllControls();
        }

        private int GetNextAvailableToyIndex(string selectedCategory)
        {
            IEnumerable<Toy> toysFromSelectedCategory =
                Toys.Where(toy => GetClass(toy) == selectedCategory);
            int maxIndex = 0;
            if (toysFromSelectedCategory.Count() > 0)
            {
                maxIndex = toysFromSelectedCategory.Max(Toy => Toy.Id);
            }
            return maxIndex + 1;
        }

        private void ShowSelectedToyControls(Toy selectedToy)
        {
            List<string> implementedInterfaces = GetImplementedInterfaces(selectedToy);
            implementedInterfaces.ForEach(i =>
            {
                ToyInterface toyInterfaceEnum = (ToyInterface)Enum.Parse(typeof(ToyInterface), i);
                switch (toyInterfaceEnum)
                {
                    case ToyInterface.IAccelerate:
                        speedGroupBox.Visible = true;
                        break;
                    case ToyInterface.IRise:
                        heightGroupBox.Visible = true;
                        break;
                    case ToyInterface.IDive:
                        depthGroupBox.Visible = true;
                        break;
                    default:
                        break;
                }
            });
        }

        private void HideAllControls()
        {
            speedGroupBox.Visible = false;
            depthGroupBox.Visible = false;
            heightGroupBox.Visible = false;
        }

        private void AdjustSliders()
        {
            if (this.speedSlider.Visible)
            {
                this.speedSlider.Value = ((IAccelerate)SelectedToy).Speed;
            }
            if (this.depthSlider.Visible)
            {
                this.depthSlider.Value = ((IDive)SelectedToy).Depth;
            }
            if (this.heightSlider.Visible)
            {
                this.heightSlider.Value = ((IRise)SelectedToy).Height;
            }
        }

        private void AddBindingsForCategory(string selectedCategory)
        {
            ToyCategory toyCategoryEnum = (ToyCategory)Enum.Parse(typeof(ToyCategory), selectedCategory);
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
        }

        private void RemoveAllBindings()
        {
            this.speedValue.DataBindings.Clear();
            this.heightValue.DataBindings.Clear();
            this.depthValue.DataBindings.Clear();
        }

        private Toy GetSelectedToy()
        {
            return Toys.FirstOrDefault(x => x.Name == toysListBox.GetItemText(toysListBox.SelectedItem));
        }

        private string GetSelectedCategory()
        {
            return categoriesListBox.GetItemText(categoriesListBox.SelectedItem);
        }

        private string GetSelectedToyCategory()
        {
            if (SelectedToy == null)
            {
                return null;
            }
            return GetClass(SelectedToy);
        }

        private void OnSpeedSliderValueChange(object sender, EventArgs e)
        {
            ((IAccelerate)SelectedToy).Accelerate(this.speedSlider.Value);
            this.speedValue.Text = ((IAccelerate)SelectedToy).Speed.ToString();
        }

        private void OnHeightSliderValueChange(object sender, EventArgs e)
        {
            ((IRise)SelectedToy).Rise(this.heightSlider.Value);
            this.heightValue.Text = ((IRise)SelectedToy).Height.ToString();
        }

        private void OnDepthSliderValueChange(object sender, EventArgs e)
        {
            ((IDive)SelectedToy).Dive(this.depthSlider.Value);
            this.depthValue.Text = ((IDive)SelectedToy).Depth.ToString();
        }
    }
}
