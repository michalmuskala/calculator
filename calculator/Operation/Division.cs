using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Operation
{
    class Division : IOperation
    {
        public double Lhs { get; set; }
        public double Rhs { get; set; }
        public double Value => Lhs / Rhs;

        public Division(double lhs, double rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }
    }
}
