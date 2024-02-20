using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{
    internal class Animal
    {
        public AnimalSize Size { get; set; }
        public Diet Diet { get; set; }

        public override string ToString()
        {
            if (Size  == AnimalSize.Small &&  Diet == Diet.Herbivore)
                return "Small Herbivore";
            if (Size == AnimalSize.Medium && Diet == Diet.Herbivore)
                return "Medium Herbivore";
            if (Size == AnimalSize.Big && Diet == Diet.Herbivore)
                return "Medium Herbivore";
            if (Size == AnimalSize.Small && Diet == Diet.Carnivore)
                return "Small Carnivore";
            if (Size == AnimalSize.Medium && Diet == Diet.Carnivore)
                return "Medium Carnivore";
            if (Size == AnimalSize.Big && Diet == Diet.Carnivore)
                return "Medium Carnivore";
            else
                return "";
        }
    }
}
