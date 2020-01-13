
using static System.Console;




class DebugFive1


{


    static void Main()


    {


        const string PASS1 = "home";


        const string PASS2 = "lady";


        const string PASS3 = "mouse";


        string password;







        Write("Please enter your password ");


        password = Convert.To String(Console.ReadLine());


        while (password != PASS1 | password != PASS2 | password != PASS3)


            WriteLine("Invalid password. Please enter again. ");


        password = ReadLine();


        WriteLine("Valid password");


    }


}

