using System;

namespace Deliverable_two
{
    class Program
    {
        static void Main(string[] args)
        {
            String question = @"Hello friend, what are you in the mood for?
            Here are your options:
            1)Action
            2)Chill times
            3)Danger
            4)Good Food";
            Console.WriteLine(question);

            string mood = Console.ReadLine();

            Console.WriteLine("How many people are you brining with you?");
            string npeople = Console.ReadLine();

            Int32 a;
            Int32 b;

            a = Convert.ToInt32(mood);
            b = Convert.ToInt32(npeople);

            var activity = "hello";

            if (a == 1)
            {
                activity = "Stock Car Racing";
            }
            else if (a == 2)
            {
                activity = "Hiking";
            }
            else if (a == 3)
            {
                activity = "Skydiving";
            }
            else if (a == 4)
            {
                activity = "Taco Bell";
            }

            var vehicle = "hello";

            if (b == 0)
            {
                vehicle = " sneakers";

            }
            else if (b >= 1 & b <= 4)
            {
                vehicle = "a sedan";
            }
            else if (b >= 5 & b <= 10)
            {
                vehicle = "a VW Bus";
            }
            else if (b >= 11)
            {
                vehicle = "an airplane";
            }


            Console.WriteLine("You should go {0} and travel in {1} ", activity, vehicle);


            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }
    }
}
