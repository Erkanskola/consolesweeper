using System;

namespace consolesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int y = 100;

            DoThing(ref y);

            System.Console.WriteLine(y);


            Console.ReadLine();


        }

        static void DoThing(ref int k)
        {
            k++;
        }
    }
}
