using System;

namespace TestingWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            displayForLoops();
        }

            public static void displayForLoops()
            {
                for(int i = 0; i < 10; ++i)
                {
                    Console.WriteLine(i);
                }
                for(int i = 10; i >= 0; --i)
                {
                    Console.WriteLine(i);
                }
            }
        public static void otherLoops() {
            int num = 100;
            int num2 = 0;
            int num3 = 0;
            bool again = true;


            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num = num - 5;

            }
            while (again)
            {
                num = num + 1;
                Console.WriteLine(num);
                if (num == 10)
                {
                    again = false;
                }
            }
        }
    }
}
