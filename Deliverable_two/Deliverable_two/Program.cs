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

            string[] activity;
            string[] vehicle;

            activity = new string[4] { "Stock Car Racing", "Hiking", "Skydiving", "go to Taco Bell" };
            vehicle = new string[4] { "sneakers", "a sedan", "a volkswagen bus", "an airplane" };

            Console.WriteLine("You should go {0} and travel in {1}", activity[a - 1], vehicle[b - 1]);
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }
    }
}
