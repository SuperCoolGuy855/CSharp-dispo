namespace Test
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
            this.Clickbutton = new System.Windows.Forms.Button();
            this.Clickerbuy = new System.Windows.Forms.Button();
            this.Automatronbutton = new System.Windows.Forms.Button();
            this.Uberbotbutton = new System.Windows.Forms.Button();
            this.Superelectionbutton = new System.Windows.Forms.Button();
            this.Cookiecounttext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPStext = new System.Windows.Forms.Label();
            this.Clickercount = new System.Windows.Forms.Label();
            this.Automatroncount = new System.Windows.Forms.Label();
            this.Uberbotcount = new System.Windows.Forms.Label();
            this.Superelectioncount = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPSTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Clickbutton
            // 
            this.Clickbutton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clickbutton.Location = new System.Drawing.Point(196, 103);
            this.Clickbutton.Name = "Clickbutton";
            this.Clickbutton.Size = new System.Drawing.Size(185, 91);
            this.Clickbutton.TabIndex = 0;
            this.Clickbutton.Text = "Click!";
            this.Clickbutton.UseVisualStyleBackColor = true;
            this.Clickbutton.Click += new System.EventHandler(this.Clickbutton_Click);
            // 
            // Clickerbuy
            // 
            this.Clickerbuy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clickerbuy.Location = new System.Drawing.Point(30, 283);
            this.Clickerbuy.Name = "Clickerbuy";
            this.Clickerbuy.Size = new System.Drawing.Size(87, 29);
            this.Clickerbuy.TabIndex = 1;
            this.Clickerbuy.Text = "Buy";
            this.Clickerbuy.UseVisualStyleBackColor = true;
            this.Clickerbuy.Click += new System.EventHandler(this.Clickerbuy_Click);
            // 
            // Automatronbutton
            // 
            this.Automatronbutton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Automatronbutton.Location = new System.Drawing.Point(30, 355);
            this.Automatronbutton.Name = "Automatronbutton";
            this.Automatronbutton.Size = new System.Drawing.Size(87, 29);
            this.Automatronbutton.TabIndex = 2;
            this.Automatronbutton.Text = "Buy";
            this.Automatronbutton.UseVisualStyleBackColor = true;
            this.Automatronbutton.Click += new System.EventHandler(this.Automatronbutton_Click);
            // 
            // Uberbotbutton
            // 
            this.Uberbotbutton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uberbotbutton.Location = new System.Drawing.Point(30, 427);
            this.Uberbotbutton.Name = "Uberbotbutton";
            this.Uberbotbutton.Size = new System.Drawing.Size(87, 29);
            this.Uberbotbutton.TabIndex = 3;
            this.Uberbotbutton.Text = "Buy";
            this.Uberbotbutton.UseVisualStyleBackColor = true;
            this.Uberbotbutton.Click += new System.EventHandler(this.Uberbotbutton_Click);
            // 
            // Superelectionbutton
            // 
            this.Superelectionbutton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Superelectionbutton.Location = new System.Drawing.Point(30, 496);
            this.Superelectionbutton.Name = "Superelectionbutton";
            this.Superelectionbutton.Size = new System.Drawing.Size(87, 29);
            this.Superelectionbutton.TabIndex = 4;
            this.Superelectionbutton.Text = "Buy";
            this.Superelectionbutton.UseVisualStyleBackColor = true;
            this.Superelectionbutton.Click += new System.EventHandler(this.Superelectionbutton_Click);
            // 
            // Cookiecounttext
            // 
            this.Cookiecounttext.AutoSize = true;
            this.Cookiecounttext.Font = new System.Drawing.Font("Arial", 14F);
            this.Cookiecounttext.Location = new System.Drawing.Point(51, 37);
            this.Cookiecounttext.Name = "Cookiecounttext";
            this.Cookiecounttext.Size = new System.Drawing.Size(101, 22);
            this.Cookiecounttext.TabIndex = 5;
            this.Cookiecounttext.Text = "Cookies: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(155, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buy a Clicker for 10 cookies (1 cps)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(155, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buy a Automatron for 20 cookies (5 cps)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(155, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buy a Uberbot for 50 cookies (15 cps)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(155, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buy a Superelection for 75 cookies (30 cps)";
            // 
            // CPStext
            // 
            this.CPStext.AutoSize = true;
            this.CPStext.Font = new System.Drawing.Font("Arial", 14F);
            this.CPStext.Location = new System.Drawing.Point(316, 37);
            this.CPStext.Name = "CPStext";
            this.CPStext.Size = new System.Drawing.Size(202, 22);
            this.CPStext.TabIndex = 10;
            this.CPStext.Text = "Cookies per second: 0";
            // 
            // Clickercount
            // 
            this.Clickercount.AutoSize = true;
            this.Clickercount.Font = new System.Drawing.Font("Arial", 12F);
            this.Clickercount.Location = new System.Drawing.Point(155, 322);
            this.Clickercount.Name = "Clickercount";
            this.Clickercount.Size = new System.Drawing.Size(78, 18);
            this.Clickercount.TabIndex = 11;
            this.Clickercount.Text = "Amount: 0";
            // 
            // Automatroncount
            // 
            this.Automatroncount.AutoSize = true;
            this.Automatroncount.Font = new System.Drawing.Font("Arial", 12F);
            this.Automatroncount.Location = new System.Drawing.Point(155, 396);
            this.Automatroncount.Name = "Automatroncount";
            this.Automatroncount.Size = new System.Drawing.Size(78, 18);
            this.Automatroncount.TabIndex = 12;
            this.Automatroncount.Text = "Amount: 0";
            // 
            // Uberbotcount
            // 
            this.Uberbotcount.AutoSize = true;
            this.Uberbotcount.Font = new System.Drawing.Font("Arial", 12F);
            this.Uberbotcount.Location = new System.Drawing.Point(155, 468);
            this.Uberbotcount.Name = "Uberbotcount";
            this.Uberbotcount.Size = new System.Drawing.Size(78, 18);
            this.Uberbotcount.TabIndex = 13;
            this.Uberbotcount.Text = "Amount: 0";
            // 
            // Superelectioncount
            // 
            this.Superelectioncount.AutoSize = true;
            this.Superelectioncount.Font = new System.Drawing.Font("Arial", 12F);
            this.Superelectioncount.Location = new System.Drawing.Point(155, 536);
            this.Superelectioncount.Name = "Superelectioncount";
            this.Superelectioncount.Size = new System.Drawing.Size(78, 18);
            this.Superelectioncount.TabIndex = 14;
            this.Superelectioncount.Text = "Amount: 0";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CPSTimer
            // 
            this.CPSTimer.Enabled = true;
            this.CPSTimer.Interval = 1000;
            this.CPSTimer.Tick += new System.EventHandler(this.CPSTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 573);
            this.Controls.Add(this.Superelectioncount);
            this.Controls.Add(this.Uberbotcount);
            this.Controls.Add(this.Automatroncount);
            this.Controls.Add(this.Clickercount);
            this.Controls.Add(this.CPStext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cookiecounttext);
            this.Controls.Add(this.Superelectionbutton);
            this.Controls.Add(this.Uberbotbutton);
            this.Controls.Add(this.Automatronbutton);
            this.Controls.Add(this.Clickerbuy);
            this.Controls.Add(this.Clickbutton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clickbutton;
        private System.Windows.Forms.Button Clickerbuy;
        private System.Windows.Forms.Button Automatronbutton;
        private System.Windows.Forms.Button Uberbotbutton;
        private System.Windows.Forms.Button Superelectionbutton;
        private System.Windows.Forms.Label Cookiecounttext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CPStext;
        private System.Windows.Forms.Label Clickercount;
        private System.Windows.Forms.Label Automatroncount;
        private System.Windows.Forms.Label Uberbotcount;
        private System.Windows.Forms.Label Superelectioncount;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer CPSTimer;
    }
}

