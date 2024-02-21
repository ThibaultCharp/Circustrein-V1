using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{

    internal class Wagon
    {
        private int maxCapacity = 10;
        private List<Animal> animals;
        //Train train = new Train();
        Animal anymal = new Animal();   
        public Wagon()
        {
            animals = new List<Animal>();
        }
                    
        public bool AddAnimal(Animal animal)
        {
            if (CanAnimalFit(animal) && CanAnimalBehave(animal))
            {
                animals.Add(animal);
                return true;
            }
            return false;
        }

        public bool CanAnimalFit(Animal animal)
        {
            int totalSize = animals.Sum(a => (int)a.size);
            if (totalSize + (int)animal.size <= maxCapacity)
            {
                return true;
            }
            return false;
        }

        public bool CanAnimalBehave(Animal animal)
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


        public List<Animal> GetAnimals()
        {
            return animals;
        }
    }
}