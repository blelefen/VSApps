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
        int lastOper = 0;            //тип последней операции
        bool itog = false;            //был нажат равно
        double lastNum = 0;
        bool labelEmpty = true;      //поле последнего действия не было нажато ни одной цифры
        double a=0;
        

        bool b=false;               //защита от повторного нажатия кнопки действия

        double bilo = 0;
        double ekran = 0;


        public MainWindow()
        {
            InitializeComponent();
            Label.Content = null;
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
                
            }
            Label.Content += "1";
            b = false;
        }
        
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
               
            }
            Label.Content += "2";
            b = false;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
                
            }
            Label.Content += "3";
            b = false;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
            }
            Label.Content += "4";
            b = false;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
}
            Label.Content += "5";
            b = false;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
}
            Label.Content += "6";
            b = false;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
}
            Label.Content += "7";
            b = false;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
}
            Label.Content += "8";
            b = false;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
            }
            Label.Content += "9";
            b = false;
        }
         
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (labelEmpty == true)
            {
                itog = false;
                labelEmpty = false;
                Label.Content = null;
            }
            Label.Content += "0";
            b = false;
        }





        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            lastOper = 1;

            if (b == false)
            {
                if (labelEmpty == false)
                {
                    if (itog == false)
                    {
                        labelEmpty = true;
                        lastNum = Convert.ToDouble(Label.Content);
                        a = a + Convert.ToDouble(Label.Content);

                        Label.Content = a;
                        b = true;
                    }
                    else if (itog == true)
                    {
                        a =Convert.ToDouble(Label.Content);
                        b = true;
                    }
                }
                else if (labelEmpty == true)
                {
                    if (itog == true)
                    {
                        itog = false;
                        a = Convert.ToDouble(Label.Content);
                        Label.Content = a;
                        b = true;
                    }
                    else if (itog == false)
                    {
                        a = a + lastNum;
                        Label.Content = a;
                        b = true;
                    }

                }
            }
            else
            {

            }
            
        }

        private void Button_result_Click(object sender, RoutedEventArgs e)
        {
            

            if (labelEmpty == false)
            {
                if (lastOper == 0)
                {
                    Label.Content = "0";
                }

                else if (lastOper == 1)               //нажат ПЛЮС
                {

                    /*a = a + Convert.ToDouble(Label.Content);
                    lastNum = a;
                    Label.Content = a;*/

                }
                else if (lastOper == 2)
                {
                    ekran = Convert.ToDouble(Label.Content);
                    a = bilo - ekran;
                }
            }
            else if (labelEmpty == true)
            {
                if (itog == false)
                {
                    a = Convert.ToDouble(Label.Content);
                }
                else
                {
                    Label.Content = "0";
                    lastNum = 0;
                    a = 0;
                }
            }


            itog = true;
            labelEmpty = true;
            lastOper = 0;
            Label.Content = a;
            
            
        }




        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            lastOper = 2;              //последняя операция минус
            labelEmpty = true;          //была совершена операция
            if (Label.Content == null)
            {
                ekran = Convert.ToDouble(Label.Content);
            }
            else
            {

            }


            if (b == false)            //защита от двойного нажатия кнопок операций
            {
                b = true;

                if (itog == false)
                {
                    
                        bilo = Convert.ToDouble(Label.Content);
                        Label.Content = bilo - ekran;
                    
                }
                else if(itog==true)
                {
                    bilo = Convert.ToDouble(Label.Content);
                    
                }

            }




            else if (b==true)
            { }
            
        }

    }
}
