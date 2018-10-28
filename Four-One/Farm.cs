using System;

namespace Four_One
{
    internal class Farm
    {
        public void Speaks(Goat Billy, Ox Jerry, Pig Tim, Sheep Sherry)
        {
            Console.WriteLine(Billy.Speaks());
            Console.WriteLine(Jerry.Speaks());
            Console.WriteLine(Tim.Speaks());
            Console.WriteLine(Sherry.Speaks());
        }
    }
}