using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsibinski2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 1a) 'Switch' with no default
            resultsSwitch01TextBox.Text = Ex2gCalculations.Switch01(input1aTextBox.Text);

            // 1b) Separate 'if' statements
            resultIf01TextBox.Text = Ex2gCalculations.If01(input1aTextBox.Text);

            // 1c) if elseif
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(input1aTextBox.Text);

            // 1d) Nested if-else
            resultNestedIfElse01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1aTextBox.Text);

            // 1e) 'Switch' with default
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(input1aTextBox.Text);

            resultIf02TextBox.Text = Ex2gCalculations.IfDefault01(input1aTextBox.Text);

            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIfDefault01(input1aTextBox.Text);

            resultNestedIfElse02TextBox.Text = Ex2gCalculations.NestedIfElseDefault01(input1aTextBox.Text);

            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(input1bTextBox.Text);

            resultIf03Textbox.Text = Ex2gCalculations.If02(input1bTextBox.Text);

            resultElseIf03TextBox.Text = Ex2gCalculations.ElseIf02(input1bTextBox.Text);

            resultNestedIfElse03TextBox.Text = Ex2gCalculations.NestedIfElse02(input1bTextBox.Text);
        }
    }
}
