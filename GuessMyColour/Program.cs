using System;

namespace GuessMyColour
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A Computer generates a color (a random number)
             The user tries to guess the color
            */
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 4);
            bool rightGuess = false;

            while (!rightGuess)
            {
                Console.WriteLine("What's my color?");
                string userInput = Console.ReadLine().ToLower();


                if(computerNumber == 1 && userInput == "red")
                {
                    Console.WriteLine("You won!");
                    rightGuess = true;
                }else if (computerNumber == 2 && userInput == "green")
                {
                    Console.WriteLine("you won!");
                }else if (computerNumber == 3 && userInput == "blue")
                {
                    Console.WriteLine("You  won!");
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
          





        }
    }
}
