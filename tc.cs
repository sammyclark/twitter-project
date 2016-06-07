using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Wall SarahsWall;
            String stuff;
            Console.WriteLine("Type shit");
            stuff = Console.ReadLine();
          

            while (stuff != "exit")
            {
                Console.WriteLine(stuff);
               stuff = Console.ReadLine();
            }               
        }
    }
}