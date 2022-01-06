using System;

namespace RPNlib
{
    class Manager
    {
        private RPN rpn;
        public RPN RPN
        {
            get { return rpn; }
        }

        public Manager(int regCount)
        {
            rpn = new RPN(regCount);
        }

        public void ReadCommand(string command)
        {
            string[] commands = command.Split(" ");
            
            for(int i = 0; i < commands.Length; i++)
            {
                double n;
                bool isNum = double.TryParse(commands[i], out n);

                if(isNum)
                    rpn.Enter(n);
                else
                {
                    switch(commands[i])
                    {
                        case "+":
                            rpn.Sum();
                            break;
                        
                        case "-":
                            rpn.Diff();
                            break;
                        
                        case "*":
                            rpn.Multiply();
                            break;
                        
                        case "/":
                            rpn.Divide();
                            break;
                        
                        default:
                            throw new ArgumentException($"Invalid command: {commands[i]} is not a valid term in the expression");
                    }
                } 
            }
        }
    }
}
