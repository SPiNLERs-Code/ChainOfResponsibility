using System;

namespace ChainOfResponsibility.Calcultaions
{
    class Subtract : IChain
    {
        public IChain NextChain
        {
            get; set;
        }

        public void Calculate(CalculateObject calculateObject)
        {
            if (calculateObject.CalcType == CalculationType.sub)
            {
                Console.WriteLine(calculateObject.FirstNumber - calculateObject.SecondNumbe);
            }
            else
            {
                NextChain.Calculate(calculateObject);
            }
        }
    }
}
