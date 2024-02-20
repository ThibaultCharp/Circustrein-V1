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

        Animal s_H = new Animal { Size = AnimalSize.Small, Diet = Diet.Herbivore };
        Animal m_H = new Animal { Size = AnimalSize.Medium, Diet = Diet.Herbivore};
        Animal b_H = new Animal { Size = AnimalSize.Big, Diet = Diet.Herbivore };
        Animal s_C = new Animal { Size = AnimalSize.Small, Diet = Diet.Carnivore };
        Animal m_C = new Animal { Size = AnimalSize.Medium, Diet = Diet.Carnivore };
        Animal b_C = new Animal { Size = AnimalSize.Big, Diet = Diet.Carnivore };

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
            listBox1.Items.Clear();
            foreach (Animal animal in list)
            {
                listBox1.Items.Add(animal.ToString());
            }
        }

        private void buttonSH_Click(object sender, EventArgs e)
        {
            wagon.AddAnimal(s_H);
            UpdateList();
        }

        private void buttonSC_Click(object sender, EventArgs e)
        {
            wagon.AddAnimal(s_C);
            UpdateList();
        }
    }
}
