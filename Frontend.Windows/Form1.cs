using System.Globalization;
using Backend;

namespace Frontend.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // A single event for digits, dot, operators and parentheses: appends the button text.
        private void btnInput_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ExpressionEvaluator.Evalute(txtDisplay.Text);
                // InvariantCulture: always a decimal point, regardless of regional settings.
                txtDisplay.Text += $"={result.ToString(CultureInfo.InvariantCulture)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid expression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text[..^1];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }
    }
}
