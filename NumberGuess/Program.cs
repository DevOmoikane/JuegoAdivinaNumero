using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {

                Console.Write(" Guess a number between 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("... to high");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("... to low");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You Win");
                    win = true;
                }

                Console.WriteLine("Press any key");
                Console.ReadKey();
            } while (win == false);
        }
    }
}
