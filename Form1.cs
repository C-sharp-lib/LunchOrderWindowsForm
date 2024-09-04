using System;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rHamburger.Checked = false;
            this.Text = "Kevin Stradtman's Lunch Shack";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double mainCourse = 0;
            double additional = 0;

            if (rHamburger.Checked)
            {
                mainCourse = 6.95;
            }
            else if (rPizza.Checked)
            {
                mainCourse = 5.95;
            }
            else if (rSalad.Checked)
            {
                mainCourse = 4.95;
            }

            if (rHamburger.Checked)
            {
                if (cbFirstAddOn.Checked) additional += 0.75;
                if (cbSecondAddOn.Checked) additional += 0.75;
                if (cbThirdAddOn.Checked) additional += 0.75;
            }
            else if (rPizza.Checked) 
            {
                if (cbFirstAddOn.Checked) additional += 0.50;
                if (cbSecondAddOn.Checked) additional += 0.50;
                if (cbThirdAddOn.Checked) additional += 0.50;
            }
            else if (rSalad.Checked)
            {
                if (cbFirstAddOn.Checked) additional += 0.25;
                if (cbSecondAddOn.Checked) additional += 0.25;
                if (cbThirdAddOn.Checked) additional += 0.25;
            }
            double subtotal = mainCourse + additional;
            double tax = subtotal * 0.0775;
            double total = subtotal + tax;
            txtSubtotal.Text = subtotal.ToString("C");
            txtSalesTax.Text = tax.ToString("C");
            txtOrderTotal.Text = total.ToString("C");

        }
        private void ClearMain()
        {
            gbCondiments.Text = "";
            cbFirstAddOn.Text = "";
            cbSecondAddOn.Text = "";
            cbThirdAddOn.Text = "";
            cbFirstAddOn.Checked = false;
            cbSecondAddOn.Checked = false;
            cbThirdAddOn.Checked = false;
            rHamburger.Checked = false;
            rPizza.Checked = false;
            rSalad.Checked = false;
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            ClearMain();
        }

        private void rHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rHamburger.Checked)
            {
                gbCondiments.Text = "Add-on items ($.75/each)";
                cbFirstAddOn.Text = "Lettuce, Tomato, Onion";
                cbSecondAddOn.Text = "Ketchup, Mustard, Mayo";
                cbThirdAddOn.Text = "French Fries";
            }
        }

        private void rPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rPizza.Checked)
            {
                gbCondiments.Text = "Add-on items ($.50/each)";
                cbFirstAddOn.Text = "Pepperoni";
                cbSecondAddOn.Text = "Sausage";
                cbThirdAddOn.Text = "Olives";
            }
        }

        private void rSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rSalad.Checked)
            {
                gbCondiments.Text = "Add-on items ($.25/each)";
                cbFirstAddOn.Text = "Croutons";
                cbSecondAddOn.Text = "Bacon Bits";
                cbThirdAddOn.Text = "Bread Sticks";
            }
        }
    }
}
