using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExceptionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void doSomething()
        {
            int num1, num2, result;
            MessageBox.Show("Message", "Title",
         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            try
            {
                num1 = Int32.Parse(textBox1.Text);
            }
            catch (FormatException ex)
            {
                textBox1.Text = "FORMAT1 ERROR";
                return;
            }
            try
            {
                num2 = Int32.Parse(textBox2.Text);
            }
            catch (FormatException ex)
            {
                textBox1.Text = "FORMAT2 ERROR";
                return;
            }
            try
            {
                result = num1 / num2;
            }
            catch(System.DivideByZeroException ex)
            {
                textBox1.Text = "DIV ZERO";
               System.InvalidOperationException argEx = new System.InvalidOperationException("this operation isn't allowed");
                throw argEx;
            }


                textBox1.Text = "result = "+result;
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            try
            {
                doSomething();
            }
            catch(System.InvalidOperationException ex)
            {
                textBox1.Text = "Yikes!!!";
            }
            
        }
    }
}
