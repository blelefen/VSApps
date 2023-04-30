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

namespace CalkWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calc C;
        
        public MainWindow()
        {
            InitializeComponent();
            C = new Calc();
            Label.Content = "0";
            
            
        }

        private bool CanPress()
        {
            if (!Button_Minus.IsEnabled)
                return false;
            if (!Button_Div.IsEnabled)
                return false;
            if (!Button_Mult.IsEnabled)
                return false;
            if (!Button_Plus.IsEnabled)
                return false;

            return true;
        }
        private void FreeButtons()
        {
            Button_Minus.IsEnabled = true;
            Button_Plus.IsEnabled = true;
            Button_Mult.IsEnabled = true;
            Button_Div.IsEnabled = true;

        }
        private void CorrectNumber()
        {
            string str = Label.Content.ToString();
            if(str.IndexOf('∞') != -1)
            {
                str = str.Substring(0, str.Length - 1);
            }
            if (str[0] == '0' && (str.IndexOf(",") != 1))
                str = str.Remove(0, 1);
            if (str[0] == '-')
                if (str[1] == '0' && (str.IndexOf(",") != 2))
                    str = str.Remove(1, 1);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "1";
            CorrectNumber();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "2";
            CorrectNumber();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "3";
            CorrectNumber();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "4";
            CorrectNumber();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "5";
            CorrectNumber();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "6";
            CorrectNumber();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "7";
            CorrectNumber();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "8";
            CorrectNumber();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            Label.Content += "0";
            CorrectNumber();

        }





        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Label.Content));
                Button_Plus.IsEnabled = false;
                Label.Content = "0";
            }

        }

        private void Button_result_Click(object sender, RoutedEventArgs e)
        {
            if (Button_Mult.IsEnabled)
                Label.Content = C.Multiplication(Convert.ToDouble(Label.Content)).ToString();
            if (Button_Div.IsEnabled)
                Label.Content = C.Division(Convert.ToDouble(Label.Content)).ToString();
            if (Button_Plus.IsEnabled)
                Label.Content = C.Sum(Convert.ToDouble(Label.Content)).ToString();
            if (Button_Minus.IsEnabled)
                Label.Content = C.Substraction(Convert.ToDouble(Label.Content)).ToString();

        }
        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Label.Content));
                Button_Minus.IsEnabled = false;
                Label.Content = "0";
            }
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            FreeButtons();
            Label.Content = "0";
            C.Clear_A();
        }

        private void Button_Change_Click(object sender, RoutedEventArgs e)
        {
            string str = Label.Content.ToString();

            if (str[0] == '-')
            {
                str = str.Remove(0, 1);
            }
            else
            {
                str = '-' + str;
            }
            Label.Content = str;
        }

        private void Button_Point_Click(object sender, RoutedEventArgs e)
        {
            string str = Label.Content.ToString();
            if((str.IndexOf(',') == -1) && (str.IndexOf('∞')==-1))
            {
                str += ",";
            }

        }

        private void Button_Mult_Click(object sender, RoutedEventArgs e)
        {
            if(CanPress())
            {
                C.Put_A(Convert.ToDouble(Label.Content));
                Button_Mult.IsEnabled = false;
                Label.Content = "0";
            }
        }

        private void Button_Div_Click(object sender, RoutedEventArgs e)
        {
            if(CanPress())
            {
                C.Put_A(Convert.ToDouble(Label.Content));
                Button_Div.IsEnabled = false;
                Label.Content = "0";
            }
        }

        private void Button_square_Click(object sender, RoutedEventArgs e)
        {
            if(CanPress())
            {
                C.Put_A(Convert.ToDouble(Label.Content));
                Label.Content = C.Square().ToString();
                C.Clear_A();
                FreeButtons();
            }
        }

        private void Button_root_Click(object sender, RoutedEventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(Label.Content));
                Label.Content = C.Sqrt().ToString();
                C.Clear_A();
                FreeButtons();
            }
        }
    }



    
}
