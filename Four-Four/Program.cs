using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Four
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm newFarm = new Farm();
            Console.WriteLine("Welcome to Earl's Farm, here are some of our animals.");
            Goat Billy = new Goat("I'm Billy", "I say Baahhh", "I eat grass", "I provide milk");
            Ox Jerry = new Ox("I'm Jerry", "I say HOOOOOGGHH", "I also eat grass", "I help move heavy things");
            Pig Tim = new Pig("I'm Tim", "I say Oink", "I eat just about anything", "I provide bacon");
            Sheep Sherry = new Sheep("I'm Sherry", "I say Baaahh", "I eat grass", "I provide wool");
            newFarm.Speaks(Billy, Jerry, Tim, Sherry);
        }
    }
}
