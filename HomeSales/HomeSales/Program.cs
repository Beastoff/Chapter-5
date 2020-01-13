using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string personD, personE, personF;
            
            int totalD = 0;
            int totalE = 0;
            int totalF = 0;
            int salesEntry;
            string salesPerson;
            do
            {
                Console.WriteLine("Which person made the sale D, E, or F. To quit type Quit >>> ");
                salesPerson = Console.ReadLine();
                if (salesPerson == "D")
                {
                    Console.WriteLine("Enter sales");
                    salesEntry = Convert.ToInt32(Console.ReadLine());
                    totalD = totalD = salesEntry;
                }
                else if (salesPerson == "E")
                {
                    Console.WriteLine("Enter Sales");
                    salesEntry = Convert.ToInt32(Console.ReadLine());
                    totalE = totalE + salesEntry;
                }
                else if (salesPerson == "F")
                {
                    Console.WriteLine("Enter Sales");
                    salesEntry = Convert.ToInt32(Console.ReadLine());
                    totalF = totalF + salesEntry;
                }
            } while (salesPerson != "Quit");
            DisplayTotal(totalD, "Dennis");
            DisplayTotal(totalE, "");
            DisplayTotal(totalF, "");

        }
        public static void DisplayTotal(int total, string name)
        {
            Console.WriteLine("Sales total for {0} is {} 1", name,total);
        }
    }
}
