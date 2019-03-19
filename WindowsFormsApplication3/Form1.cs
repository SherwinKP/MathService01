using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.MathService1;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            MathServiceClient loClient = new MathServiceClient();


            int lonum1 = Convert.ToInt32(textboxnum1.Text.Trim());
            int lonum2 = Convert.ToInt32(textboxnum2.Text.Trim());
            /*           
            #pragma warning disable CS0168 // Variable is declared but never used
                        catch (Exception exception)
            #pragma warning restore CS0168 // Variable is declared but never used
                        {
               */


            if (comboBox1.Text == "Add")
            {
                txtresult.Text = loClient.Add(lonum1, lonum2).ToString();
            }
            else if (comboBox1.Text == "Subtract")
            {
                txtresult.Text = loClient.Subtract(lonum1, lonum2).ToString();
            }
            else if (comboBox1.Text == "Multiply")
            {
                txtresult.Text = loClient.Multiply(lonum1, lonum2).ToString();
            }
            else
            {
                if (lonum2 == 0)
                {
                    txtresult.Text = "Error";
                }
                else
                    txtresult.Text = loClient.Divide(lonum1, lonum2).ToString();
            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
