using ChainOfResponsibility.Calcultaions;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IChain chainelement4 = new Divide();
            IChain chainelement3 = new Multiply() { NextChain = chainelement4};
            IChain chainelement2 = new Subtract() { NextChain = chainelement3 };
            IChain chainelement1 = new Add() { NextChain = chainelement2 };

            CalculateObject calcObject = new CalculateObject()
            {
                CalcType = CalculationType.div,
                FirstNumber = 10,
                SecondNumbe = 9
            };

            chainelement1.Calculate(calcObject);

            Console.ReadKey();
        }
    }
}
