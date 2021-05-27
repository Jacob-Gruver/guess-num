using System;

namespace guess_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Boolean won = false;

            while (won == false)
            {
                Console.WriteLine("Choose a number between 0 - 100.");

                string num = Console.ReadLine();

                System.Console.WriteLine("You chose the number " + num);

                if (num == "12")
                {
                    won = true;
                    System.Console.WriteLine("You won!");
                }

                Console.Clear();

            }
        }
    }
}
