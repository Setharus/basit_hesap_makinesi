using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("         Hoşgldiniz!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1 = 0, s2 = 0, topla;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            topla = s1 + s2;
            label4.Text = Convert.ToString(topla);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s1 = 0, s2 = 0, ks, bs, cikar;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            if(s1 < s2)
            {
                ks = s1;
                bs = s2;
            }
            else
            {
                ks = s2;
                bs = s1;
            }
            cikar = bs - ks;
            label4.Text = Convert.ToString(cikar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1 = 0, s2 = 0, ks, bs, bolme;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            if(s1 < s2)
            {
                ks = s1;
                bs = s2;
            }
            else
            {
                ks = s2;
                bs = s1;
            }
            bolme = bs / ks;
            label4.Text = Convert.ToString(bolme);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double s1, s2, ks, bs, carpma;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            if(s1 < s2)
            {
                ks = s1;
                bs = s2;
            }
            else
            {
                ks = s2;
                bs = s1;
            }
            carpma = bs * ks;
            label4.Text = Convert.ToString(carpma);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
