using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{

    public class Wagon
    {
        Animal animal = new Animal();

        private int maxCapacity = 10;
        private List<Animal> animals;

        public Wagon()
        {
            animals = new List<Animal>();
        }
                    
        public bool AddAnimalIfPossibleOtherwiseFalse(Animal animal)
        {
            if (CanAnimalFit(animal) && animal.CanAnimalBehave(animals, animal))
            {
                animals.Add(animal);
                return true;
            }
            return false;
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


        public List<Animal> GetAnimals()
        {
            return animals;
        } 
    }
}