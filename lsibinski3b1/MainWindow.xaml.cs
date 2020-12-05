using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lsibinski3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            //0
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch {
                resultTextBox0.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox0a.Text); 
            }
            //2
            try
            {
                int months = Int32.Parse(this.inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox2b.Text);
                decimal monthlyIntrestRate = Decimal.Parse(this.inputTextBox2c.Text);
                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyIntrestRate, months);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch {
                resultTextBox2.Text = "";
                MessageBox.Show("Invalid input:\n"
                + this.inputTextBox2a.Text + "\n"
                + this.inputTextBox2b.Text + "\n"
                + this.inputTextBox2c.Text + "\n"); 
            }
            //4
            try
            {
                double fahrenheit = Double.Parse(this.inputTextBox4a.Text);
                double celsius = Ex3bCalculations.FahrenheitToCelsius(fahrenheit);
                resultTextBox4.Text = celsius.ToString("f1");
            }
            catch {
                resultTextBox4.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox4a.Text);
            }
            //6
            try
            {
                decimal hours = Decimal.Parse(this.inputTextBox6a.Text);
                decimal rate = Decimal.Parse(this.inputTextBox6b.Text);
                this.resultTextBox6.Text = Ex3bCalculations.GrossPay(hours, rate).ToString("c2");
            }
            catch
            {
                this.resultTextBox6.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox6a.Text + "\n"
                    + this.inputTextBox6b.Text);
            }
            //7
            try
            {
                this.resultTextBox7.Text = Ex3bCalculations.TotalHours(this.inputTextBox7a.Text).ToString("n2");
            }
            catch
            {
                this.resultTextBox7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox7a.Text);
            }
            //8
            try
            {
                decimal rate = Decimal.Parse(this.inputTextBox8b.Text);
                this.resultTextBox8.Text = Ex3bCalculations.GrossPay(this.inputTextBox8a.Text, rate).ToString("c2");
            }
            catch
            {
                this.resultTextBox8.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + this.inputTextBox8a.Text + "\n"
                    + this.inputTextBox8b.Text);
            }
            //3
            try
            {
                int months = Int32.Parse(this.inputTextBox3a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextBox3b.Text);
                decimal monthlyIntrestRate = Decimal.Parse(this.inputTextBox3c.Text);
                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyIntrestRate, months, ref futureValue);
                resultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextBox3.Text = "";
                MessageBox.Show("Invalid input:\n"
                + this.inputTextBox3a.Text + "\n"
                + this.inputTextBox3b.Text + "\n"
                + this.inputTextBox3c.Text + "\n");
            }
            //1
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextBox1a.Text);
                decimal discountPercent;
                Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextBox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                resultTextBox1.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox1a.Text);
            }
            //5
            try
            {
                double celsius = Double.Parse(this.inputTextBox5a.Text);
                double fahrenheit = 0.0;
                Ex3bCalculations.CelsiusToFahrenheit(celsius, out fahrenheit);
                resultTextBox5.Text = fahrenheit.ToString("f1");
            }
            catch
            {
                resultTextBox5.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextBox5a.Text);
            }
        }
    }
}
