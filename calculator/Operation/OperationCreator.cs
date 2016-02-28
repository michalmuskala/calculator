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

        public string Operation { private get; set; }
        public bool HasLhs => !string.IsNullOrEmpty(lhs);
        public bool HasContent => !string.IsNullOrWhiteSpace(ToString());
        public bool IsValid => !new [] { Operation, lhs, rhs }.Any(string.IsNullOrEmpty);

        private delegate IOperation BuildOperation(double lhs, double rhs);
        private Dictionary<string, BuildOperation> operations;

        public OperationCreator()
        {
            lhs = "";
            rhs = "";
            Operation = "";

            operations = new Dictionary<string, BuildOperation>();
            operations.Add("+", (lhs, rhs) => new Addition(lhs, rhs));
            operations.Add("−", (lhs, rhs) => new Subtraction(lhs, rhs));
            operations.Add("×", (lhs, rhs) => new Multiplication(lhs, rhs));
            operations.Add("÷", (lhs, rhs) => new Division(lhs, rhs));
        }

        public void Append(string s)
        {
            if(String.IsNullOrEmpty(Operation))
            {
                lhs = Append(lhs, s);
            }
            else
            {
                rhs = Append(rhs, s);
            }
        }

        private string Append(string original, string s)
        {
            if (s == "." && original.Contains("."))
            {
                return original;
            }
            else
            {
                return original + s;
            }
        }

        public IOperation Create()
        {
            if (String.IsNullOrEmpty(Operation))
            {
                throw new ArgumentException("no operation selected");
            }

            BuildOperation builder;
            if (!operations.TryGetValue(Operation, out builder))
            {
                throw new ArgumentException($"unknown operation: {Operation}");
            }

            double dlhs, drhs;
            if (TryParse(lhs, out dlhs) && TryParse(rhs, out drhs))
            {
                return builder(dlhs, drhs);
            }
            else
            {
                throw new ArgumentException($"invalid number");
            }
        }

        private bool TryParse(string s, out double res)
        {
            var format = System.Globalization.NumberStyles.Float;
            var provider = System.Windows.Forms.InputLanguage.CurrentInputLanguage.Culture.NumberFormat;
            return double.TryParse(s, format, provider, out res);
        }

        public override string ToString() => $"{lhs} {Operation} {rhs}";
    }
}
