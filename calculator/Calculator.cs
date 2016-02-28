using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.Operation;

namespace calculator
{
    class Calculator
    {
        private List<IOperation> operations;

        Calculator()
        {
            operations = new List<IOperation>();
        }
    }
}
