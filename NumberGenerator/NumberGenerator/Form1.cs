using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGenerator
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        bool status = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = rnd.Next(3, 8) * 1000;
            timer1.Enabled = true;
            button1.Enabled = false;
            status = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status = false;
            timer1.Enabled = false;
            button1.Enabled = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (status)
            {
                List<string> names = textBox3.Text.Split(',').ToList<string>();
                List<int> except = new List<int>();
                foreach (string why in names)
                {
                    except.Add(Convert.ToInt32(why));
                }
                repeat:
                int temp = rnd.Next(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text) + 1);
                foreach (int hi in except)
                {
                    if (temp == hi)
                    {
                        goto repeat;
                    }
                }
                label2.Text = temp.ToString();
            }
        }
    }
}
