using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Farm newFarm = new Farm();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
