using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalkWPF
{
    class Calc : InterfaceCalc
    {
        private double a = 0;
        public void Clear_A()
        {
            a = 0;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public double Factorial()
        {
            double f = 1;
            for(int i=1;i<=a;i++)
            {
                f *= (double)i;
            }
            return f;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public void Put_A(double a)
        {
            this.a = a;
        }

        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        public double Square()
        {
            return Math.Pow(a, 2.0);
            
        }

        public double Substraction(double b)
        {
            return a - b;
        }

        public double Sum(double b)
        {
            return a + b;
        }
    }
}
