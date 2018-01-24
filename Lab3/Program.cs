using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            bool RunProgram = true;
            while (RunProgram)
            {
                Console.WriteLine("Please enter an integer");
                int Input = int.Parse(Console.ReadLine());

                //Process
                int Square = Input * Input;
                int Cube = Input * Input * Input;

                //Output
                Console.WriteLine("\nNumber     Squared     Cubed");
                Console.WriteLine("=====      =======     =====");

                for (int i = 1; i <= Input; i++)
                {
                    Console.WriteLine("{0}          {1}          {2}", i, Square, Cube);
                }

                Console.WriteLine("\nRun again (Y/N)?");
                char DoAgain = char.Parse(Console.ReadLine());

                if (DoAgain == 'y' || DoAgain == 'Y')
                {
                    RunProgram = true;                    
                    Console.Clear();
                }
                else
                {
                    RunProgram = false;
                }
            }
        }
    }
}
