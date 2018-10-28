using System;

namespace Four_Four
{
    internal class Farm
    {
        public void Speaks(Goat Billy, Ox Jerry, Pig Tim, Sheep Sherry)
        {
            Console.WriteLine($"{Billy.Name()}, {Billy.Speaks()}, {Billy.Eat()}, {Billy.Provide()}");
            Console.WriteLine($"{Jerry.Name()}, {Jerry.Speaks()}, {Jerry.Eat()}, {Jerry.Provide()}");
            Console.WriteLine($"{Tim.Name()}, {Tim.Speaks()}, {Tim.Eat()}, {Tim.Provide()}");
            Console.WriteLine($"{Sherry.Name()}, {Sherry.Speaks()}, {Sherry.Eat()}, {Sherry.Provide()}");
        }
    }
}