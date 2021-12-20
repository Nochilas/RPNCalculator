using System;
using RPNlib;

namespace calculator
{
    class Program
    {        
        static void Main()
        {
            int regCount;
            string command;

            Console.WriteLine("Inserire numero di registri");
            regCount = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Inserire comando");
            command = Console.ReadLine();

            Manager manager = new Manager(regCount);
            manager.ReadCommand(command);
            
            Console.WriteLine(manager.RPN.ToString());
        }
    }
}