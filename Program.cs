using System;
using System.Threading;

namespace sodokoORG
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "";
            int row1 = 0;
            int col1 = 0;
            int[,] sodoku = new int[9, 9];
            for (row1 = 0; row1 < 9; row1++)
            {
                for (col1 = 0; col1 < 9; col1++)
                {
                    sodoku[row1, col1] = int.Parse(Console.ReadLine());
                }
            }

            Thread p = new Thread(() => parent.parent1(sodoku, res));

            p.Start();

            try
            {
                p.Join();
                if (res == "false")
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
            //row

        }
    }
}
