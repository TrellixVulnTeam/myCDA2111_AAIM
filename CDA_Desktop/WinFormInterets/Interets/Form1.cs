using libInterets;

namespace Interets
{
    public partial class Form1 : Form
    {

        List<string> dsPeriodicity;
        List<int> dsPeriodicityValue;
        Loan resultLoan;
        LoanViewModel validateLoan;
        string name;
        int interestRate;
        int duration;
        int amountLoan;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsPeriodicity = new List<string>() { "Mensuelle", "Bimestrielle", "Trimestrielle", "Semestrielle", "Annuelle" };
            dsPeriodicityValue = new List<int>() { 1, 2, 3, 6, 12 };
            lstPeriodicity.DataSource = dsPeriodicity;
            txtBoxName.Focus();        
            lblDurationMonth.Text = "1";
            rbtnSeven.Tag = 7;
            rbtnEight.Tag = 8;
            rbtnNine.Tag = 9;
            rbtnSeven.Checked = true;
        }
        private void lstPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LargeSmallScrollChange();
        }
        private void hsbDurationMonth_Scroll(object sender, ScrollEventArgs e)
        {
            lblDurationMonth.Text = hsbDurationMonth.Value.ToString();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            name = txtBoxName.Text;
            amountLoan = int.Parse(txtBoxLoan.Text);
            duration = int.Parse(lblDurationMonth.Text);
            resultLoan = new Loan(name, amountLoan, duration, interestRate);
            validateLoan = new LoanViewModel(resultLoan);
            if (!validateLoan.IsNameValid(name))
            {
                double result = resultLoan.AmountPeriodicalCalculation();
                result = result * dsPeriodicityValue[lstPeriodicity.SelectedIndex];
                result = Math.Round(result, 2);
                lblResultAmount.Text = result.ToString();
                lblNumberOfPayment.Text = (int.Parse(lblDurationMonth.Text) / dsPeriodicityValue[lstPeriodicity.SelectedIndex]).ToString();
                lblNumberOfPayment.Visible = true;
                lblResultAmount.Visible = true;
            }
            else MessageBox.Show("toto");
        }
        private void LargeSmallScrollChange()
        {
            int index = lstPeriodicity.SelectedIndex;
            int value = dsPeriodicityValue[index];   
            hsbDurationMonth.LargeChange = value * 2;
            hsbDurationMonth.SmallChange = value;
            hsbDurationMonth.Minimum = value;
            hsbDurationMonth.Maximum = 300 + (value * 2 - value );
            hsbDurationMonth.Value = value;
            lblDurationMonth.Text = value.ToString();
        }
        private void rbtnInterestRate_Checked(object sender, EventArgs e)
        {
            RadioButton radioButtonChecked = (RadioButton)sender;
            interestRate = int.Parse(radioButtonChecked.Tag.ToString());
        }
    }
}