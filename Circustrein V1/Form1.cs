using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein_V1
{
    
    public partial class Form1 : Form
    {

        Train train;
        SortingLogic sortingLogic = new SortingLogic();
        List<Animal> animals = new List<Animal>();      

        int WagonCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSH_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            UpdateList();
        }

        private void buttonMH_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(AnimalSize.Medium, Diet.Herbivore));
            UpdateList();
        }

        private void buttonLH_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            UpdateList();
        }

        private void buttonSC_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            UpdateList();
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(AnimalSize.Medium, Diet.Carnivore));
            UpdateList();
        }

        private void buttonLC_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(AnimalSize.Large, Diet.Carnivore));
            UpdateList();
        }

        private void listBoxWagon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wagon selectedWagon = listBoxWagon.SelectedItem as Wagon;
            listBoxAnimalsInWagon.Items.Clear();
            foreach (Animal animal in selectedWagon.GetAnimals())
            {
                listBoxAnimalsInWagon.Items.Add(animal);
            }
        }

        void UpdateList()
        {
            listBoxAnimals.Items.Clear();
            foreach (Animal animal in animals)
            {
                listBoxAnimals.Items.Add(animal);
            }
        }
        void DisplayWagons()
        {
            List<Wagon> WagonList = train.GetWagons();
            listBoxWagon.Items.Clear();
            foreach (Wagon wagon in WagonList)
            {
                listBoxWagon.Items.Add(wagon);
                WagonCount++;
                lblWagonCount.Text = WagonCount.ToString();
            }
        }

        private void buttonDistibute_Click(object sender, EventArgs e)
        {
            train = sortingLogic.SortAndDistribute(animals);
            DisplayWagons();   
        }
    }
}