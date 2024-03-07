using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{
    public class Animal
    {
        public Animal(AnimalSize size, Diet diet)
        {
            this.size = size;
            this.diet = diet;
        }

        public Animal() 
        { 
        
        }


        public bool CanAnimalBehave(List<Animal> animals, Animal animal)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].diet == Diet.Carnivore && (int)animals[i].size >= (int)animal.size)
                {
                    return false;
                }

                if (animal.diet == Diet.Carnivore && animals[i].size <= animal.size)
                {
                    return false;
                }
            }
            return true;
        }

        public AnimalSize size { get; set; }
        public Diet diet { get; set; }


        public override string ToString()
        {
            return size.ToString() + " " + diet.ToString();
        }
    }
}
