using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fis_Bum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fis = 3;
            int bum = 5;
            for (int i = 1; i < 100; i++)
            {
                string line = "";
                if (i % fis == 0)
                {
                    line += "Fis";
                }
                if (i % bum == 0)
                {
                    line += "Bum";
                }
                if (line == "")
                {
                    Console.WriteLine(i);
                }
                else 
                { 
                    Console.WriteLine(line); 
                }
            }
            Console.ReadLine();
        }
    }
}
