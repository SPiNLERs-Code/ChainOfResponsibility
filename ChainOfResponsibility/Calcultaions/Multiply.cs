using System;

namespace ChainOfResponsibility.Calcultaions
{
    class Multiply : IChain
    {
        public IChain NextChain
        {
            get;set;
        }

        public void Calculate(CalculateObject calculateObject)
        {
            if(calculateObject.CalcType == CalculationType.mult)
            {
                Console.WriteLine(calculateObject.FirstNumber * calculateObject.SecondNumbe);
            }
            else
            {
                NextChain.Calculate(calculateObject);
            }
        }
    }
}
