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
        private OperationCreator creator;

        private string error { get; set; }
        private bool hasError => !string.IsNullOrEmpty(error);

        public Calculator()
        {
            operations = new List<IOperation>();
            creator = new OperationCreator();
            error = "";
        }

        public void Append(string s)
        {
            error = "";
            creator.Append(s);
        }

        public string Operation
        {
            set {
                error = "";
                if (!creator.HasLhs)
                {
                    creator.Append(LastValue);
                }
                creator.Operation = value;
            }
        }

        public void Execute()
        {
            if (!creator.IsValid) { return; }
            try
            {
                operations.Add(creator.Create());
                error = "";
            }
            catch (ArgumentException e)
            {
                error = e.Message;
            }
            creator = new OperationCreator();
        }

        public void ClearAll() => creator = new OperationCreator();
        public void Clear()    => creator.Clear();
        public void Bsp()      => creator.Bsp();
        public void Negate()   => creator.Negate();

        public string Display() => creator.Display();

        public string Current()
        {
            if (hasError)
            {
                return error;
            }
            else if (creator.HasContent || !operations.Any())
            {
                return creator.Current();
            }
            else
            {
                return LastValue;
            }
        }

        private string LastValue
        {
            get
            {
                if (operations.Any())
                {
                    var provider = System.Windows.Forms.InputLanguage.CurrentInputLanguage.Culture.NumberFormat;
                    return operations.Last().Value.ToString("G10", provider);
                }
                else
                {
                    return "0";
                }
            }
        }
    }
}
