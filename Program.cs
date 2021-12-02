using System;

namespace calculator
{
    class Program
    {
        static double[] reg = new double[4];

        static double Sum(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return (x * y);
        }

        static double Divide(double x, double y)
        {
            return (x / y);
        }
        
        //Comment
        static double Factorial(int x)
        {
            if (x == 0)
                return 1;
            
            int res = 1;

            for (int i = 1; i<=x; i++)
                res *= i;
            
            return res;
        }
        static void Main()
        {
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
                    Console.Write(Sum(x, y));
                    break;
                
                case '-':
                    Console.Write(Subtract(x, y));
                    break;

                case '*':
                    Console.Write(Multiply(x, y));
                    break;

                case '/':
                    Console.Write(Divide(x, y));
                    break;

                default:
                    Console.Write("Errore");
                    break;
            }
        }
    }
}