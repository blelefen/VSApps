using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KalkWPFfromINET
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calk C;
        
        public MainWindow()
        {
            InitializeComponent();
            C = new Calk();

            labelNumber.Content = "0";


        }


        public void CorrectNumber()
        {
            string str;
            str = labelNumber.Content.ToString();
            
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (str.IndexOf("∞") != -1)
                str = str.Substring(0, str.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (str[0] == '0' && (str.IndexOf(",") != 1))
                labelNumber.Content = str.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (str[0] == '-')
                if (str[1] == '0' && (str.IndexOf(",") != 2))
                    str = str.Remove(1, 1);
            labelNumber.Content = str;
        }


        private bool CanPress()
        {
            if (!buttonMult.IsEnabled)
                return false;

            if (!buttonDiv.IsEnabled)
                return false;

            if (!buttonPlus.IsEnabled)
                return false;

            if (!buttonMinus.IsEnabled)
                return false;

            if (!buttonSqrtX.IsEnabled)
                return false;

            if (!buttonDegreeY.IsEnabled)
                return false;

            return true;
        }




        

        private void FreeButtons()
        {
            buttonMult.IsEnabled = true;
            buttonDiv.IsEnabled = true;
            buttonPlus.IsEnabled = true;
            buttonMinus.IsEnabled = true;
            buttonSqrtX.IsEnabled = true;
            buttonDegreeY.IsEnabled = true;
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Content = "0";

            C.Clear_A();
            FreeButtons();

            
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content = "0";

            C.Clear_A();
            FreeButtons();

        }

        private void buttonChangeSign_Click(object sender, RoutedEventArgs e)
        {
            string str = labelNumber.Content.ToString();

            if (str[0] == '-')
                labelNumber.Content = str.Remove(0, 1);
            else
                str = "-" + str;
            labelNumber.Content = str;
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "0";

            CorrectNumber();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "1";

            CorrectNumber();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "6";

            CorrectNumber();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            labelNumber.Content += "9";

            CorrectNumber();
        }

        private void buttonCalk_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!buttonMult.IsEnabled)
                    labelNumber.Content = C.Multiplication(Convert.ToDouble(labelNumber.Content)).ToString();

                if (!buttonDiv.IsEnabled)
                    labelNumber.Content = C.Division(Convert.ToDouble(labelNumber.Content)).ToString();

                if (!buttonPlus.IsEnabled)
                    labelNumber.Content = C.Sum(Convert.ToDouble(labelNumber.Content)).ToString();

                if (!buttonMinus.IsEnabled)
                    labelNumber.Content = C.Subtraction(Convert.ToDouble(labelNumber.Content)).ToString();

                if (!buttonSqrtX.IsEnabled)
                    labelNumber.Content = C.SqrtX(Convert.ToDouble(labelNumber.Content)).ToString();

                if (!buttonDegreeY.IsEnabled)
                    labelNumber.Content = C.DegreeY(Convert.ToDouble(labelNumber.Content)).ToString();

                C.Clear_A();
                FreeButtons();

                
            }
        }

        private void buttonMult_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Content));

                buttonMult.IsEnabled = false;

                labelNumber.Content = "0";
            }
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Content));

                buttonDiv.IsEnabled = false;

                labelNumber.Content = "0";
            }
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Content));

                buttonPlus.IsEnabled = false;

                labelNumber.Content = "0";
            }
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Content));

                buttonMinus.IsEnabled = false;

                labelNumber.Content = "0";
            }
        }
    }
}
