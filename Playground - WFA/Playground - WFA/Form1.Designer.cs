namespace Playground___WFA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textuser = new System.Windows.Forms.RichTextBox();
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.boxregister = new System.Windows.Forms.CheckBox();
            this.master = new System.Windows.Forms.Label();
            this.textmaster = new Playground___WFA.RichPassword();
            this.textpass = new Playground___WFA.RichPassword();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textuser
            // 
            this.textuser.DetectUrls = false;
            this.textuser.Font = new System.Drawing.Font("Arial", 15.75F);
            this.textuser.Location = new System.Drawing.Point(785, 444);
            this.textuser.Multiline = false;
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(349, 45);
            this.textuser.TabIndex = 0;
            this.textuser.Text = "";
            this.textuser.WordWrap = false;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(668, 455);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(111, 24);
            this.user.TabIndex = 5;
            this.user.Text = "Username:";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(670, 535);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(109, 24);
            this.pass.TabIndex = 6;
            this.pass.Text = "Password:";
            this.pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.25F);
            this.button1.Location = new System.Drawing.Point(1211, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxregister
            // 
            this.boxregister.AutoSize = true;
            this.boxregister.Font = new System.Drawing.Font("Arial", 15.75F);
            this.boxregister.Location = new System.Drawing.Point(1221, 545);
            this.boxregister.Name = "boxregister";
            this.boxregister.Size = new System.Drawing.Size(108, 28);
            this.boxregister.TabIndex = 3;
            this.boxregister.Text = "Register";
            this.boxregister.UseVisualStyleBackColor = true;
            this.boxregister.Click += new System.EventHandler(this.boxregister_Click);
            // 
            // master
            // 
            this.master.AutoSize = true;
            this.master.Font = new System.Drawing.Font("Arial", 15.75F);
            this.master.Location = new System.Drawing.Point(599, 620);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(180, 24);
            this.master.TabIndex = 7;
            this.master.Text = "Master Password:";
            this.master.Visible = false;
            // 
            // textmaster
            // 
            this.textmaster.DetectUrls = false;
            this.textmaster.Font = new System.Drawing.Font("Arial", 15.75F);
            this.textmaster.Location = new System.Drawing.Point(785, 613);
            this.textmaster.Multiline = false;
            this.textmaster.Name = "textmaster";
            this.textmaster.Size = new System.Drawing.Size(349, 45);
            this.textmaster.TabIndex = 2;
            this.textmaster.Text = "";
            this.textmaster.Visible = false;
            this.textmaster.WordWrap = false;
            // 
            // textpass
            // 
            this.textpass.DetectUrls = false;
            this.textpass.Font = new System.Drawing.Font("Arial", 15.75F);
            this.textpass.Location = new System.Drawing.Point(785, 528);
            this.textpass.Multiline = false;
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(349, 45);
            this.textpass.TabIndex = 1;
            this.textpass.Text = "";
            this.textpass.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.textmaster);
            this.Controls.Add(this.master);
            this.Controls.Add(this.boxregister);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.textuser);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox textuser;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button button1;
        private RichPassword textpass;
        private System.Windows.Forms.CheckBox boxregister;
        private System.Windows.Forms.Label master;
        private RichPassword textmaster;
        private System.Windows.Forms.Timer timer1;
    }
}

