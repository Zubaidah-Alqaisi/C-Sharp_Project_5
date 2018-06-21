namespace Assign_5
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
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.ListBox();
            this.AddPssword = new System.Windows.Forms.Button();
            this.ModifyPassword = new System.Windows.Forms.Button();
            this.DeletePassword = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.Button();
            this.siteTextField = new System.Windows.Forms.TextBox();
            this.loginTextField = new System.Windows.Forms.TextBox();
            this.sitePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(27, 68);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(296, 29);
            this.passwordText.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(23, 46);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(186, 19);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Enter your master password: ";
            // 
            // Submit
            // 
            this.Submit.AutoSize = true;
            this.Submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(363, 68);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(128, 29);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit ";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.FormattingEnabled = true;
            this.output.ItemHeight = 21;
            this.output.Location = new System.Drawing.Point(27, 128);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(296, 172);
            this.output.TabIndex = 3;
            this.output.SelectedIndexChanged += new System.EventHandler(this.Output_SelectedIndexChanged);
            // 
            // AddPssword
            // 
            this.AddPssword.Enabled = false;
            this.AddPssword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPssword.Location = new System.Drawing.Point(587, 268);
            this.AddPssword.Name = "AddPssword";
            this.AddPssword.Size = new System.Drawing.Size(128, 34);
            this.AddPssword.TabIndex = 4;
            this.AddPssword.Text = "Add";
            this.AddPssword.UseVisualStyleBackColor = true;
            this.AddPssword.Click += new System.EventHandler(this.AddPssword_Click);
            // 
            // ModifyPassword
            // 
            this.ModifyPassword.Enabled = false;
            this.ModifyPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPassword.Location = new System.Drawing.Point(363, 137);
            this.ModifyPassword.Name = "ModifyPassword";
            this.ModifyPassword.Size = new System.Drawing.Size(128, 32);
            this.ModifyPassword.TabIndex = 5;
            this.ModifyPassword.Text = "Modify";
            this.ModifyPassword.UseVisualStyleBackColor = true;
            this.ModifyPassword.Click += new System.EventHandler(this.ModifyPassword_Click);
            // 
            // DeletePassword
            // 
            this.DeletePassword.Enabled = false;
            this.DeletePassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePassword.Location = new System.Drawing.Point(363, 203);
            this.DeletePassword.Name = "DeletePassword";
            this.DeletePassword.Size = new System.Drawing.Size(128, 36);
            this.DeletePassword.TabIndex = 6;
            this.DeletePassword.Text = "Delete";
            this.DeletePassword.UseVisualStyleBackColor = true;
            this.DeletePassword.Click += new System.EventHandler(this.DeletePassword_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(99, 338);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(128, 36);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.Enabled = false;
            this.ShowPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword.Location = new System.Drawing.Point(363, 268);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(128, 32);
            this.ShowPassword.TabIndex = 8;
            this.ShowPassword.Text = "Show Password ";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // siteTextField
            // 
            this.siteTextField.Enabled = false;
            this.siteTextField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteTextField.Location = new System.Drawing.Point(564, 77);
            this.siteTextField.Name = "siteTextField";
            this.siteTextField.Size = new System.Drawing.Size(176, 26);
            this.siteTextField.TabIndex = 9;
            // 
            // loginTextField
            // 
            this.loginTextField.Enabled = false;
            this.loginTextField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextField.Location = new System.Drawing.Point(564, 149);
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.Size = new System.Drawing.Size(176, 26);
            this.loginTextField.TabIndex = 10;
            // 
            // sitePassword
            // 
            this.sitePassword.Enabled = false;
            this.sitePassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitePassword.Location = new System.Drawing.Point(564, 219);
            this.sitePassword.Name = "sitePassword";
            this.sitePassword.PasswordChar = '*';
            this.sitePassword.Size = new System.Drawing.Size(176, 26);
            this.sitePassword.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter a website name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter a login name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter a password:";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(587, 338);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(127, 35);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 400);
            this.ControlBox = false;
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sitePassword);
            this.Controls.Add(this.loginTextField);
            this.Controls.Add(this.siteTextField);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeletePassword);
            this.Controls.Add(this.ModifyPassword);
            this.Controls.Add(this.AddPssword);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordText);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Button AddPssword;
        private System.Windows.Forms.Button ModifyPassword;
        private System.Windows.Forms.Button DeletePassword;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ShowPassword;
        private System.Windows.Forms.TextBox siteTextField;
        private System.Windows.Forms.TextBox loginTextField;
        private System.Windows.Forms.TextBox sitePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Clear;
    }
}

