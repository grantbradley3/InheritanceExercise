using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var eagle = new Bird();
            eagle.Color = "Brown";
            eagle.Nocturnal = false;
            eagle.HasClaws = true;
            eagle.HasBeak = true;

            var chameleon = new Reptile();
            chameleon.Sheds = true;
            chameleon.IsColdBLooded= true;
            chameleon.Habitat = "Rainforest";
            chameleon.ChangesColor = true;

            var myAnimals = new Animal[] { chameleon, eagle};

            foreach (var animal in myAnimals)
            {

                Console.WriteLine($"Has legs : {animal.Legs}");
                Console.WriteLine($"Is Carnivore : {animal.Carnivore}");
                Console.WriteLine($"Can Fly : {animal.CanFly}");
                Console.WriteLine($"Has Tail : {animal.HasTail}");
                Console.WriteLine($"");
            }
        }
    }
}
