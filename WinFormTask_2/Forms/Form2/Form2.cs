using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask_2.Forms.Form2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double result = 0;
        double number = 0;
        double mults = 1;
        double divs = 1;

        bool isPlus = false;
        bool isMinus = false;
        bool isDiv = false;
        bool isMult = false;


        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void AC_button_Click(object sender, EventArgs e)
        {
            mults = 1;
            number = 0;
            result = 0;
            textBox1 .Text = "0";
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") return;
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "0";
            number = double.Parse(textBox1.Text);
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "1";
            number = double.Parse(textBox1.Text);
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "2";
            number = double.Parse(textBox1.Text);
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "3";
            number = double.Parse(textBox1.Text);
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "4";
            number = double.Parse(textBox1.Text);
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "5";
            number = double.Parse(textBox1.Text);
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "6";
            number = double.Parse(textBox1.Text);
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "7";
            number = double.Parse(textBox1.Text);
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "8";
            number = double.Parse(textBox1.Text);
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            if (textBox1.Text.Length == textBox1.MaxLength) return;
            number = 0;

            textBox1.Text += "9";
            number = double.Parse(textBox1.Text);
        }

        private void minus_plus_button_Click(object sender, EventArgs e)
        {
            number *= -1;
            textBox1.Text = number.ToString();
           
        }

        private void faiz_button_Click(object sender, EventArgs e)
        {
            number /= 100;
            textBox1.Text = number.ToString();
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            isPlus = true;
            textBox1.Text = "";
            result += number;
         
            
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            isMinus = true;
            textBox1.Text = "";
            result += number;
          
            
            
        }

        private void mult_button_Click(object sender, EventArgs e)
        {
            isMult = true;
            textBox1.Text = "";
            mults *= number;  
        }

        private void divide_button_Click(object sender, EventArgs e)
        {
            isDiv = true;
            textBox1.Text = "";
            if (result == 0) result = number;

            else divs *= number;
           
            
        }

        private void equal_button_Click(object sender, EventArgs e)
        {

            if (isPlus)
            {
                isPlus = false;
                result += number;
            }

            else if (isMinus)
            {
                isMinus = false;
                result -= number;
            }

            else if (isMult)
            {
                isMult = false;
                if (result == 0) result = 1;
                result *= (number * mults) / result;
            }
            
            else if(isDiv)
            {
                isDiv = false;
                result /= (divs * number)/divs;
            }
            textBox1.Text = result.ToString();
        }

        private void colon_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") return;

            string text = number.ToString() + ",1";
            number = double.Parse(text);
            textBox1.Text = number.ToString();
        }

       
    }
}
