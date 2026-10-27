using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace калькулятор_дизайн
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool newOperation = true;
        double firstValue;
        double secondValue;
        double result = 0.0;
        private void btnActionNunbers(object sender, EventArgs e)
        {
            var btn = ( Button )sender;
            if (newOperation)
            {
                txtDisplay.Clear();
                newOperation = false;
            }
            if (btn.Text == ",")
            {
                var val = txtDisplay.Text.IndexOf(',');
                if (val > 0)
                    return;
            }
            txtDisplay.Text += btn.Text;
            if (btn.Text != ",")
                firstValue = Convert.ToDouble(txtDisplay.Text);
        }
        private void btnActionOperation(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    newOperation = true;
                    break;
                case "-":
                    newOperation = true;
                    break;
                case "*":
                    newOperation = true;
                    break;
                case "/":
                    newOperation = true;
                    break;
                case "%":
                    newOperation = true;
                    break;
            }
        }
    }
}


