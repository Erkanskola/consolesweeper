using System;

namespace consolesweeper
{
    public class SweeperGrid
    {
        int[,] grid = new int[10, 10];
        


        public SweeperGrid()
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    grid[x, y] = 9;

                }
           }


           Random mine = new Random();

            for (int i = 0; i < 10; i++)
            {

               while (true)
               {
                   int x = mine.Next(10);
                   int y = mine.Next(10);

                   if (grid[x,y] == 9)
                   {
                       grid[x,y] = 10;
                       break;
                   }
               }     

                grid[mine.Next(10),mine.Next(10)] = 10;
            }


        }

        public bool  CheckPosition(int x, int y)
        {
            if (grid[x - 1, y - 1] > 10 || grid[x - 1, y - 1 ] < 1) 
            {
                return false;
            }

            else
            {
                return true;
            }

            

            
        }

        public void Draw()
        {

            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    //Console.Write($"{grid[x,y]} ");

                    if (grid[x,y] == 10)
                    {
                        Console.Write("*");
                    }

                    else if(grid[x,y] == 9)
                    {
                        Console.Write("█");
                    }

                }

                System.Console.WriteLine();

            }

        }
    }


}
