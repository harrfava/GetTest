using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int CorrectNum = n.Next(0, 100);
            int NumofGuess = 0; 
            bool win = false;

            do
            {
                Console.WriteLine("I thinking of a Number from 0 - 100: ");
                
                string r = Console.ReadLine();

                int i = int.Parse(r);

                if (i > CorrectNum)
                {
                    Console.WriteLine("To high!");
                    NumofGuess++;


                }
                else if (i < CorrectNum)
                {
                    Console.WriteLine("To Low!");
                    NumofGuess++;
                }

                else if (i == CorrectNum)
                {
                    Console.WriteLine("Correct! ");
                    NumofGuess++;
                    win = true;

                }
            } 
            while (win == false);

            Console.WriteLine("Number of Guesses: " + NumofGuess);

            Console.Write("Press any button to exit: " );
            Console.ReadKey(true);


        }

    }

}     
