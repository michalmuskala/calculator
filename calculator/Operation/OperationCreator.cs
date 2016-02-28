using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Operation
{
    class OperationCreator
    {
        private string lhs;
        private string rhs;

        public string Operation { get; set; }

        private delegate IOperation BuildOperation(double lhs, double rhs);
        private Dictionary<string, BuildOperation> operations;

        public OperationCreator()
        {
            lhs = "";
            rhs = "";
            Operation = "";

            operations.Add("+", (lhs, rhs) => new Addition(lhs, rhs));
            operations.Add("-", (lhs, rhs) => new Subtraction(lhs, rhs));
            operations.Add("*", (lhs, rhs) => new Multiplication(lhs, rhs));
            operations.Add("/", (lhs, rhs) => new Division(lhs, rhs));
        }

        public void Append(string s)
        {
            if(String.IsNullOrEmpty(Operation))
            {
                lhs += s;
            }
            else
            {
                rhs += s;
            }
        }

        public IOperation Create()
        {
            BuildOperation builder = operations[Operation];
            if (builder == null)
            {
                throw new ArgumentException($"unknown operation: {Operation}");
            }

            try
            {
                var dlhs = Double.Parse(lhs);
                var drhs = Double.Parse(rhs);
                return builder(dlhs, drhs);
            }
            catch (FormatException e)
            {
                throw new ArgumentException($"invalid number: {e.Message}", e);
            }
        }
    }
}
