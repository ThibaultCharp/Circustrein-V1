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
        
        private List<Wagon> wagons;

        public Train()
        {
            wagons = new List<Wagon>();
        }

        public void DistributeAnimal(Animal animal)
        {
            AddFirstWagon();
            PutAnimalsInWagon(animal);
        }

        private void AddFirstWagon()
        {
            if (wagons.Count == 0)
            {
                wagons.Add(new Wagon());
            }
        }

        private void PutAnimalsInWagon(Animal animal)
        {
            for(int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i].AddAnimalIfPossibleOtherwiseFalse(animal))
                {
                    return;
                }
                if (i == wagons.Count - 1)
                {
                    wagons.Add(new Wagon());
                    wagons[i].AddAnimalIfPossibleOtherwiseFalse(animal);
                }
            }
        }
        
        public List<Wagon> GetWagons()
        {
            return wagons;
        }
    }
}