using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            op.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(input1.Text.Trim());
            int num2 = int.Parse(input2.Text.Trim());
            switch (op.Text.Trim())
            {
                case "+":
                    result.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    result.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    result.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    result.Text = (num1 / num2).ToString();
                    break;
                default:
                    result.Text = "结果错误!";
                    break;
            }
        }
    }
}
