using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm newFarm = new Farm();
            Console.WriteLine("Welcome to Earl's Farm, here are some of our animals.");
            Goat Billy = new Goat("I'm Billy, I say Baahhh");
            newFarm.Speaks(Billy);
        }
    }
}
