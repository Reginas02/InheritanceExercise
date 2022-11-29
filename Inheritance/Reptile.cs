using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Reptile : Animal
    {
      public bool isColdBlooded { get; set; }

      public bool HasScales { get; set; }

      public string Environment { get; set; }   

      public string Defense { get; set; }
        
      public string Name { get; set; }

      public int Age { get; set; }

      public Reptile()
      {

      }

        public Reptile(string name, int age, int legs, bool isColdBlooded, bool HasScales)
        {
            string Name = name;
            Age = age;
            legs = legs;
            isColdBlooded = isColdBlooded;
            Environment = Environment;  
            Defense = Defense;
            HasScales = HasScales;

        }









     }

   
    
    }


