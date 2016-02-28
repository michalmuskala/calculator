using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Operation
{
    interface IOperation
    {
        double Value { get; }
        double Lhs { get; set; }
        double Rhs { get; set; }
    }
}
