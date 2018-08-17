namespace Locking
{
    partial class LockingForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.RegisterBox = new System.Windows.Forms.CheckBox();
            this.User = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.MasPassText = new System.Windows.Forms.TextBox();
            this.Master = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1769, 1004);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 64);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Test_Click);
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = true;
            this.Confirm.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(1101, 441);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(119, 50);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Login";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // RegisterBox
            // 
            this.RegisterBox.AutoSize = true;
            this.RegisterBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBox.Location = new System.Drawing.Point(1101, 581);
            this.RegisterBox.Name = "RegisterBox";
            this.RegisterBox.Size = new System.Drawing.Size(120, 31);
            this.RegisterBox.TabIndex = 3;
            this.RegisterBox.Text = "Register";
            this.RegisterBox.UseVisualStyleBackColor = true;
            this.RegisterBox.CheckedChanged += new System.EventHandler(this.RegisterBox_CheckedChanged);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(636, 444);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(129, 27);
            this.User.TabIndex = 4;
            this.User.Text = "Username:";
            // 
            // UserText
            // 
            this.UserText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserText.Location = new System.Drawing.Point(771, 441);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(221, 35);
            this.UserText.TabIndex = 5;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(641, 580);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(124, 27);
            this.Pass.TabIndex = 6;
            this.Pass.Text = "Password:";
            // 
            // PassText
            // 
            this.PassText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassText.Location = new System.Drawing.Point(771, 577);
            this.PassText.Name = "PassText";
            this.PassText.PasswordChar = '*';
            this.PassText.Size = new System.Drawing.Size(221, 35);
            this.PassText.TabIndex = 7;
            // 
            // MasPassText
            // 
            this.MasPassText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasPassText.Location = new System.Drawing.Point(771, 713);
            this.MasPassText.Name = "MasPassText";
            this.MasPassText.PasswordChar = '*';
            this.MasPassText.Size = new System.Drawing.Size(221, 35);
            this.MasPassText.TabIndex = 9;
            this.MasPassText.Visible = false;
            // 
            // Master
            // 
            this.Master.AutoSize = true;
            this.Master.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Master.Location = new System.Drawing.Point(562, 716);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(203, 27);
            this.Master.TabIndex = 8;
            this.Master.Text = "Master Password:";
            this.Master.Visible = false;
            // 
            // LockingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.MasPassText);
            this.Controls.Add(this.Master);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.User);
            this.Controls.Add(this.RegisterBox);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LockingForm";
            this.Text = "Lock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LockingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.CheckBox RegisterBox;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox MasPassText;
        private System.Windows.Forms.Label Master;
    }
}

