using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labfive
{
    class Program
    {
        static void Main(string[] args)

        {


            bool run = true;
            while (run == true)
            {
                if (Continue() == true)

                {
                    int input1;
                    Console.WriteLine("How many sides should each die have?");

                    input1 = Convert.ToInt32(Console.ReadLine()); // number of sides user provides
                    Console.WriteLine("The random numbers are:");

                    Random rando = new Random();
                    int min = 1;
                    int max = input1++; // number of sides provided by user

                    int i = 0;
                    while (i < 10)
                    {
                        Console.WriteLine(rando.Next(1, input1++));

                        i++;
                    }
                }
                else run = false;
               
            }
        }
            public static bool Continue()
            {
                Console.WriteLine("Welcome to the Grand Circus Casion! Roll the dice? y/n");
                string input = Console.ReadLine();
                input = input.ToLower();
                bool goOn;
                if (input == "y")
                {
                    goOn = true;
                }
                else if (input == "n")
                {
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("I don't understand that, let's try again");
                    goOn = Continue();
                }
                return goOn;
            }
        }
    }
