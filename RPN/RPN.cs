using System;

namespace calculator
{
    public class RPN
    {
        private double[] regs;
        public double[] Regs
        {
            get { return regs; }
            private set { regs = value; }
        }

        private readonly int regCount;
        public int RegCount
        {
            get { return regCount; }
        }

        public RPN (int regNum)
        {
            if(regNum < 2)
            {
                throw new ArgumentException("New Argument Exception: registers number can't be lower than 2");
            }

            regCount = regNum;
            regs = new double[regNum];
        }

        public RPN ()
            : this(4) {}
        
        
        public void Sum()
        {
            regs[0] = regs[0] + regs[1];
            regs[1] = 0;
            regs[regCount - 2] = regs[regCount - 1];
        }

        private void FlushUp(double n)
        {
            for(int i = regCount - 1; i > 0; i--)
            {
                regs[i] = regs[i - 1];
            }

            regs[0] = n;
        }

        public override string ToString()
        {
            return "";
            //Y: reg[1]
            //X: reg[0]
        }
    }
}