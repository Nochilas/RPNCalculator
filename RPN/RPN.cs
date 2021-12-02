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

        private int regCount;
        public int RegCount
        {
            get { return regCount; }
            set { regCount = value; }
        }
      
        public RPN (int regNum)
        {
            if(regCount < 2)
            {
                throw new ArgumentException("Error");    
            }

            regCount = regNum;
            regs = new double[regNum];
        }
    }
}