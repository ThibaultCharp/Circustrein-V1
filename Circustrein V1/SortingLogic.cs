using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{
    public class SortingLogic
    {

        Train Distribution(List<Animal> animals, Train train)
        {         
            foreach (Animal animal in animals)
            {
                train.DistributeAnimal(animal);
            }
            return train;
        }

        public Train SortAndDistribute(List<Animal> animalsToAdd)
        {
            Train trainAsc = new Train();
            Train trainDesc = new Train();

            trainAsc = Distribution(SortAnimalsSmallToBig(animalsToAdd), trainAsc);
            trainDesc = Distribution(SortAnimalsBigToSmall(animalsToAdd), trainDesc);

            if (trainAsc.GetWagons().Count > trainDesc.GetWagons().Count)
            {
                return trainDesc;
            }
            else
            {
                return trainAsc;
            }
        }

        private List<Animal> SortAnimalsSmallToBig(List<Animal> animal)
        {
            return animal
            .OrderByDescending(a => a.diet)
            .ThenBy(a => (int)a.size)
            .ToList();

        }

        private List<Animal> SortAnimalsBigToSmall(List<Animal> animal)
        {
            return animal
            .OrderByDescending(a => a.diet)
            .ThenByDescending(a => (int)a.size)
            .ToList();

        }
    }
}
