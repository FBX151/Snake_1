using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc
{
    class CalcClass
    {
        public double first_number;
        public string operation;
        public double second_number;
        public double result;
        public double memory;
        public double mplus;
        public double number;
        public int b;
        
       
       



        public void calculate()
        {
            switch (operation)
            {
                case "+":
                    
                   result = first_number + second_number;
                    
                    
                    break;

                case "-":
                    result = first_number - second_number;
                    break;
                case "/":
                    result = first_number / second_number;
                    break;
                case "*":
                    result = first_number * second_number;
                    break;
                case "%":
                    result = (first_number * second_number) / 100;
                    break;

                case "x^y":
                    result = Math.Pow(first_number, second_number);

                    break;
                case "yVx":
                    result = Math.Pow(first_number, 1.0 / second_number);
                    break;
 }



        }
        }
}
