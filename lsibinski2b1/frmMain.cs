using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsibinski2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;

            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutanese.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutanese.Text);
            decimal usdBhutan = amountBhutan * rateBhutan;

            decimal amountCostaRica = Convert.ToDecimal(txtAmountCostaRican.Text);
            decimal rateCostaRica = Convert.ToDecimal(txtRateCostaRican.Text);
            decimal usdCostaRica = amountCostaRica * rateCostaRica;

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);
            decimal usdEuro = amountEuro * rateEuro;

            decimal totalUSD = usdAustralia + usdBhutan + usdCostaRica + usdEuro;

            txtUSDAustralia.Text = usdAustralia.ToString("0.00");
            txtUSDBhutanese.Text = usdBhutan.ToString("0.00");
            txtUSDCostaRican.Text = usdCostaRica.ToString("0.00");
            txtUSDEuro.Text = usdEuro.ToString("0.00");
            txtTotalUSD.Text = totalUSD.ToString("0.00");
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.737356";
            txtAmountBhutanese.Text = "0.00";
            txtRateBhutanese.Text = "0.0136924";
            txtAmountCostaRican.Text = "0.00";
            txtRateCostaRican.Text = "0.00168171";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.19135";

            txtAmountAustralia.Focus();
        }
    }
}
