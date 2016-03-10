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

        private bool hasOperation => !string.IsNullOrEmpty(Operation);

        public string Display()
        {
            if (hasOperation)
            {
                return $"{lhs} {Operation}";
            }
            else
            {
                return "";
            }
        }

        public string Current()
        {
            if (hasOperation)
            {
                return rhs;
            }
            else
            {
                return lhs;
            }
        }

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
            if(hasOperation)
            {
                rhs = Append(rhs, s);
            }
            else
            {
                lhs = Append(lhs, s);
            }
        }

        private string Append(string original, string s)
        {
            if (original.Length >= 12)
            {
                return original;
            }

            if (s == "." && original.Contains("."))
            {
                return original;
            }
            else
            {
                return original + s;
            }
        }

        public void Clear()
        {
            if (hasOperation)
            {
                rhs = "";
            }
            else
            {
                lhs = "";
            }
        }

        public void Bsp()
        {
            if (hasOperation)
            {
                rhs = RemoveLast(rhs);
            }
            else
            {
                lhs = RemoveLast(lhs);
            }
        }

        private string RemoveLast(string value)
        {
            if (value.Length > 0)
            {
                return value.Remove(value.Length - 1);
            }
            return value;
        }

        public void Negate()
        {
            if (hasOperation)
            {
                rhs = DoNegate(rhs);
            }
            else
            {
                lhs = DoNegate(lhs);
            }
        }

        private string DoNegate(string value)
        {
            if (value.StartsWith("-"))
            {
                return value.Remove(0, 1);
            }
            else if (value.Length == 0)
            {
                return value;
            }
            else
            {
                return "-" + value;
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
