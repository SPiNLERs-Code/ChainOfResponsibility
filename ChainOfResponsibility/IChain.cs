using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    interface IChain
    {
        IChain NextChain { get; set; }

        void Calculate(CalculateObject calculateObject);
    }
}
