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
            Manager manager;

            Console.WriteLine("Inserire numero di registri");
            regCount = Convert.ToInt32(Console.ReadLine());
            manager = new Manager(regCount);
            
            Console.WriteLine("Inserire comando");
            command = Console.ReadLine();            
            manager.ReadCommand(command);
            
            Console.WriteLine(manager.RPN.ToString());
        }
    }
}