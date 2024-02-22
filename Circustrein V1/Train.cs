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
        private List<Animal> animals;

        public Train()
        {
            wagons = new List<Wagon>();
            animals = new List<Animal>();
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