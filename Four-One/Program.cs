using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm newFarm = new Farm();
            Console.WriteLine("Welcome to Earl's Farm, here are some of our animals.");
            Goat Billy = new Goat("Billy, I say BAAAAAHHHAHAHAHAHA");
            Ox Jerry = new Ox("Jerry, I say HHHHOOOOOOOOOOOOOOGGHHH");
            Pig Tim = new Pig("Tim, I say Oink Oink Oink");
            Sheep Sherry = new Sheep("Sherry, I say Baaaaahahaha");
            newFarm.Speaks(Billy, Jerry, Tim, Sherry);
        }
    }
}
