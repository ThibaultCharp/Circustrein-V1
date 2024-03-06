using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{
    internal class SortingLogic
    {
        //Wagon wagon = new Wagon();

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
            Train train = new Train();
            Train trainAsc = new Train();
            Train trainDesc = new Train();

            trainAsc = Distribution(SortAnimalsSmallToBigDietImportant(animalsToAdd), trainAsc);
            trainDesc = Distribution(SortAnimalsBigToSmallSizeImportant(animalsToAdd), trainDesc);

            if (trainAsc.GetWagons().Count > trainDesc.GetWagons().Count)
            {
                train = trainDesc;
            }
            else
            {
                train = trainAsc;
            }

            return train;

        }

        private List<Animal> SortAnimalsSmallToBigDietImportant(List<Animal> animal)
        {
            //animals.Sort((a1, a2) => a2.size.CompareTo(a1.size));
            //animals.Sort((b1, b2) => b2.diet.CompareTo(b1.diet));
            return animal
            .OrderByDescending(a => a.diet)
            .ThenBy(a => (int)a.size)
            .ToList();

        }

        private List<Animal> SortAnimalsBigToSmallSizeImportant(List<Animal> animal)
        {
            //animals.Sort((a1, a2) => a1.size.CompareTo(a2.size));
            //animals.Sort((b1, b2) => b2.diet.CompareTo(b1.diet));

           return animal
            .OrderByDescending(a => a.diet)
            .ThenByDescending(a => (int)a.size)
            .ToList();

        }
    }
}
