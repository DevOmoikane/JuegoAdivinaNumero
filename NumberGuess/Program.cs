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

                Console.Write(" Adivina un numero entre 0 y 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("... muy grande");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("... muy pequeño");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("Ganaste");
                    win = true;
                }

                Console.WriteLine("Presiona una tecla");
                Console.ReadKey();
            } while (win == false);
        }
    }
}
