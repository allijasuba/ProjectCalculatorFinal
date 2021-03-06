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
                if (b.Text == "sqrt")
                    result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                btnEquals.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                lblEquation.Text = value + " " + operation;
            }
            else if (b.Text == "sqrt")
            {
                result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                value = Math.Sqrt(Double.Parse(result.Text));
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
            value = Double.Parse(result.Text);
            operation = "";
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            result.Text = "3.14159";
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            Double a;

            a = Convert.ToDouble(result.Text) * Convert.ToDouble(result.Text);
            result.Text = System.Convert.ToString(a);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Double a;

            a = Convert.ToDouble(result.Text) / Convert.ToDouble(100);
            result.Text = System.Convert.ToString(a);
        }
    }
}
