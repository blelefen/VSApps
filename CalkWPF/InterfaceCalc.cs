using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalkWPF
{
    interface InterfaceCalc
    {
        void Put_A(double a);
        void Clear_A();

        double Sum(double b);
        double Multiplication(double b);
        double Division(double b);
        double Substraction(double b);
        double Sqrt();
        double Square();
        double Factorial();

    }
}
