using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1: Form
    {
        CalcClass calc = new CalcClass();
        static int Ent =0;
        static double v;
        static int Z = 0;
        

        public Form1()
        {
            InitializeComponent();
            display.Text = "0";
        }
        private void numbers_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (display.Text == "0")
                display.Text = btn.Text;
            else
            {
                //display.Text = "";
                display.Text += btn.Text;
            }
        }
        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (display.Text == "")
            {
                calc.first_number =calc.second_number ;
            }
            else
            {
                calc.first_number = double.Parse(display.Text);
                calc.operation = btn.Text;
                display.Text = "";
            }
        }
        private void result_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Ent++;
            if (display.Text == "")
            {
                calc.second_number = calc.first_number;

                calc.calculate();
                display.Text = calc.result.ToString();
            }
            else
            {
                if (Ent == 1)
                {
                    calc.second_number = double.Parse(display.Text);
                    calc.calculate();
                    display.Text = calc.result.ToString();
                    v = calc.second_number;
                }
                else
                {
                    calc.first_number = double.Parse(display.Text);
                    calc.second_number = v;
                    calc.calculate();
                    display.Text = calc.result.ToString();
                }
            }
          

        }
        private void c_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            calc.first_number = 0;
            calc.second_number = 0;
            calc.result = 0;
            calc.operation = "";
            Z = 0;
            Ent = 0;


        }

        private void MS_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.memory = double.Parse(display.Text);

        }
        private void MR_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = "";
            display.Text = calc.memory.ToString();

        }
        private void Mplus_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.mplus = double.Parse(display.Text);
            calc.result = calc.memory + calc.mplus;
            calc.memory = calc.result;

        }
        private void Mminus_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.mplus = double.Parse(display.Text);
            calc.result = calc.memory - calc.mplus;
            calc.memory = calc.result;
        }
        private void MC_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.memory = 0;
        }
        private void CE_Click(object sender, EventArgs e0)
        {
            Button btn = sender as Button;
            calc.memory = 0;
            display.Text = (0).ToString();
            
           }
        private void v_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (display.Text.Contains("-"))
            {
                display.Text = "ERROR";
            }
            else
            {
                display.Text = Math.Sqrt(double.Parse(display.Text)).ToString();
            }
            


        }
        private void x_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text =( 1 / (double.Parse(display.Text))).ToString();
        }
        
        private void BS_click (object sender, EventArgs e)
        {
            string text = display.Text;
            int ind = text.Length - 1;
            
            text = text.Remove(ind);
            if (ind == 0)
            {
                text = "0";
            }

            display.Text = text;
        }
        private void QW_click (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = (double.Parse(display.Text) * double.Parse(display.Text)).ToString();
        }
        
        private void Z_click (object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            Z++;
            if (Z > 1)
            {
                display.Text += "";
            }
            else
            {
                display.Text += ",";
            }
           

        }
        private void Sin_click (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = Math.Sin((double.Parse(display.Text) * Math.PI) / 180).ToString();

        }
        private void Cos_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = Math.Cos((double.Parse(display.Text) * Math.PI) / 180).ToString();
        }
        private void Tan_click (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = Math.Tan((double.Parse(display.Text) * Math.PI) / 180).ToString();
        }
        public double F(double n)
            
        {
            double res = 1;
            for (int i  = 1; i <= n; ++i )
            {
                res *= i;
            }
            return res;
        }
        private void F_click (object sender, EventArgs e)
        {
            double n = double.Parse(display.Text);
            display.Text = F(n).ToString();
        }
        private void Zn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = (-1 *double.Parse( display.Text)).ToString();
        }
        private void EXP(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = Math.Exp(double.Parse(display.Text)).ToString();
        } 
    }


    }

