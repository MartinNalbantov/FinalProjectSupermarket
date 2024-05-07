namespace FinalProjectSupermarket
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
            loginButton = new Button();
            buttonGoLogin = new Button();
            label1 = new Label();
            passWord = new TextBox();
            userName = new TextBox();
            eMail = new TextBox();
            rePassword = new TextBox();
            label2 = new Label();
            passwordValid = new Label();
            usernameValid = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(334, 350);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(86, 33);
            loginButton.TabIndex = 0;
            loginButton.Text = "Sign Up";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // buttonGoLogin
            // 
            buttonGoLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonGoLogin.Location = new Point(334, 395);
            buttonGoLogin.Name = "buttonGoLogin";
            buttonGoLogin.Size = new Size(86, 33);
            buttonGoLogin.TabIndex = 1;
            buttonGoLogin.Text = "Login";
            buttonGoLogin.UseVisualStyleBackColor = true;
            buttonGoLogin.Click += buttonGoLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(282, 67);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 2;
            label1.Text = "Welcome to ShopWise!";
            label1.Click += label1_Click;
            // 
            // passWord
            // 
            passWord.Location = new Point(334, 240);
            passWord.Name = "passWord";
            passWord.PasswordChar = '*';
            passWord.PlaceholderText = "Password";
            passWord.Size = new Size(100, 23);
            passWord.TabIndex = 3;
            passWord.TextChanged += passWord_TextChanged;
            passWord.Validating += passWord_Validating;
            // 
            // userName
            // 
            userName.Location = new Point(334, 126);
            userName.Name = "userName";
            userName.PlaceholderText = "Username";
            userName.Size = new Size(100, 23);
            userName.TabIndex = 4;
            userName.TextChanged += userName_TextChanged;
            userName.Validating += userName_Validating;
            // 
            // eMail
            // 
            eMail.Location = new Point(334, 190);
            eMail.Name = "eMail";
            eMail.PlaceholderText = "Email";
            eMail.Size = new Size(100, 23);
            eMail.TabIndex = 5;
            // 
            // rePassword
            // 
            rePassword.Location = new Point(334, 310);
            rePassword.Name = "rePassword";
            rePassword.PasswordChar = '*';
            rePassword.PlaceholderText = "Retype Password";
            rePassword.Size = new Size(100, 23);
            rePassword.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 210);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // passwordValid
            // 
            passwordValid.AutoSize = true;
            passwordValid.BackColor = SystemColors.GradientInactiveCaption;
            passwordValid.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordValid.Location = new Point(177, 266);
            passwordValid.Name = "passwordValid";
            passwordValid.Size = new Size(464, 23);
            passwordValid.TabIndex = 8;
            passwordValid.Text = "Password has over 8 characters and contains upper and lower case";
            // 
            // usernameValid
            // 
            usernameValid.AutoSize = true;
            usernameValid.BackColor = SystemColors.GradientInactiveCaption;
            usernameValid.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            usernameValid.Location = new Point(265, 152);
            usernameValid.Name = "usernameValid";
            usernameValid.Size = new Size(250, 23);
            usernameValid.TabIndex = 9;
            usernameValid.Text = "Username has at least 5 characters";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supermarket;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 452);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._4thTrySW;
            pictureBox2.Location = new Point(689, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(usernameValid);
            Controls.Add(passwordValid);
            Controls.Add(label2);
            Controls.Add(rePassword);
            Controls.Add(eMail);
            Controls.Add(userName);
            Controls.Add(passWord);
            Controls.Add(label1);
            Controls.Add(buttonGoLogin);
            Controls.Add(loginButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "V";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button buttonGoLogin;
        private Label label1;
        private TextBox passWord;
        private TextBox userName;
        private TextBox eMail;
        private TextBox rePassword;
        private Label label2;
        private Label passwordValid;
        private Label usernameValid;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}