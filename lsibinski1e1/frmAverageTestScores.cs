using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lsibinski1e1
{
    public partial class frmAverageTestScores : Form
    {
        public frmAverageTestScores()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTestOne.Text = "0";
            txtTestTwo.Text = "0";
            txtTestThree.Text = "0";
            txtAverage.Text = "";

            txtTestOne.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = ((
                     Convert.ToDecimal(txtTestOne.Text)
                     + Convert.ToDecimal(txtTestTwo.Text)
                     + Convert.ToDecimal(txtTestThree.Text)) / 3m
                 ).ToString("0.00");
        }
    }
}
