using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Locking
{
    public partial class LockingForm : Form
    {
        public LockingForm()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RegisterBox.Checked)
            {
                MasPassText.Visible = true;
                Master.Visible = true;
                Confirm.Text = "Register";
            }
            else
            {
                MasPassText.Visible = false;
                Master.Visible = false;
                Confirm.Text = "Login";
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

        }

        private void LockingForm_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"database.json");

        }
    }
}
