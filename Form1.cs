using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWCalc
{
    public partial class Form1 : Form
    {
        Calculate calculator;
        string operation;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculate();
            tb.Text = "0";
            lbl.Text = "0";
            btn_Equal.Enabled = false;
        }

        private void AddNumber(string number)
        {
            tb.Text = tb.Text + number;

            if (tb.Text.IndexOf("∞") != -1)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
            if (tb.Text[0] == '0' && (tb.Text.IndexOf(".") != 1))
            {
                tb.Text = tb.Text.Remove(0, 1);
            }
            if (tb.Text[0] == '-')
            {
                if (tb.Text[1] == '0' && (tb.Text.IndexOf(".") != 2))
                {
                    tb.Text = tb.Text.Remove(1, 1);
                }
            }
        }

        private void PressedButton()
        {
            btn_Add.Enabled = false;
            btn_Subtract.Enabled = false;
            btn_Multiply.Enabled = false;
            btn_Divide.Enabled = false;
            //btn_PlusMinus.Enabled = false;
            btn_Sqrt.Enabled = false;
            btn_Equal.Enabled = true;
        }

        private void EnableButtons()
        {
            btn_Add.Enabled = true;
            btn_Subtract.Enabled = true;
            btn_Multiply.Enabled = true;
            btn_Divide.Enabled = true;
            //btn_PlusMinus.Enabled = true;
            btn_Sqrt.Enabled = true;
            btn_Equal.Enabled = false;
        }

        private void SaveFirstNumber()
        {
            calculator.SaveFirstNumber(double.Parse(tb.Text));
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            calculator.ClearFirstNumber();
            tb.Text = "0";
            lbl.Text = "0";
            EnableButtons();
        }

        private void btn_PlusMinus_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                return;
            }
            if (tb.Text[0] == '-')
            {
                tb.Text = tb.Text.Remove(0, 1);
            }
            else
            {
                tb.Text = '-' + tb.Text;
            } 
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            AddNumber("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
           AddNumber("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            AddNumber("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            AddNumber("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            AddNumber("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            AddNumber("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            AddNumber("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            AddNumber("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            AddNumber("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            AddNumber("0");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SaveFirstNumber();
            operation = "add";
            PressedButton();
            lbl.Text = tb.Text + "+";
            tb.Text = "0";
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            SaveFirstNumber();
            operation = "subtract";
            PressedButton();
            lbl.Text = tb.Text + "-";
            tb.Text = "0";
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            SaveFirstNumber();
            operation = "multiply";
            PressedButton();
            lbl.Text = tb.Text + "*";
            tb.Text = "0";
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            SaveFirstNumber();
            operation = "divide";
            PressedButton();
            lbl.Text = tb.Text + "/";
            tb.Text = "0";
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            if (tb.Text[0] == '-')
            {
                MessageBox.Show("Number must be positive!");
            }
            else
            {
                calculator.SaveFirstNumber(double.Parse(tb.Text));
                tb.Text = calculator.Sqrt().ToString();
                lbl.Text = tb.Text;
                calculator.ClearFirstNumber();
            }  
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "add":
                    lbl.Text = lbl.Text + tb.Text + "=";
                    tb.Text = calculator.Add(double.Parse(tb.Text)).ToString();
                    break;
                case "subtract":
                    lbl.Text = lbl.Text + tb.Text + "=";
                    tb.Text = calculator.Subtract(double.Parse(tb.Text)).ToString();
                    break;
                case "multiply":
                    lbl.Text = lbl.Text + tb.Text + "=";
                    tb.Text = calculator.Multiply(double.Parse(tb.Text)).ToString();
                    break;
                case "divide":
                    if (tb.Text == "0")
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        return;
                    }
                    lbl.Text = lbl.Text + tb.Text + "=";
                    tb.Text = calculator.Divide(double.Parse(tb.Text)).ToString();
                    break;
                default:
                    break;
            }

            calculator.ClearFirstNumber();
            EnableButtons();
        }

        private void MR_Click(object sender, EventArgs e)
        {
            tb.Text = calculator.MR().ToString();
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            calculator.MC();
        }

        private void btn_MPlus_Click(object sender, EventArgs e)
        {
            calculator.MAdd(double.Parse(tb.Text));
        }

        private void btn_MMinus_Click(object sender, EventArgs e)
        {
            calculator.MSubtract(double.Parse(tb.Text));
        }

        private void btn_MS_Click(object sender, EventArgs e)
        {
            calculator.MS(double.Parse(tb.Text));
        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            if ((tb.Text.IndexOf(".") == -1) && (tb.Text.IndexOf("∞") == -1))
            {
                tb.Text = tb.Text + ".";
            }    
        }
    }
}
