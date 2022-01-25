using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calculator = new Calculator();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = tmp.Text;
            else
                textBox1.Text = textBox1.Text + tmp.Text;
        }

        
        private void power2_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.power2(textBox1.Text).ToString(); 
        }

        private void button14_Click(object sender, EventArgs e) // input buttons 0-9
        {
            if (calculator.input(sender, textBox1.Text).clear)
            {
                textBox1.Text = "";
            }
            textBox1.Text = calculator.input(sender, textBox1.Text).text;
        }

        
        private void operation_Click(object sender, EventArgs e)
        {
            calculator.getOperation(sender, textBox1.Text);

        }

        private void equals_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.equals(textBox1.Text);
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            textBox1.Text= calculator.sqrt(textBox1.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.clear(textBox1.Text).ToString();
        }

        private void divide1ByX_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.divide1ByX(textBox1.Text).ToString();
        }

        private void SwitchSign_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.SwitchSign(textBox1.Text);
        }

        private void saveMem_Click(object sender, EventArgs e)
        {
            calculator.saveMem(textBox1.Text);
        }

        private void addMem_Click(object sender, EventArgs e)
        {
            textBox1.Text=calculator.addMem(textBox1.Text);
        }

        private void subMem_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.subMem(textBox1.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            textBox1.Text = "";
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                textBox1.Text = (textBox1.Text + tmp[i]);
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
    }
}
