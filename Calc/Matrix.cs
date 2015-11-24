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
            Console.WriteLine("Input matrix size :");
            Console.WriteLine("length of rows :");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("length of colums :");
            m = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int [n,m];
            Console.WriteLine("Size of matrix = " + n + "," + m);


            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    Console.Write(i +","+ j +":");
                    matrix[i,j]= Console.Read();
                }
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    Console.Write(matrix[i, j]);

                }
            }





        }

    }
}
