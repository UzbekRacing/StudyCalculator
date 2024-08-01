using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace StudyCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        string CalTotal;
        float num1;
        float num2;
        string option;
        float result;
        string color = "white";

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button0.Text;
        }

        private void buttonPoint_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + buttonPoint.Text;
        }

        private void buttonSum_Click_1(object sender, EventArgs e)
        {
            option = "+";
            num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonMin_Click_1(object sender, EventArgs e)
        {
            option = "-";
            num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonMul_Click_1(object sender, EventArgs e)
        {
            option = "*";
            num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonDiv_Click_1(object sender, EventArgs e)
        {
            option = "/";
            num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void buttonEql_Click_1(object sender, EventArgs e)
        {
            num2 = float.Parse(textBox1.Text);

            switch (option)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2; 
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
                textBox1.Text = result + "";
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (color == ("white"))
            {
                BackColor = Color.Black;
                color = "black";
            }
            else if (color == ("black"))
            {
                BackColor = Color.Orange;
                color = "orange";
            }
            else if (color == ("orange"))
            {
                BackColor = Color.White;
                color = "white";
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"d:\проект практика\1.txt"))
            {
                sw.Write(textBox1.Text);
            }
        }
    }
}
