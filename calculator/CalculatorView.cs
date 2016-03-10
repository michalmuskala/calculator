using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class CalculatorView : Form
    {
        public class UserInteractionArgs : EventArgs
        {
            public enum Kind { Op = 1, Num, Eq, Clear, ClearAll, Bsp, Negate };

            public Kind Type { get; private set; }
            public string Value { get; private set; }

            public UserInteractionArgs(Kind type, string value)
            {
                Type = type;
                Value = value;
            }
        }

        public event EventHandler<UserInteractionArgs> UserInteraction;

        public string Output
        {
            set { output.Text = value; }
        }

        public string Operation
        {
            set { operation.Text = value; }
        }

        public CalculatorView()
        {
            InitializeComponent();
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            OnUserInteraction(UserInteractionArgs.Kind.Eq, sender as Button);
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            OnUserInteraction(UserInteractionArgs.Kind.Op, sender as Button);
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            OnUserInteraction(UserInteractionArgs.Kind.Num, sender as Button);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            OnUserInteraction(UserInteractionArgs.Kind.ClearAll, sender as Button);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            OnUserInteraction(UserInteractionArgs.Kind.Clear, sender as Button);
        }

        private void btnBsp_Click(object sender, EventArgs e)
        {
            OnUserInteraction(UserInteractionArgs.Kind.Bsp, sender as Button);
        }
  
        private void btnNeg_Click(object sender, EventArgs e)
        {
            OnUserInteraction(UserInteractionArgs.Kind.Negate, sender as Button);
        }

        private void CalculatorView_KeyPress(object sender, KeyPressEventArgs e)
        {
            var btn = Controls.OfType<Button>()
                .Where(b => b.ASCIIText == SanitizeKey(e.KeyChar.ToString()))
                .FirstOrDefault();
            if (btn != null)
            {
                btn.PerformClick();
                e.Handled = true;
            }
        }

        private string SanitizeKey(string key)
        {
            if (key == InputLanguage.CurrentInputLanguage.Culture.NumberFormat.NumberDecimalSeparator)
            {
                return ".";
            }
            else
            {
                return key;
            }
        }

        protected virtual void OnUserInteraction(UserInteractionArgs.Kind kind, Button btn)
        {
            if (btn == null) { return; }
            var args = new UserInteractionArgs(kind, btn.Text);
            UserInteraction?.Invoke(this, args);
            btnEq.Focus();
        }
    }
}
