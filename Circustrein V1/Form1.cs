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
        Train train = new Train();
        Wagon wagon = new Wagon();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void UpdateList()
        {
            List<Animal> list = wagon.GetAnimals();
            listBoxAnimals.Items.Clear();
            foreach (Animal animal in list)
            {
                listBoxAnimals.Items.Add(animal);
            }
        }

        void DisplayDistribution()
        {
            List<Animal> AnimalList = wagon.GetAnimals();
            foreach (Animal animal in AnimalList)
            {
                train.DistributeAnimal(animal);
                //listBoxWagon.Items.Add(animal);
            }

            List<Wagon> WagonList = train.GetWagons();
            listBoxWagon.Items.Clear();
            foreach (Wagon wagon in WagonList)
            {
                listBoxWagon.Items.Add(wagon);
            }
        }

        private void buttonSH_Click(object sender, EventArgs e)
        {

            wagon.AddAnimalToList(new Animal(AnimalSize.Small, Diet.Herbivore));

            UpdateList();
        }

        private void buttonMH_Click(object sender, EventArgs e)
        {
            wagon.AddAnimalToList(new Animal(AnimalSize.Medium, Diet.Herbivore));
            UpdateList();
        }

        private void buttonLH_Click(object sender, EventArgs e)
        {
            wagon.AddAnimalToList(new Animal(AnimalSize.Large, Diet.Herbivore));
            UpdateList();
        }

        private void buttonSC_Click(object sender, EventArgs e)
        {
            wagon.AddAnimalToList(new Animal(AnimalSize.Small, Diet.Carnivore));
            UpdateList();
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            wagon.AddAnimalToList(new Animal(AnimalSize.Medium, Diet.Carnivore));
            UpdateList();
        }

        private void buttonLC_Click(object sender, EventArgs e)
        {
            wagon.AddAnimalToList(new Animal(AnimalSize.Large, Diet.Carnivore));
            UpdateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wagon.SortAnimalsBigToSmall();
            DisplayDistribution();
        }
    }
}