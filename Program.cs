using System;

namespace guess_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            var randomNum = rnd.Next(1, 99);

            Boolean won = false;

            while (won == false)
            {

                int num;

                Console.WriteLine("Choose a number between 0 - 100.");

                num = Console.Read();

                System.Console.WriteLine("You chose the number " + num);

                if (num == randomNum)
                {
                    won = true;
                    System.Console.WriteLine("You won!");
                }
                else if (num > randomNum)
                {
                    System.Console.WriteLine("Wrong number.. Try to go lower");
                }
                else if (num < randomNum)
                {
                    System.Console.WriteLine("Wrong number.. Try to go higher");
                }

            }
        }
    }
}
