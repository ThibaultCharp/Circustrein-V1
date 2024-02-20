using System;
using System.Collections.Generic;
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

        public void AddWagon(Wagon wagon)
        {
            wagons.Add(wagon);
        }

        public List<Wagon> GetWagons()
        {
            return wagons;
        }
    }
}
