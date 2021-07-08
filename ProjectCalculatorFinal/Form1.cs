using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculatorFinal
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void disable()
        {
            result.Enabled = false;
            button2.Hide();
            button1.Show();
            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
            btnZero.Enabled = false;
            btnDot.Enabled = false;
            btnClear.Enabled = false;
            btnClearEntry.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnMultiply.Enabled = false;
            btnDivide.Enabled = false;
            btnEquals.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void enable()
        {
            result.Enabled = true;
            button2.Show();
            button1.Hide();
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
            btnZero.Enabled = true;
            btnDot.Enabled = true;
            btnClear.Enabled = true;
            btnClearEntry.Enabled = true;
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;
            btnEquals.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else 
                result.Text = result.Text + b.Text;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            lblEquation.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result.Clear();
            lblEquation.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (result.Text.Length > 0)
            {
                result.Text = result.Text.Remove(result.Text.Length - 1, 1);
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                btnEquals.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                lblEquation.Text = value + " " + operation;

            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                lblEquation.Text = value + " " + operation;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblEquation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch

            value = Int32.Parse(result.Text);
            operation = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable();
        }
    }
}
