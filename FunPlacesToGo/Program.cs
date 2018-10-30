using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPlacesToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string person = Console.ReadLine();

            Console.WriteLine($"Hello {person}! Welcome to the fun recommondations application! \nHere, I will assist you in finding fun activities. " +
                $"\n\nWhat are you in the mood for?");
            
            Console.WriteLine("Press 1 for Action \nPress 2 for Chilling \nPress 3 for Danger \nPress 4 for Good Food");

            string decision = Console.ReadLine();
            int choice = int.Parse(decision);
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You should go Hiking!");
                    break;
                case 2:
                    Console.WriteLine("You should go to the Movies!");
                    break;
                case 3:
                    Console.WriteLine("You should go to a Gun Range!");
                    break;
                case 4:
                    Console.WriteLine("You should go to Andiamo!");
                    break;
            }

            Console.WriteLine("How many people are you brining with you? \nPress 1 for 0 " +
                "\nPress 2 for 1-4 \nPress 3 for 5-10 \nPress 4 for 11+");

            string decision2 = Console.ReadLine();
            int choice2 = int.Parse(decision2);

            switch (choice2)
            {
                case 1:
                    Console.WriteLine("You should travel in Salomon Ultra Light-Weight hiking shoes!");
                    break;
                case 2:
                    Console.WriteLine("You should request an Uber!");
                    break;
                case 3:
                    Console.WriteLine("You should travel in a Party Bus that plays obnoxiously loud music!");
                    break;
                case 4:
                    Console.WriteLine("You should travel in a spaceshift!");
                    break;
            }
        }
    }
}
