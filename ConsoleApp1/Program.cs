using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Program
    {
        static char[,] GetLabyrinth()
        {
            return new[,]
            {
                {' ', ' '},
                //{'*', ' '},
                //{' ', ' '},
                //{'*', ' '},
                {' ', 'e'}
            };
        }

        static void FindPath(int row, int col, char[,] labyrinth)
        {
            if ((col < 0) || (row < 0)
                          || (col >= labyrinth.GetLength(1))
                          || (row >= labyrinth.GetLength(0)))
                return; // Out of the labyrinth boundaries

            if (labyrinth[row, col] == 'e') // Reached the end
                return;

            labyrinth[row, col] = 's'; // Mark 

            FindPath(row, col - 1, labyrinth); // Left
            FindPath(row - 1, col, labyrinth); // Up
            FindPath(row, col + 1, labyrinth); // Right
            FindPath(row + 1, col, labyrinth); // Down

            labyrinth[row, col] = ' ';
        }

        public void method()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(value: "Start!\n");
            var stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            char[,] labyrinth = GetLabyrinth();
            FindPath(0, 0, labyrinth);
            //Console.WriteLine(value: "'√'");
            //Console.WriteLine(labyrinth.GetLength(0));
            //Console.WriteLine(labyrinth.GetLength(1));
            stopwatch.Stop();
            Console.WriteLine($"Elapsed milliseconds: {stopwatch.ElapsedMilliseconds}");
            Console.WriteLine(value: "\nEnd!");
        }

        public static void Main()
        {
            
        }
    }

}
