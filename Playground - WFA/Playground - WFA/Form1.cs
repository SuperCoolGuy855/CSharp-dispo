#pragma warning disable IDE1006 // Naming Styles

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Playground___WFA
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> userdatabase;
        int timercount = 0;
        int now = 0;
        int time = 5;

        private string md5hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            userdatabase = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(@"C:\Users\minhm\Documents\Database\User.json"));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textuser.Text;
            string password = textuser.Text;

            if (boxregister.Checked && (md5hash(textmaster.Text) == userdatabase["master"]))
            {
                userdatabase.Add(username, md5hash(password));
                File.WriteAllText(@"C:\Users\minhm\Documents\Database\User.json", JsonConvert.SerializeObject(userdatabase, Formatting.Indented));
                Environment.Exit(0);
            }
            else if (md5hash(password) == userdatabase[username])
            {
                Environment.Exit(0);
            }
            else
            {
                now = timercount;
                button1.Enabled = false;
                time++;
            }
        }

        private void boxregister_Click(object sender, EventArgs e)
        {
            if (boxregister.Checked)
            {
                master.Visible = true;
                textmaster.Visible = true;
            }
            else
            {
                master.Visible = false;
                textmaster.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timercount++;
            if (!button1.Enabled && timercount == now + time)
            {
                button1.Enabled = true;
            }
        }
    }

    class RichPassword : RichTextBox
    {
        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on ES_PASSWORD
                var cp = base.CreateParams;
                cp.Style |= 0x20;
                return cp;
            }
        }
    }
}

//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Threading.Tasks;