namespace FinalProjectSupermarket
{
    partial class ProductManagement
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
            name = new TextBox();
            type = new TextBox();
            price = new TextBox();
            weight = new TextBox();
            create_bttn = new Button();
            clear_bttn = new Button();
            remove_bttn = new Button();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            quantity = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 63);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 0;
            label1.Text = "Create Product: ";
            label1.Click += label1_Click;
            // 
            // name
            // 
            name.Location = new Point(56, 128);
            name.Name = "name";
            name.PlaceholderText = "Name";
            name.Size = new Size(100, 23);
            name.TabIndex = 1;
            name.TextChanged += name_TextChanged;
            // 
            // type
            // 
            type.Location = new Point(56, 172);
            type.Name = "type";
            type.PlaceholderText = "Type";
            type.Size = new Size(100, 23);
            type.TabIndex = 2;
            // 
            // price
            // 
            price.Location = new Point(56, 216);
            price.Name = "price";
            price.PlaceholderText = "Price";
            price.Size = new Size(100, 23);
            price.TabIndex = 3;
            // 
            // weight
            // 
            weight.Location = new Point(56, 260);
            weight.Name = "weight";
            weight.PlaceholderText = "Weight";
            weight.Size = new Size(100, 23);
            weight.TabIndex = 4;
            // 
            // create_bttn
            // 
            create_bttn.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            create_bttn.Location = new Point(56, 373);
            create_bttn.Name = "create_bttn";
            create_bttn.Size = new Size(90, 37);
            create_bttn.TabIndex = 5;
            create_bttn.Text = "Create";
            create_bttn.UseVisualStyleBackColor = true;
            create_bttn.Click += create_bttn_Click;
            // 
            // clear_bttn
            // 
            clear_bttn.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            clear_bttn.Location = new Point(152, 373);
            clear_bttn.Name = "clear_bttn";
            clear_bttn.Size = new Size(82, 37);
            clear_bttn.TabIndex = 6;
            clear_bttn.Text = "Clear";
            clear_bttn.UseVisualStyleBackColor = true;
            clear_bttn.Click += clear_bttn_Click;
            // 
            // remove_bttn
            // 
            remove_bttn.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            remove_bttn.Location = new Point(600, 373);
            remove_bttn.Name = "remove_bttn";
            remove_bttn.Size = new Size(95, 37);
            remove_bttn.TabIndex = 8;
            remove_bttn.Text = "Remove";
            remove_bttn.UseVisualStyleBackColor = true;
            remove_bttn.Click += remove_bttn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(239, 128);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(456, 196);
            dataGridView2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 63);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 11;
            label2.Text = "Products:";
            // 
            // quantity
            // 
            quantity.Location = new Point(56, 301);
            quantity.Name = "quantity";
            quantity.PlaceholderText = "Quantity";
            quantity.Size = new Size(100, 23);
            quantity.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4thTrySW;
            pictureBox1.Location = new Point(688, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 445);
            Controls.Add(pictureBox1);
            Controls.Add(quantity);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(remove_bttn);
            Controls.Add(clear_bttn);
            Controls.Add(create_bttn);
            Controls.Add(weight);
            Controls.Add(price);
            Controls.Add(type);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "ProductManagement";
            Text = "ProductManagement";
            Load += ProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private TextBox type;
        private TextBox price;
        private TextBox weight;
        private Button create_bttn;
        private Button clear_bttn;
        private Button edit_bttn;
        private Button remove_bttn;
        private DataGridView dataGridView2;
        private Label label2;
        private TextBox quantity;
        private PictureBox pictureBox1;
    }
}