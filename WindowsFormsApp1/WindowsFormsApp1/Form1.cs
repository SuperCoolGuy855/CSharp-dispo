using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> test = new List<int>();
            Random ran = new Random();
            for (int i = 0; i < 502384; i++)
            {
                test.Add(ran.Next(100));
            }
            foreach (int num in test)
            {
                label1.Text = num.ToString();
                label1.Refresh();
            }
        }
    }
}
