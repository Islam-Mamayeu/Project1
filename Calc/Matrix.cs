using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Matrix
    {
        public static void transp()
        {
            int n = 0;
            int m = 0;

            Console.WriteLine("Input matrix size ");

            while (true)
            {

                Console.WriteLine("length of columns :"); 
                bool isInt = Int32.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("length of rows :");
                isInt = Int32.TryParse(Console.ReadLine(), out m);

                if (isInt)
                {
                    
                    int[,] matrix = new int[n, m];
                    int[,] transpmatrix = new int[m, n];

                    Console.WriteLine("Size of matrix = " + n + "," + m);


                    for (int i=0; i < n; i++)
                    {
                        for (int j=0; j < m; j++)
                        {
                            
                            Console.Write((i + 1) + "," + (j + 1) + ":");
                            isInt=Int32.TryParse(Console.ReadLine(), out matrix[i, j]);
                            if (isInt==false)
                            {
                                Console.WriteLine("Digit only!");--j;
                            }
                            
                        }
                    }

                    Console.WriteLine("Entered matrix:");
                    for (int j = 0; j < m; j++)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(" " + matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Transpose matrix:");
                    for (int j = 0; j < n; j++)
                    {
                        for (int i = 0; i < m; i++)
                        {

                            transpmatrix[i, j] = matrix[j, i];
                            Console.Write(" " + transpmatrix[i, j]);

                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect length try again!");

                }

            }






        }

    }
}
