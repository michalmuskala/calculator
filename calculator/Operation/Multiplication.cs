using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Operation
{
    class Multiplication : IOperation
    {
        private double lhs;
        private double rhs;

        public Multiplication(double lhs, double rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public double Value() => lhs * rhs;
    }
}
