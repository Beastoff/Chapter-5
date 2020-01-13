using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userEntry;
            int tries = 0;
            bool again = true;
            while (again)
            {
                Console.WriteLine("Please enter a number between 1 - 100!");
                userEntry = Convert.ToInt32(Console.ReadLine());
                if (userEntry > r)
                {
                    Console.WriteLine("Hey buddy that number is too high!!!");
                }
                else if (userEntry < r)
                {
                    Console.WriteLine("Hey pal that number is too low!!!");
                }
                else if (userEntry == r)
                {
                    Console.WriteLine("That number is correct!!!");
                }
                tries = tries + 1;
                if (tries == 6)
                {
                    Console.WriteLine("Go back to your day job, to many tries = " + tries +
                        "\n answer was " + r);
                    again = false;
                }
            }
       
        }
    }
}
