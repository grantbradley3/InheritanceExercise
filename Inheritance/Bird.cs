using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string Color { get; set; }
        public bool Nocturnal { get; set; }
        public bool HasBeak { get; set; }
        public bool HasClaws { get; set; }       

        public Bird() 
        {
            Legs = 2;
            HasTail= true;
            CanFly= true;
            Carnivore= false;
        }

    }
}
