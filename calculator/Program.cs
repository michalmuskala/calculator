using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Calculator model = new Calculator();
            CalculatorView view = new CalculatorView();
            CalculatorController controller = new CalculatorController(model, view);
            Application.Run(view);
        }
    }
}
