using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetLinkpartie2
{

    internal class Dog
    {
        public string Race { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public Dog(string race, string name, int age, int weight)
        {
            Race = race;
            Name = name;
            Age = age;
            Weight = weight;
        }




    }
}
