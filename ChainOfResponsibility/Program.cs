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

            chainelement1.Calculate(new CalculateObject(10, 5, CalculationType.add));
            chainelement1.Calculate(new CalculateObject(10, 5, CalculationType.div));
            chainelement1.Calculate(new CalculateObject(10, 5, CalculationType.mult));
            chainelement1.Calculate(new CalculateObject(10, 5, CalculationType.sub));

            Console.ReadKey();
        }
    }
}
