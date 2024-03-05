using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{

    internal class Wagon
    {
        private int maxCapacity = 10;
        private List<Animal> animals;

        public Wagon()
        {
            animals = new List<Animal>();
        }
                    
        public bool AddAnimalIfPossibleOtherwiseFalse(Animal animal)
        {
            if (CanAnimalFit(animal) && CanAnimalBehave(animal))
            {
                animals.Add(animal);
                return true;
            }
            return false;
        }

        public void AddAnimalToList(Animal animal)
        {
            animals.Add(animal);
        }

        private bool CanAnimalFit(Animal animal)
        {
            int totalSize = animals.Sum(a => (int)a.size);
            if (totalSize + (int)animal.size <= maxCapacity)
            {
                return true;
            }
            return false;
        }

        private bool CanAnimalBehave(Animal animal)
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

        public void SortAnimalsBigToSmallDietImportant()
        {
            animals.Sort((a1, a2) => a2.size.CompareTo(a1.size));
            animals.Sort((b1, b2) => b2.diet.CompareTo(b1.diet));
        }

        public void SortAnimalsBigToSmallSizeImportant()
        {
            animals.Sort((b1, b2) => b2.diet.CompareTo(b1.diet));
            animals.Sort((a1, a2) => a2.size.CompareTo(a1.size));
        }
    }
}