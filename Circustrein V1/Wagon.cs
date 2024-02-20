using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{

    internal class Wagon
    {
        private List<Animal> animals;
        Train train = new Train();
        public Wagon()
        {
            animals = new List<Animal>();
        }

        public bool AddAnimal(Animal animal)
        {
            if (CanAddAnimal(animal))
            {
                animals.Add(animal);
                return true;
            }
            return false;
        }


        public bool CanAddAnimal(Animal animal)
        {
            int totalSize = animals.Sum(a => (int)a.Size);
            if (totalSize + (int)animal.Size <= 10)
            {
                if (animal.Diet == Diet.Carnivore && animals.Any(a => a.Size >= animal.Size))
                {
                    return false;
                }
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
