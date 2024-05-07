namespace FinalProjectSupermarket
{
    partial class Login
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
            label1 = new Label();
            loginButton = new Button();
            userName = new TextBox();
            passWord = new TextBox();
            backButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(165, 130);
            label1.Name = "label1";
            label1.Size = new Size(192, 43);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back";
            label1.Click += label1_Click;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(208, 305);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(90, 35);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userName
            // 
            userName.Location = new Point(208, 196);
            userName.Name = "userName";
            userName.PlaceholderText = "Username";
            userName.Size = new Size(100, 23);
            userName.TabIndex = 2;
            // 
            // passWord
            // 
            passWord.Location = new Point(208, 246);
            passWord.Name = "passWord";
            passWord.PasswordChar = '*';
            passWord.PlaceholderText = "Password";
            passWord.Size = new Size(100, 23);
            passWord.TabIndex = 3;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(208, 346);
            backButton.Name = "backButton";
            backButton.Size = new Size(90, 35);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._333697_supermarket_wallpaper;
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 455);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._4thTrySW;
            pictureBox2.Location = new Point(383, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(pictureBox2);
            Controls.Add(backButton);
            Controls.Add(passWord);
            Controls.Add(userName);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button loginButton;
        private TextBox userName;
        private TextBox passWord;
        private Button backButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}