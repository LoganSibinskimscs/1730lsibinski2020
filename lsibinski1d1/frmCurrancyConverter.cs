using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsibinski1d1
{
    public partial class frmCurrancyConverter : Form
    {
        public frmCurrancyConverter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                    Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
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
        }

        private void bhutaneseTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutanese.Text = (
                    Convert.ToDecimal(txtAmountBhutanese.Text) * Convert.ToDecimal(txtRateBhutanese.Text)
                ).ToString("0.00");
        }

        private void costaRicanTextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRican.Text = (
                    Convert.ToDecimal(txtAmountCostaRican.Text) * Convert.ToDecimal(txtRateCostaRican.Text)
                ).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                    Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                    Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDBhutanese.Text)
                    + Convert.ToDecimal(txtUSDCostaRican.Text) + Convert.ToDecimal(txtUSDEuro.Text)
                ).ToString("0.00");
        }
    }
}
