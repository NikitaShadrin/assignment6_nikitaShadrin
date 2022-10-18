using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_6
{
    public partial class Form1 : Form
    {
        int rand_num;

        public Form1()
        {
            InitializeComponent();
        }

        public int generate_rand_num()
        {
            Random rnd = new Random();
            rand_num = rnd.Next(1, 4);
            return rand_num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand_num = generate_rand_num();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rand_num == 2)
            {
                MessageBox.Show("The computer chose Paper. You lose!");
            }
            else if (rand_num == 3)
            {
                MessageBox.Show("The computer chose Scissors. You win!");
            }
            else
            {
                MessageBox.Show("It's a tie!");
            }
                rand_num = generate_rand_num();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rand_num == 3)
            {
                MessageBox.Show("The computer chose Scissors. You lose!");
            }
            else if (rand_num == 1)
            {
                MessageBox.Show("The computer chose Rock. You win!");
            }
            else
            {
                MessageBox.Show("It's a tie!");
            }
            rand_num = generate_rand_num();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rand_num == 1)
            {
                MessageBox.Show("The computer chose Rock. You lose!");
            }
            else if (rand_num == 2)
            {
                MessageBox.Show("The computer chose Paper. You win!");
            }
            else
            {
                MessageBox.Show("It's a tie!");
            }
            rand_num = generate_rand_num();
        }
    }
}
