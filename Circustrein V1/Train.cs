using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{
    internal class Train
    {
        Wagon wagon = new Wagon();

        private List<Wagon> wagons;
        private List<Animal> animals;

        public Train()
        {
            wagons = new List<Wagon>();
            animals = new List<Animal>();
        }

        public void DistributeAnimals(Animal animal)
        {
            AddFirstWagon();
            IsWagonNessesery(animal);
        }

        private void AddFirstWagon()
        {
            if (wagons.Count == 0)
            {
                wagons.Add(new Wagon());
            }
        }

        private bool IsWagonNessesery(Animal animal) 
        { 
            if(wagon.AddAnimal(animal) == true)
            {
                return false;
            }

            wagons.Add(new Wagon());
            return true;
        }

        public void PutAnimalsInWagon(Wagon wagon)
        {
            
        }
        
        public void ClearLists()
        {
            animals = new List<Animal>();
            wagons = new List<Wagon>();
        }
        
        public List<Wagon> GetWagons()
        {
            return wagons;
        }
    }
}