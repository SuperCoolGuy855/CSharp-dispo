#pragma warning disable IDE1006 // Naming Styles
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordtext.Text = "";
            hashtext.Text = "";
            passwordcounttext.Text = "";
            informationtext.Text = "";

            string[] hashtype = { "MD5", "SHA1", "SHA256" };
            string[] crackmode = { "Bruteforce", "Wordlist" };

            typelist.Items.AddRange(hashtype);
            typelist.Text = hashtype[0];
            modelist.Items.AddRange(crackmode);
            modelist.Text = crackmode[0];
        }

        private void wordlistbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = openfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                wordlistentry.Text = openfile.FileName;
            }
        }

        private void beginbutton_Click(object sender, EventArgs e)
        {
            bool cracked = false;
            string[] passwords = File.ReadAllLines(wordlistentry.Text);
            string[] hashs = new string[passwords.Length];

            if (checkBox1.Checked)
            {
                foreach (string line in passwords)
                {
                    passwordtext.Text = line;
                    passwordtext.Refresh();
                }
                passwordtext.Text = "";
                foreach (string line in hashs)
                {
                    hashtext.Text = line;
                    hashtext.Refresh();
                }
                hashtext.Text = "";
            }

            for (int i = 0; i < passwords.Length - 1; i++)
            {
                switch (typelist.Text)
                {
                    case "MD5":
                        hashs[i] = Hash.MD5hash(passwords[i]);
                        break;
                    case "SHA1":
                        hashs[i] = Hash.SHA1hash(passwords[i]);
                        break;
                }
            }

            for (int i = 0; i < hashs.Length - 1; i++)
            {
                passwordtext.Text = passwords[i];
                hashtext.Text = hashs[i];
                passwordcounttext.Text = i.ToString();
                passwordtext.Refresh();
                hashtext.Refresh();
                passwordcounttext.Refresh();
                if (hashs[i] == userhashentry.Text)
                {
                    cracked = true;
                    break;
                }
            }

            if (cracked)
            {
                informationtext.ForeColor = Color.LimeGreen;
                informationtext.Text = "Password founded";
            }
            else
            {
                informationtext.ForeColor = Color.Red;
                informationtext.Text = "No password founded";
            }
        }
    }
}
