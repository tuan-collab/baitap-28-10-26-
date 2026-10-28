namespace Bai4._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txt1 = new Label();
            txtmatkhau = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnExit = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Location = new Point(38, 64);
            txt1.Name = "txt1";
            txt1.Size = new Size(105, 20);
            txt1.TabIndex = 0;
            txt1.Text = "ten dang nhap";
            txt1.Click += label1_Click;
            // 
            // txtmatkhau
            // 
            txtmatkhau.AutoSize = true;
            txtmatkhau.Location = new Point(38, 138);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(70, 20);
            txtmatkhau.TabIndex = 1;
            txtmatkhau.Text = "mat khau";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(149, 61);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(125, 27);
            txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(149, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 3;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(149, 171);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(124, 24);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "hien mat khau";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged_1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(38, 236);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(192, 236);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtmatkhau);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt1;
        private Label txtmatkhau;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnExit;
        private ErrorProvider errorProvider1;
    }
}
