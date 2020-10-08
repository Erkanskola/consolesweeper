using System;

namespace consolesweeper
{
    class Program
    {
        static void Main(string[] args)
        {

            SweeperGrid sweeperGrid = new SweeperGrid();

            sweeperGrid.Draw();
            sweeperGrid.CheckPosition(10,10);

            System.Console.WriteLine("Skriv in ett X-värde");




            string xKo = Console.ReadLine();
            string yKo = Console.ReadLine();

           bool success = false;
    
            while(!success)
            {
                success = int.TryParse(xKo, out int xK);
                if (xK <= 10 || xK >= 1)
                {
                    System.Console.WriteLine($"Din X-koordinat är {xK}");
                }
                break;
            }


            Console.ReadLine();



        


        }

        /*static void DoThing(enemy k)
        {
            //k++;
        }*/

    }
}
