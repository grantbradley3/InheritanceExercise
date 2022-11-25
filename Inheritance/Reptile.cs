using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool IsColdBLooded { get; set; }
        public string Habitat { get; set; }
        public bool Sheds { get; set; }
        public bool ChangesColor { get; set; }


        public Reptile()
        {
            Legs = 4;
            HasTail = true;
            CanFly = false;
            Carnivore = true;
        }

    }
}
