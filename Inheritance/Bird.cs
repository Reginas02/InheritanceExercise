using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Bird : Animal
    {
        public bool HasFeathers { get; set; }
        public int Wings { get; set; }
        public int Flies { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int legs { get; internal set; }

        private bool hasFeathers;

        public Bird()
        {

        }
        public Bird(string name, int age, int legs, bool HasFeathers, int wings, int flies, string type)
        {

            Name = name;
            Age = age;
            Legs = legs;
            hasFeathers = HasFeathers;
            Wings = wings;  
            Flies = flies;  
            Type = type;    








        }





    }
}
