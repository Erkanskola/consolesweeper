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
            System.Console.WriteLine("Skriv in ett Y-värde");

            Console.ReadLine();


        


        }

        /*static void DoThing(enemy k)
        {
            //k++;
        }*/

    }
}
