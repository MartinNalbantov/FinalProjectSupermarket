namespace FinalProjectSupermarket
{
    partial class Employee
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
            employeeName = new TextBox();
            job = new TextBox();
            wage = new TextBox();
            dataGridView1 = new DataGridView();
            hire_bttn = new Button();
            clear_bttn = new Button();
            fire_bttn = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // employeeName
            // 
            employeeName.Location = new Point(12, 112);
            employeeName.Name = "employeeName";
            employeeName.PlaceholderText = "Name";
            employeeName.Size = new Size(100, 23);
            employeeName.TabIndex = 0;
            employeeName.TextChanged += employeeName_TextChanged;
            // 
            // job
            // 
            job.Location = new Point(12, 186);
            job.Name = "job";
            job.PlaceholderText = "Job";
            job.Size = new Size(100, 23);
            job.TabIndex = 1;
            // 
            // wage
            // 
            wage.Location = new Point(12, 263);
            wage.Name = "wage";
            wage.PlaceholderText = "Wage";
            wage.Size = new Size(100, 23);
            wage.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(339, 174);
            dataGridView1.TabIndex = 3;
            // 
            // hire_bttn
            // 
            hire_bttn.Location = new Point(12, 339);
            hire_bttn.Name = "hire_bttn";
            hire_bttn.Size = new Size(75, 23);
            hire_bttn.TabIndex = 4;
            hire_bttn.Text = "Hire";
            hire_bttn.UseVisualStyleBackColor = true;
            hire_bttn.Click += hire_bttn_Click;
            // 
            // clear_bttn
            // 
            clear_bttn.Location = new Point(110, 339);
            clear_bttn.Name = "clear_bttn";
            clear_bttn.Size = new Size(75, 23);
            clear_bttn.TabIndex = 5;
            clear_bttn.Text = "Clear";
            clear_bttn.UseVisualStyleBackColor = true;
            clear_bttn.Click += clear_bttn_Click;
            // 
            // fire_bttn
            // 
            fire_bttn.Location = new Point(305, 339);
            fire_bttn.Name = "fire_bttn";
            fire_bttn.Size = new Size(75, 23);
            fire_bttn.TabIndex = 6;
            fire_bttn.Text = "Fire";
            fire_bttn.UseVisualStyleBackColor = true;
            fire_bttn.Click += fire_bttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 7;
            label1.Text = "Hire Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(265, 81);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 8;
            label2.Text = "Employees";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4thTrySW;
            pictureBox1.Location = new Point(397, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(511, 394);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fire_bttn);
            Controls.Add(clear_bttn);
            Controls.Add(hire_bttn);
            Controls.Add(dataGridView1);
            Controls.Add(wage);
            Controls.Add(job);
            Controls.Add(employeeName);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox employeeName;
        private TextBox job;
        private TextBox wage;
        private DataGridView dataGridView1;
        private Button hire_bttn;
        private Button clear_bttn;
        private Button fire_bttn;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}