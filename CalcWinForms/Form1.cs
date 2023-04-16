using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinForms
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {

            InitializeComponent();

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int one = Convert.ToInt32(textBox1.Text);
            int two = Convert.ToInt32(textBox2.Text);
            char and = Convert.ToChar(comboBox1.Text);

            double res = resClick(one,and,two);
            textBox3.Text = Convert.ToString(res);
        }

        public double resClick(int a,char b,int c)
        {
            double r=0;
            switch(b)

            { 
                case '+':
                    r = a + c;
                    break;
                case '-':
                    r = a - c;
                    break;
                case '*':
                    r = a * c;
                    break;
                case '/':
                    r = (double)a / c;
                    break;

            }
            return r;
        }

        
    }
}
