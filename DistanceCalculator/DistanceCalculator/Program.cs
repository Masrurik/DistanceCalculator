using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int distance;
            bool exit = true;

            Console.WriteLine("Welcome to DistanceCalculator");

           
            


            while (exit)
            {
                
                Console.WriteLine("\nMENU");
                Console.WriteLine("1.Start program");
                Console.WriteLine("2.Exit");
                Console.WriteLine("Please enter a number from the menu");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Please enter how long you will drive");
                        int hours = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter your speed");
                        int speed = Convert.ToInt32(Console.ReadLine());
                        int counter = 1;
                        while (counter <= hours)
                        {
                            // Console.WriteLine(counter);

                            distance = counter * speed;
                            Console.WriteLine($"After {counter} hour the distance is {distance} miles");
                            counter++;
                        }
                        break;
                    case "2":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Error, please enter a number from the menu");
                        break;
                }
            }
            
        }
    }
}
