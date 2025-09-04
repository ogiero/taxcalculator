using System;
using System.Globalization;
using System.Windows.Forms;

namespace NarposTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Yearselectionchange(null, null);
            Rbforward_CheckedChanged(null, null);

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBaseAmount.Text,NumberStyles.Any,CultureInfo.CurrentCulture,out decimal baseamount))
            {
                if (rb2023.Checked)
                {
                    if (rbForward.Checked)
                    {
                        Calculateforward2023(baseamount);
                    }
                    else
                    {
                        Calculatebackward2023(baseamount);
                    }
                }
                else
                {
                    if (rbForward.Checked)
                    {
                        Calculateforward2022(baseamount);
                    }
                    else
                    {
                        Calculatebackward2022(baseamount);
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please enter a valid amount...", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBaseAmount.Focus();
            }
        }
        private void Calculateforward2023(decimal baseamount)
        {
            decimal tllevy = baseamount * 0.01m;
            decimal getFundLevy = baseamount * 0.025m;
            decimal CovidLevy = baseamount * 0.01m;
            decimal Nhil = baseamount * 0.025m;
            decimal amountbeforevat = baseamount + tllevy + getFundLevy + CovidLevy + Nhil;
            decimal VAT = amountbeforevat * 0.15m;
            decimal totalamount = amountbeforevat + VAT;
            Resultswrite2023(baseamount,tllevy, getFundLevy, CovidLevy, Nhil, amountbeforevat, VAT, totalamount);


        }
        private void Calculatebackward2023(decimal totalamount)
        {
            decimal rate = (1 + 0.01m + 0.025m + 0.01m + 0.025m) * (1 + 0.15m);
            decimal baseamount= Math.Round(totalamount / rate,2);
            
            decimal tllevy = baseamount * 0.01m;
            decimal getFundLevy = baseamount * 0.025m;
            decimal CovidLevy = baseamount * 0.01m;
            decimal Nhil = baseamount * 0.025m;
            decimal amountbeforevat = baseamount + tllevy + getFundLevy + CovidLevy + Nhil;
            decimal VAT = amountbeforevat * 0.15m;
            
            Resultswrite2023(baseamount, tllevy, getFundLevy, CovidLevy, Nhil, amountbeforevat, VAT, totalamount);
            
        }
        private void Calculateforward2022(decimal baseamount)
        {
            decimal  tllevy = baseamount * 0.01m;
            decimal combinedtax = baseamount * 0.06m;
            decimal amountbeforevat = baseamount + tllevy + combinedtax;
            decimal VAT = amountbeforevat * 0.125m;
            decimal totalamount = amountbeforevat + VAT;

            Resultswrite2022(baseamount, tllevy, combinedtax, amountbeforevat, VAT, totalamount);
        }
        private void Calculatebackward2022(decimal totalamount)
        {
            decimal rate = (1 + 0.01m + 0.06m) * (1 + 0.125m);
            decimal baseamount = Math.Round(totalamount / rate, 2);
            decimal tllevy = baseamount * 0.01m;
            decimal combinedtax = baseamount * 0.06m;
            decimal amountbeforevat = baseamount + tllevy + combinedtax;
            decimal VAT = amountbeforevat * 0.125m;
            Resultswrite2022(baseamount, tllevy, combinedtax, amountbeforevat, VAT, totalamount);
            
        }
        private void Resultswrite2023(decimal baseamount, decimal tllevy, decimal getFundLevy, decimal CovidLevy, decimal Nhil, decimal amountbeforevat, decimal VAT, decimal totalamount)
        {
            
            txtTlLevy.Text = tllevy.ToString("N2");
            txtGetFundLevy.Text = getFundLevy.ToString("N2");
            txtCovidLevy.Text = CovidLevy.ToString("N2");
            txtNhil.Text = Nhil.ToString("N2");
            txtamountBeforeVat.Text = amountbeforevat.ToString("N2");
            txtVAT.Text = VAT.ToString("N2");
            //txtTotalAmount.Text = totalamount.ToString("N2");
            txtexclusive.Text = baseamount.ToString("N2");
            txtinclusive.Text = totalamount.ToString("N2");
           


        }
        private void Resultswrite2022(decimal baseamount, decimal tllevy, decimal combinedtax, decimal amountbeforevat, decimal VAT, decimal totalamount)
        {
            
            txtTlLevy.Text = tllevy.ToString("N2");
            txtGetFundLevy.Text = combinedtax.ToString("N2");
            txtCovidLevy.Text = "0.00";
            txtNhil.Text = "0.00";
            txtamountBeforeVat.Text = amountbeforevat.ToString("N2");
            txtVAT.Text = VAT.ToString("N2");
            //txtTotalAmount.Text = totalamount.ToString("N2");
            txtexclusive.Text = baseamount.ToString("N2");
            txtinclusive.Text = totalamount.ToString("N2");
        }
        private void TxtBaseAmount_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Yearselectionchange(object sender, EventArgs e)
        {
            if (rb2023.Checked)
            {
                lblGetFund.Text = "GETFund Levy (2.5%)";
                lblCovid.Text = "COVID Levy (1%)";
                lblNhil.Text = "NHIL (2.5%)";
                lblVAT.Text = "VAT (15%)";
                lblCovid.Visible = true;
                txtCovidLevy.Visible = true;
                lblNhil.Visible = true;
                txtNhil.Visible = true;
            }
            else
            {
                lblGetFund.Text = "Combined Tax (6%)";
                lblVAT.Text = "VAT (12.5%)";
                lblCovid.Visible = false;
                txtCovidLevy.Visible = false;
                lblNhil.Visible = false;
                txtNhil.Visible = false;
            }
            
        }
       
        private void Rbforward_CheckedChanged(object sender, EventArgs e)
        {
            lblgiristuru.Text = "Base Amount (Excluding Taxes)";
            //lblTotalAmount.Visible = true;
            //txtTotalAmount.Visible = true;
        }


        private void rbBackWard_CheckedChanged_1(object sender, EventArgs e)
        {
            lblgiristuru.Text = "Total Amount (Including Taxes)";
            lblgiristuru.Visible = true;
            txtBaseAmount.Visible = true;
            //lblTotalAmount.Visible = false;
            //txtTotalAmount.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
