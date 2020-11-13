using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lsibinski2h1;

namespace lsibinski2h1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DateCalculationButton_Click(object sender, EventArgs e)
        {
            TextBox1aResult.Text = DateTime.Now.ToShortDateString();
            TextBox1bResult.Text = DateTime.Now.ToShortTimeString();
            TextBox2aResult.Text = DateTime.Today.ToShortDateString();
            TextBox2bResult.Text = DateTime.Today.ToShortTimeString();
            TextBox3aResult.Text = DateTime.Today.Year.ToString();
            TextBox3bResult.Text = DateTime.Today.Month.ToString();
            TextBox3cResult.Text = DateTime.Today.Day.ToString();
            TextBox4aResult.Text = DateTime.Today.AddDays(90).ToShortDateString();
            TextBox5aResult.Text = DateTime.Today.AddMonths(3).ToShortDateString();
            TextBox6dResult.Text = Ex2hCalculations.DateCalc06(TextBox6aResult.Text, TextBox6bResult.Text, TextBox6cResult.Text);
            TextBox7bResult.Text = Ex2hCalculations.DateCalc07(TextBox7aResult.Text);
            TextBox8bResult.Text = Ex2hCalculations.DateCalc08(TextBox8aResult.Text);
            TextBox9cResult.Text = Ex2hCalculations.DateCalc09(TextBox9aResult.Text, TextBox9bResult.Text);
            TextBox10cResult.Text = Ex2hCalculations.DateCalc10(TextBox10aResult.Text, TextBox10bResult.Text);
        }

        protected void StringCalculationButton_Click(object sender, EventArgs e)
        {
            TextBox11Result.Text = Ex2hCalculations.StringCalc01(TextBox11.Text);
            TextBox12Result.Text = Ex2hCalculations.StringCalc02(TextBox12.Text);
            TextBox13Result.Text = Ex2hCalculations.StringCalc03(TextBox13.Text);
            TextBox14Result.Text = Ex2hCalculations.StringCalc04(TextBox14.Text);
            TextBox15Result.Text = Ex2hCalculations.StringCalc05(TextBox15.Text);
            TextBox16Result.Text = Ex2hCalculations.StringCalc06(TextBox16.Text);
            TextBox17Result.Text = Ex2hCalculations.StringCalc07(TextBox17.Text);
            TextBox18Result.Text = Ex2hCalculations.StringCalc08(TextBox18.Text);
            TextBox19Result.Text = Ex2hCalculations.StringCalc09(TextBox19.Text);
            Label20Result.Text = Ex2hCalculations.StringCalc10(TextBox17.Text, TextBox18.Text, TextBox19.Text);
        }
    }
}
