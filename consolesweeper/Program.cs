using System;

namespace consolesweeper
{
    class Program
    {
        static void Main(string[] args)
        {

            SweeperGrid sweeperGrid = new SweeperGrid();

            //Här kallas jag mina metoder ur klassen "SweeperGrid.cs"
            sweeperGrid.Draw();
            sweeperGrid.CheckPosition(10,10);


            //Enkelt gränssnitt för att användaren ska kunna skriva in koordinater.
            int xGuess = 0;
            bool success = false;
            while (!success)
            {
                System.Console.WriteLine("Gissa X:");
                success = int.TryParse(Console.ReadLine(), out xGuess);

                if (xGuess > 9 || xGuess < 0)
                {
                    success = false;
                }
            }

            int yGuess = 0;
            bool success2 = false;
            while (!success2)
            {
                System.Console.WriteLine("Gissa Y:");
                success2 = int.TryParse(Console.ReadLine(), out yGuess);

                if (yGuess > 9 || yGuess < 0)
                {
                    success2 = false;
                }
            }

            //Om användaren skrivit in koordinater för en mina skrivs "PANGBOMHEJDÅ", skrivs säkra koordinater in skrivs istället "bra jobbat lol"
            bool isAMine = sweeperGrid.CheckPosition(xGuess, yGuess);

            if (isAMine)
            {
                System.Console.WriteLine("PANGBOMHEJDÅ");
            }

            else if(!isAMine)
            {
                System.Console.WriteLine("bra jobbat lol");
            }




           /* string xKo = Console.ReadLine();
            string yKo = Comsole.ReadLine();

           bool success = false;
    
            while(!success)
            {
                success = int.TryParse(xKo, out int xK);
                System.Console.WriteLine(xK);
            }*/



            Console.ReadLine();



        


        }

        /*static void DoThing(enemy k)
        {
            //k++;
        }*/

    }
}
