using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class CalculatorController
    {
        private Calculator model;
        private CalculatorView view;

        private CalculatorView View
        {
            get { return view; }
            set
            {
                var handler = new EventHandler<CalculatorView.UserInteractionArgs>(this.HandleUserInteraction);

                if (view != null)
                {
                    view.UserInteraction -= handler;
                }
                view = value;
                view.UserInteraction += handler; 
            }
        }

        public CalculatorController(Calculator model, CalculatorView view)
        {
            this.model = model;
            View = view;
        }

        public void HandleUserInteraction(object sender, CalculatorView.UserInteractionArgs args)
        {
            switch (args.Type)
            {
                case CalculatorView.UserInteractionArgs.Kind.Eq:
                    model.Execute();
                    break;
                case CalculatorView.UserInteractionArgs.Kind.Num:
                    model.Append(args.Value);
                    break;
                case CalculatorView.UserInteractionArgs.Kind.Op:
                    model.Operation = args.Value;
                    break;
            }
            view.Output = model.Display();
        }
    }
}
