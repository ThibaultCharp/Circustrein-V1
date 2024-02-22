using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{
    internal class Animal
    {
        public AnimalSize size { get; set; }
        public Diet diet { get; set; }


        public override string ToString()
        {
            if (size == AnimalSize.Small && diet == Diet.Herbivore)
                return "Small Herbivore";
            else if (size == AnimalSize.Medium && diet == Diet.Herbivore)
                return "Medium Herbivore";
            else if (size == AnimalSize.Large && diet == Diet.Herbivore)
                return "Large Herbivore";
            else if (size == AnimalSize.Small && diet == Diet.Carnivore)
                return "Small Carnivore";
            else if (size == AnimalSize.Medium && diet == Diet.Carnivore)
                return "Medium Carnivore";
            else if (size == AnimalSize.Large && diet == Diet.Carnivore)
                return "Large Carnivore";
            else
                return "";
        }
    }
}
