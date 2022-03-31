using System;
using System.Drawing;
using System.Windows.Forms;

namespace EvenOdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String inputtedNum = this.textBox1.Text;
            int num;

            if(inputtedNum.Length == 0)
            {
                showError("Please enter a number");
                return;
            }

            if (!int.TryParse(inputtedNum, out num)) {
                showError("Please enter a valid number");
                return;
            }

            if(num % 2 == 0)
            {
                showSuccess(num.ToString() + " is a even number");
               
            }
            else
            {
                showSuccess(num.ToString() + " is an odd number");

            }
        }

        private void showError(String message)
        {
            this.output_label.Text = message;
            this.output_label.Visible = true;
            this.output_label.ForeColor = Color.Red;
        }

        private void showSuccess(String message)
        {
            this.output_label.Text = message;
            this.output_label.Visible = true;
            this.output_label.ForeColor = Color.Green;
        }

        private void output_label_Click(object sender, EventArgs e)
        {

        }
    }
}
