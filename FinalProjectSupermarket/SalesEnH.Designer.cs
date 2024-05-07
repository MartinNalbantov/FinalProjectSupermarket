namespace FinalProjectSupermarket
{
    partial class SalesEnH
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
            dataGridView1 = new DataGridView();
            addSale_bttn = new Button();
            clear_bttn = new Button();
            filter_bttn = new Button();
            export_bttn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            emp = new TextBox();
            pr = new TextBox();
            quantity = new TextBox();
            date = new DateTimePicker();
            emp_sort = new TextBox();
            pr_sort = new TextBox();
            back = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(456, 145);
            dataGridView1.TabIndex = 0;
            // 
            // addSale_bttn
            // 
            addSale_bttn.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addSale_bttn.Location = new Point(37, 328);
            addSale_bttn.Name = "addSale_bttn";
            addSale_bttn.RightToLeft = RightToLeft.No;
            addSale_bttn.Size = new Size(106, 33);
            addSale_bttn.TabIndex = 8;
            addSale_bttn.Text = "Add Sale";
            addSale_bttn.UseVisualStyleBackColor = true;
            addSale_bttn.Click += addSale_bttn_Click;
            // 
            // clear_bttn
            // 
            clear_bttn.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clear_bttn.Location = new Point(37, 367);
            clear_bttn.Name = "clear_bttn";
            clear_bttn.Size = new Size(106, 34);
            clear_bttn.TabIndex = 9;
            clear_bttn.Text = "Clear";
            clear_bttn.UseVisualStyleBackColor = true;
            clear_bttn.Click += clear_bttn_Click;
            // 
            // filter_bttn
            // 
            filter_bttn.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filter_bttn.Location = new Point(357, 125);
            filter_bttn.Name = "filter_bttn";
            filter_bttn.Size = new Size(95, 37);
            filter_bttn.TabIndex = 10;
            filter_bttn.Text = "Filter";
            filter_bttn.UseVisualStyleBackColor = true;
            filter_bttn.Click += filter_bttn_Click;
            // 
            // export_bttn
            // 
            export_bttn.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            export_bttn.Location = new Point(620, 376);
            export_bttn.Name = "export_bttn";
            export_bttn.Size = new Size(94, 34);
            export_bttn.TabIndex = 11;
            export_bttn.Text = "Export";
            export_bttn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 90);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 12;
            label1.Text = "Involved in sale : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(429, 59);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 13;
            label2.Text = "Filter : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(419, 175);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 14;
            label3.Text = "Transactions";
            // 
            // emp
            // 
            emp.Location = new Point(37, 175);
            emp.Name = "emp";
            emp.PlaceholderText = "Employee";
            emp.Size = new Size(128, 23);
            emp.TabIndex = 15;
            // 
            // pr
            // 
            pr.Location = new Point(37, 125);
            pr.Name = "pr";
            pr.PlaceholderText = "Product";
            pr.Size = new Size(128, 23);
            pr.TabIndex = 16;
            // 
            // quantity
            // 
            quantity.Location = new Point(37, 222);
            quantity.Name = "quantity";
            quantity.PlaceholderText = "Quantity";
            quantity.Size = new Size(128, 23);
            quantity.TabIndex = 17;
            // 
            // date
            // 
            date.Location = new Point(12, 267);
            date.Name = "date";
            date.Size = new Size(202, 23);
            date.TabIndex = 19;
            // 
            // emp_sort
            // 
            emp_sort.Location = new Point(324, 90);
            emp_sort.Name = "emp_sort";
            emp_sort.PlaceholderText = "Employee";
            emp_sort.Size = new Size(128, 23);
            emp_sort.TabIndex = 20;
            // 
            // pr_sort
            // 
            pr_sort.Location = new Point(469, 90);
            pr_sort.Name = "pr_sort";
            pr_sort.PlaceholderText = "Product";
            pr_sort.Size = new Size(128, 23);
            pr_sort.TabIndex = 21;
            // 
            // back
            // 
            back.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back.Location = new Point(469, 125);
            back.Name = "back";
            back.Size = new Size(95, 37);
            back.TabIndex = 22;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4thTrySW;
            pictureBox1.Location = new Point(715, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SalesEnH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(828, 450);
            Controls.Add(pictureBox1);
            Controls.Add(back);
            Controls.Add(pr_sort);
            Controls.Add(emp_sort);
            Controls.Add(date);
            Controls.Add(quantity);
            Controls.Add(pr);
            Controls.Add(emp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(export_bttn);
            Controls.Add(filter_bttn);
            Controls.Add(clear_bttn);
            Controls.Add(addSale_bttn);
            Controls.Add(dataGridView1);
            Name = "SalesEnH";
            Text = "SalesEnH";
            Load += SalesEnH_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addSale_bttn;
        private Button clear_bttn;
        private Button filter_bttn;
        private Button export_bttn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emp;
        private TextBox pr;
        private TextBox quantity;
        private DateTimePicker date;
        private TextBox emp_sort;
        private TextBox pr_sort;
        private Button back;
        private PictureBox pictureBox1;
    }
}