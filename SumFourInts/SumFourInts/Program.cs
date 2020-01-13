using System;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int num;
            int i = 0;
            while(i < 4)
            {
                Console.WriteLine("Enter num");
                num = Convert.ToInt32(Console.ReadLine());
                ++i;
            }
            Console.WriteLine("Total");
        }
    }
}
