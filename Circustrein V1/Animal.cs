using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_V1
{
    internal class Animal
    {
        public Animal(AnimalSize size, Diet diet)
        {
            this.size = size;
            this.diet = diet;
        }

        public AnimalSize size { get; set; }
        public Diet diet { get; set; }


        public override string ToString()
        {
            return size.ToString() + " " + diet.ToString();
        }
    }
}
