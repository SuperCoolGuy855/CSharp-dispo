using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int step, cookies, clicker, automatron, uberbot, superelection = 0;
        bool code_entered = false;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (step == 9 && keyData == Keys.A)
            {
                step++;
                return true;
            }
            else if (step == 8 && keyData == Keys.B)
            {
                step++;
                return true;
            }
            else if ((step == 5 || step == 7) && keyData == Keys.Right)
            {
                step++;
                return true;
            }
            else if ((step == 4 || step == 6) && keyData == Keys.Left)
            {
                step++;
                return true;
            }
            else if ((step == 2 || step == 3) && keyData == Keys.Down)
            {
                step++;
                return true;
            }
            else if ((step == 0 || step == 1) && keyData == Keys.Up)
            {
                step++;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Cookiecounttext.Text = "Cookies: " + cookies;
            Clickercount.Text = "Amount: " + clicker;
            Automatroncount.Text = "Amount: " + automatron;
            Uberbotcount.Text = "Amount: " + uberbot;
            Superelectioncount.Text = "Amount: " + superelection;

            if (step == 10)
            {
                step = 0;
                code_entered = !code_entered;
                MessageBox.Show("Code Entered");
            }

            if (code_entered)
            {
                cookies++;
            }
        }

        private void CPSTimer_Tick(object sender, EventArgs e)
        {
            int add = clicker + 5 * automatron + 15 * uberbot + 30 * superelection;
            cookies += add;
            CPStext.Text = "Cookies per second: " + add;
        }

        private void Clickbutton_Click(object sender, EventArgs e)
        {
            cookies++;
        }

        private void Clickerbuy_Click(object sender, EventArgs e)
        {
            if (cookies >= 10)
            {
                cookies -= 10;
                clicker++;
            }
        }

        private void Automatronbutton_Click(object sender, EventArgs e)
        {
            if (cookies >= 20)
            {
                cookies -= 20;
                automatron++;
            }
        }

        private void Uberbotbutton_Click(object sender, EventArgs e)
        {
            if (cookies >= 50)
            {
                cookies -= 50;
                uberbot++;
            }
        }

        private void Superelectionbutton_Click(object sender, EventArgs e)
        {
            if (cookies >= 75)
            {
                cookies -= 75;
                superelection++;
            }
        }
    }
}
