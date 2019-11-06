using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBayFees
{
    public partial class frmEBayCalc : Form
    {
        public frmEBayCalc()
        {
            InitializeComponent();
        }

        private void lblEbayFees_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSubtotal_Leave(object sender, EventArgs e)
        {
            Double subtotal;

            if (Double.TryParse(txtBoxSubtotal.Text, NumberStyles.Currency, null, out subtotal))
            {
                txtBoxSubtotal.Text = subtotal.ToString("C");
            }



        }
    }
}
