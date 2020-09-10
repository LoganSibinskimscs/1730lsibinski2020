using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsibinski1f1
{
    public partial class frmCurrancyConverterV2 : Form
    {
        public frmCurrancyConverterV2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCurrancyConverterV2_Load(object sender, EventArgs e)
        {
            btnAustralianDollar.BackgroundImage = picAustralia.Image;
            btnBhutaneseNgultrum.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRicanColon.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrancy.Text = btnAustralianDollar.Text + ": ";
            txtRate.Text = "0.737356";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrancy.Focus();
        }

        private void btnAustralianDollar_Click(object sender, EventArgs e)
        {
            btnAustralianDollar.BackgroundImage = picAustralia.Image;
            btnBhutaneseNgultrum.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRicanColon.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrancy.Text = btnAustralianDollar.Text + ": ";
            txtRate.Text = "0.737356";

            txtCurrancy.Focus();
        }

        private void btnBhutaneseNgultrum_Click(object sender, EventArgs e)
        {
            btnBhutaneseNgultrum.BackgroundImage = picBhutanese.Image;
            btnAustralianDollar.BackgroundImage = picAustraliaDim.Image;
            btnCostaRicanColon.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrancy.Text = btnBhutaneseNgultrum.Text + ": ";
            txtRate.Text = "0.0136924";


            txtCurrancy.Focus();
        }

        private void btnCostaRicanColon_Click(object sender, EventArgs e)
        {
            btnCostaRicanColon.BackgroundImage = picCostaRica.Image;
            btnAustralianDollar.BackgroundImage = picAustraliaDim.Image;
            btnBhutaneseNgultrum.BackgroundImage = picBhutaneseDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrancy.Text = btnCostaRicanColon.Text + ": ";
            txtRate.Text = "0.00168171";


            txtCurrancy.Focus();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralianDollar.BackgroundImage = picAustraliaDim.Image;
            btnBhutaneseNgultrum.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRicanColon.BackgroundImage = picCostaRicaDim.Image;
            lblCurrancy.Text = btnEuro.Text + ": ";
            txtRate.Text = "1.19135";


            txtCurrancy.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrancy.Text) * Convert.ToDecimal(txtRate.Text)
            ).ToString("0.00");
        }

        private void txtCurrancy_Enter(object sender, EventArgs e)
        {
            txtCurrancy.SelectAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrancy.Text = "0.00";
            txtRate.Text = "0.737356";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = "";
            lblCurrancy.Text = btnAustralianDollar.Text + ": ";
            btnAustralianDollar.BackgroundImage = picAustralia.Image;
            btnBhutaneseNgultrum.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRicanColon.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;

            txtCurrancy.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtTotalUSD.Text) + Convert.ToDecimal(txtUSDollars.Text)
            ).ToString("0.00");

            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;

            txtCurrancy.Focus();
        }

        private void txtRate_Enter(object sender, EventArgs e)
        {
            txtRate.SelectAll();
        }
    }
}
