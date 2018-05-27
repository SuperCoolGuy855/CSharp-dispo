namespace Tone
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
            this.passwordlabel = new System.Windows.Forms.Label();
            this.hashlabel = new System.Windows.Forms.Label();
            this.passwordcountlabel = new System.Windows.Forms.Label();
            this.wordlistlabel = new System.Windows.Forms.Label();
            this.hashtypelabel = new System.Windows.Forms.Label();
            this.modelabel = new System.Windows.Forms.Label();
            this.passwordtext = new System.Windows.Forms.Label();
            this.hashtext = new System.Windows.Forms.Label();
            this.passwordcounttext = new System.Windows.Forms.Label();
            this.wordlistentry = new System.Windows.Forms.TextBox();
            this.wordlistbutton = new System.Windows.Forms.Button();
            this.typelist = new System.Windows.Forms.ComboBox();
            this.modelist = new System.Windows.Forms.ComboBox();
            this.beginbutton = new System.Windows.Forms.Button();
            this.informationtext = new System.Windows.Forms.Label();
            this.userhashtext = new System.Windows.Forms.Label();
            this.userhashentry = new System.Windows.Forms.TextBox();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(51, 27);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(82, 18);
            this.passwordlabel.TabIndex = 0;
            this.passwordlabel.Text = "Password:";
            // 
            // hashlabel
            // 
            this.hashlabel.AutoSize = true;
            this.hashlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashlabel.Location = new System.Drawing.Point(85, 67);
            this.hashlabel.Name = "hashlabel";
            this.hashlabel.Size = new System.Drawing.Size(48, 18);
            this.hashlabel.TabIndex = 1;
            this.hashlabel.Text = "Hash:";
            // 
            // passwordcountlabel
            // 
            this.passwordcountlabel.AutoSize = true;
            this.passwordcountlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordcountlabel.Location = new System.Drawing.Point(12, 107);
            this.passwordcountlabel.Name = "passwordcountlabel";
            this.passwordcountlabel.Size = new System.Drawing.Size(121, 18);
            this.passwordcountlabel.TabIndex = 2;
            this.passwordcountlabel.Text = "Password Tried:";
            // 
            // wordlistlabel
            // 
            this.wordlistlabel.AutoSize = true;
            this.wordlistlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordlistlabel.Location = new System.Drawing.Point(67, 191);
            this.wordlistlabel.Name = "wordlistlabel";
            this.wordlistlabel.Size = new System.Drawing.Size(69, 18);
            this.wordlistlabel.TabIndex = 3;
            this.wordlistlabel.Text = "Wordlist:";
            // 
            // hashtypelabel
            // 
            this.hashtypelabel.AutoSize = true;
            this.hashtypelabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashtypelabel.Location = new System.Drawing.Point(15, 248);
            this.hashtypelabel.Name = "hashtypelabel";
            this.hashtypelabel.Size = new System.Drawing.Size(85, 18);
            this.hashtypelabel.TabIndex = 4;
            this.hashtypelabel.Text = "Hash Type:";
            // 
            // modelabel
            // 
            this.modelabel.AutoSize = true;
            this.modelabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelabel.Location = new System.Drawing.Point(238, 248);
            this.modelabel.Name = "modelabel";
            this.modelabel.Size = new System.Drawing.Size(100, 18);
            this.modelabel.TabIndex = 5;
            this.modelabel.Text = "Attack Mode:";
            // 
            // passwordtext
            // 
            this.passwordtext.AutoSize = true;
            this.passwordtext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.Location = new System.Drawing.Point(139, 27);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(91, 18);
            this.passwordtext.TabIndex = 6;
            this.passwordtext.Text = "Placeholder";
            // 
            // hashtext
            // 
            this.hashtext.AutoSize = true;
            this.hashtext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashtext.Location = new System.Drawing.Point(139, 67);
            this.hashtext.Name = "hashtext";
            this.hashtext.Size = new System.Drawing.Size(91, 18);
            this.hashtext.TabIndex = 7;
            this.hashtext.Text = "Placeholder";
            // 
            // passwordcounttext
            // 
            this.passwordcounttext.AutoSize = true;
            this.passwordcounttext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordcounttext.Location = new System.Drawing.Point(139, 107);
            this.passwordcounttext.Name = "passwordcounttext";
            this.passwordcounttext.Size = new System.Drawing.Size(91, 18);
            this.passwordcounttext.TabIndex = 8;
            this.passwordcounttext.Text = "Placeholder";
            // 
            // wordlistentry
            // 
            this.wordlistentry.Font = new System.Drawing.Font("Arial", 12F);
            this.wordlistentry.Location = new System.Drawing.Point(139, 188);
            this.wordlistentry.Name = "wordlistentry";
            this.wordlistentry.Size = new System.Drawing.Size(196, 26);
            this.wordlistentry.TabIndex = 9;
            // 
            // wordlistbutton
            // 
            this.wordlistbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordlistbutton.Location = new System.Drawing.Point(356, 190);
            this.wordlistbutton.Name = "wordlistbutton";
            this.wordlistbutton.Size = new System.Drawing.Size(75, 23);
            this.wordlistbutton.TabIndex = 10;
            this.wordlistbutton.Text = "Browse";
            this.wordlistbutton.UseVisualStyleBackColor = true;
            this.wordlistbutton.Click += new System.EventHandler(this.wordlistbutton_Click);
            // 
            // typelist
            // 
            this.typelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typelist.Font = new System.Drawing.Font("Arial", 9.75F);
            this.typelist.FormattingEnabled = true;
            this.typelist.Location = new System.Drawing.Point(106, 246);
            this.typelist.Name = "typelist";
            this.typelist.Size = new System.Drawing.Size(121, 24);
            this.typelist.TabIndex = 11;
            // 
            // modelist
            // 
            this.modelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelist.Font = new System.Drawing.Font("Arial", 9.75F);
            this.modelist.FormattingEnabled = true;
            this.modelist.Location = new System.Drawing.Point(344, 246);
            this.modelist.Name = "modelist";
            this.modelist.Size = new System.Drawing.Size(121, 24);
            this.modelist.TabIndex = 12;
            // 
            // beginbutton
            // 
            this.beginbutton.Font = new System.Drawing.Font("Arial", 15F);
            this.beginbutton.Location = new System.Drawing.Point(185, 304);
            this.beginbutton.Name = "beginbutton";
            this.beginbutton.Size = new System.Drawing.Size(118, 48);
            this.beginbutton.TabIndex = 13;
            this.beginbutton.Text = "Begin";
            this.beginbutton.UseVisualStyleBackColor = true;
            this.beginbutton.Click += new System.EventHandler(this.beginbutton_Click);
            // 
            // informationtext
            // 
            this.informationtext.AutoSize = true;
            this.informationtext.Font = new System.Drawing.Font("Arial", 12F);
            this.informationtext.Location = new System.Drawing.Point(15, 368);
            this.informationtext.Name = "informationtext";
            this.informationtext.Size = new System.Drawing.Size(84, 18);
            this.informationtext.TabIndex = 14;
            this.informationtext.Text = "Information";
            // 
            // userhashtext
            // 
            this.userhashtext.AutoSize = true;
            this.userhashtext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userhashtext.Location = new System.Drawing.Point(54, 149);
            this.userhashtext.Name = "userhashtext";
            this.userhashtext.Size = new System.Drawing.Size(79, 18);
            this.userhashtext.TabIndex = 15;
            this.userhashtext.Text = "Your hash:";
            // 
            // userhashentry
            // 
            this.userhashentry.Font = new System.Drawing.Font("Arial", 12F);
            this.userhashentry.Location = new System.Drawing.Point(139, 146);
            this.userhashentry.Name = "userhashentry";
            this.userhashentry.Size = new System.Drawing.Size(196, 26);
            this.userhashentry.TabIndex = 8;
            // 
            // openfile
            // 
            this.openfile.InitialDirectory = "C:\\";
            this.openfile.Tag = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.checkBox1.Location = new System.Drawing.Point(18, 313);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 22);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Debug";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 413);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.userhashentry);
            this.Controls.Add(this.userhashtext);
            this.Controls.Add(this.informationtext);
            this.Controls.Add(this.beginbutton);
            this.Controls.Add(this.modelist);
            this.Controls.Add(this.typelist);
            this.Controls.Add(this.wordlistbutton);
            this.Controls.Add(this.wordlistentry);
            this.Controls.Add(this.passwordcounttext);
            this.Controls.Add(this.hashtext);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.modelabel);
            this.Controls.Add(this.hashtypelabel);
            this.Controls.Add(this.wordlistlabel);
            this.Controls.Add(this.passwordcountlabel);
            this.Controls.Add(this.hashlabel);
            this.Controls.Add(this.passwordlabel);
            this.Name = "Form1";
            this.Text = "Hash Crack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label hashlabel;
        private System.Windows.Forms.Label passwordcountlabel;
        private System.Windows.Forms.Label wordlistlabel;
        private System.Windows.Forms.Label hashtypelabel;
        private System.Windows.Forms.Label modelabel;
        private System.Windows.Forms.Label passwordtext;
        private System.Windows.Forms.Label hashtext;
        private System.Windows.Forms.Label passwordcounttext;
        private System.Windows.Forms.TextBox wordlistentry;
        private System.Windows.Forms.Button wordlistbutton;
        private System.Windows.Forms.ComboBox typelist;
        private System.Windows.Forms.ComboBox modelist;
        private System.Windows.Forms.Button beginbutton;
        private System.Windows.Forms.Label informationtext;
        private System.Windows.Forms.Label userhashtext;
        private System.Windows.Forms.TextBox userhashentry;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

