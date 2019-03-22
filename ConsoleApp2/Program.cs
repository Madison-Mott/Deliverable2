using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput, numPeople;

            Console.WriteLine("Hello! My name is Madison. Let's plan your weekend!");
            Console.WriteLine("\n");

            Console.WriteLine("Select the activity are you in the mood for:");
            Console.WriteLine("a.) Action");
            Console.WriteLine("b.) Relaxing");
            Console.WriteLine("c.) Danger");
            Console.WriteLine("d.) Good Food");
            Console.WriteLine("\n");
            userInput = Console.ReadLine();

            if (userInput == "a" || userInput == "A" || userInput == "Action" || userInput == "action")
            {
                Console.WriteLine("\n");
                Console.WriteLine("How may people will be joining you?");
                Console.WriteLine("\n");
                numPeople = Console.ReadLine();

                if (numPeople == "0")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want action, then you should go Stock Car Racing and travel in sneakers.");
                }
                else if (numPeople == "1" || numPeople == "2" || numPeople == "3" || numPeople == "4")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want action, then you should go Stock Car Racing and travel in a sedan.");
                }
                else if (numPeople == "5" || numPeople == "6" || numPeople == "7" || numPeople == "8" || numPeople == "9" || numPeople == "10")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want action, then you should go Stock Car Racing and travel in a Volkswagen bus.");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want action, then you should go Stock Car Racing and travel in an airplane.");
                }
            }

            else if (userInput == "b" || userInput == "B" || userInput == "Relaxing" || userInput == "relaxing")
            {
                Console.WriteLine("\n");
                Console.WriteLine("How may people will be joining you?");
                Console.WriteLine("\n");
                numPeople = Console.ReadLine();

                if (numPeople == "0")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want a relaxing activity, then you should go Hiking and travel in sneakers.");
                }
                else if (numPeople == "1" || numPeople == "2" || numPeople == "3" || numPeople == "4")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want a relaxing activity, then you should go Hiking and travel in a sedan.");
                }
                else if (numPeople == "5" || numPeople == "6" || numPeople == "7" || numPeople == "8" || numPeople == "9" || numPeople == "10")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want a relaxing activity, then you should go Hiking and travel in a Volkswagen bus.");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want a relaxing activity, then you should go Hiking and travel in an airplane.");
                }
            }
            else if (userInput == "c" || userInput == "C" || userInput == "Danger" || userInput == "danger")
            {
                Console.WriteLine("\n");
                Console.WriteLine("How may people will be joining you?");
                Console.WriteLine("\n");
                numPeople = Console.ReadLine();

                if (numPeople == "0")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want danger, then you should go Skydiving and travel in sneakers.");
                }
                else if (numPeople == "1" || numPeople == "2" || numPeople == "3" || numPeople == "4")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want danger, then you should go Skydiving and travel in a sedan.");
                }
                else if (numPeople == "5" || numPeople == "6" || numPeople == "7" || numPeople == "8" || numPeople == "9" || numPeople == "10")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want danger, then you should go Skydiving and travel in a Volkswagen bus.");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want danger, then you should go Skydiving and travel in an airplane.");
                }
            }
            else if (userInput == "d" || userInput == "D" || userInput == "Good Food" || userInput == "good food" || userInput == "Good food")
            {
                Console.WriteLine("\n");
                Console.WriteLine("How may people will be joining you?");
                Console.WriteLine("\n");
                numPeople = Console.ReadLine();

                if (numPeople == "0")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want Good Food, then you should go to Taco Bell and travel in sneakers.");
                }
                else if (numPeople == "1" || numPeople == "2" || numPeople == "3" || numPeople == "4")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want Good Food, then you should go to Taco Bell and travel in a sedan.");
                }
                else if (numPeople == "5" || numPeople == "6" || numPeople == "7" || numPeople == "8" || numPeople == "9" || numPeople == "10")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want Good Food, then you should go to Taco Bell and travel in a Volkswagen bus.");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Alright! If you want Good Food, then you should go to Taco Bell and travel in an airplane.");
                }


            }

            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("I'm sorry that input was not understood.");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("I hope you have fun in your travels! Goodbye!");
            Console.ReadKey();
        }
    }
}
