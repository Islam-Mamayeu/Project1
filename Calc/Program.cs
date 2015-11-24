using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            x:
            Console.WriteLine("Choice the program : ");
            Console.WriteLine("1.Calculator");
            Console.WriteLine("2.Matrix");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                Calc.calculator();
            }
            else if(choice == "2")
            {

                Matrix.transp();

            }
            else
            {

                Console.WriteLine("Please try again!");
                goto x;

            }

        }
    }
}
