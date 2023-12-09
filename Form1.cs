namespace CS311_FinalProject_RLV
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void Convert()
        {
            //Grams to ounces and vv
            if (rdoGramsO.Checked)
            {
                double grams = double.Parse(txtValue.Text);
                double ounces = grams / 28.35;
                lblResult.Text = "Result: " + ounces.ToString("#.##") + " oz";
            }

            if (rdoOuncesG.Checked)
            {
                double ounces = double.Parse(txtValue.Text);
                double grams = ounces * 28.35;
                lblResult.Text = "Result: " + grams.ToString("#.##") + " g";
            }

            //Feet to meters and vv
            if (rdoFeetM.Checked)
            {
                double feet = double.Parse(txtValue.Text);
                double meters = feet / 3.281;
                lblResult.Text = "Result: " + meters.ToString("#.##") + " m";
            }

            if (rdoMetersF.Checked)
            {
                double meters = double.Parse(txtValue.Text);
                double feet = meters * 3.281;
                lblResult.Text = "Result: " + feet.ToString("#.##") + " ft";
            }

            //Kilometers to miles and vv

            if (rdoKiloM.Checked)
            {
                double kilometers = double.Parse(txtValue.Text);
                double miles = kilometers / 1.609;
                lblResult.Text = "Result: " + miles.ToString("#.##") + " mi";
            }

            if (rdoMilesK.Checked)
            {
                double miles = double.Parse(txtValue.Text);
                double kilometers = miles * 1.609;
                lblResult.Text = "Result: " + kilometers.ToString("#.##") + " km";
            }

            //Kilograms to pounds and vv
            if (rdoKilP.Checked)
            {
                double kilograms = double.Parse(txtValue.Text);
                double lbs = kilograms * 2.205;
                lblResult.Text = "Result: " + lbs.ToString("#.##") + " lbs";
            }

            if (rdoPoundsK.Checked)
            {
                double lbs = double.Parse(txtValue.Text);
                double kilograms = lbs / 2.205;
                lblResult.Text = "Result: " + kilograms.ToString("#.##") + " kg";
            }

            //Celsius to Fahrenheit and vv
            if (rdoCtoF.Checked)
            {
                double c = double.Parse(txtValue.Text);
                double f = (c * 9 / 5) + 32;
                lblResult.Text = "Result: " + f.ToString("#.##") + " F°";
            }

            if (rdoFtoC.Checked)
            {
                double f = double.Parse(txtValue.Text);
                double c = (f - 32) * 5 / 9;
                lblResult.Text = "Result: " + c.ToString("#.##") + " C°";
            }


        }//end Convert()


        private void rdoMilesK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
            lblResult.Text = "Result:";
        }

        private void lblConversionCalc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}