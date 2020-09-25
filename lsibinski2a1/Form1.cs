using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsibinski2a1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal discountpercent = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountTotal = subtotal * discountpercent / 100m;
            decimal total = subtotal - discountTotal;
            txtDiscountAmount.Text = discountTotal.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
