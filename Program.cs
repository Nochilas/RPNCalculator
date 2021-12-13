using System;
using RPNlib;

namespace calculator
{
    class Program
    {        
        static void Main()
        {
            RPN rpn = new RPN();
            rpn.Enter(5);
            Console.WriteLine($"Ho inserito 5");

            rpn.Enter(4);
            Console.WriteLine($"Ho inserito 4");

            rpn.Enter(3);
            Console.WriteLine($"Ho inserito 3");

            rpn.Enter(2);
            Console.WriteLine($"Ho inserito 2");

            rpn.Sum();
            rpn.Sum();
            rpn.Sum();
            Console.WriteLine(rpn.ToString());

            /*
            int x, y;
            char op;
            
            Console.Write("Inserisci primo numero: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Inserisci secondo numero: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Inserisci operatore: ");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine(Sum(x, y));
                    break;
                
                case '-':
                    Console.WriteLine(Subtract(x, y));
                    break;

                case '*':
                    Console.WriteLine(Multiply(x, y));
                    break;

                case '/':
                    Console.WriteLine(Divide(x, y));
                    break;

                default:
                    Console.WriteLine("Errore");
                    break;
            }*/

        }
    }
}