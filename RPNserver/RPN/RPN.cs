using System;

namespace RPNlib
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
        
        
        //FlushUp & FlushDown
        private void FlushUp()
        {
            for(int i = regCount - 1; i > 0; i--)
                regs[i] = regs[i - 1];
        }

        private void FlushDown()
        {
            for(int i = 1; i < regCount - 1; i++)
                regs[i] = regs[i+1];
        }

        public void Enter(double n)
        {
            FlushUp();
            regs[0] = n;
        }

        //Operations
        public void Sum()
        {
            regs[0] = regs[0] + regs[1];
            FlushDown();
        }

        public void Diff()
        {
            regs[0] = regs[0] - regs[1];
            FlushDown();
        }

        public void Multiply()
        {
            regs[0] = regs[0] * regs[1];
            FlushDown();
        }

        public void Divide()
        {
            regs[0] = regs[0] / regs[1];
            FlushDown();
        }

        public override string ToString()
        {
            return $"Y: {regs[1]}\nX: {regs[0]}";
        }
    }
}