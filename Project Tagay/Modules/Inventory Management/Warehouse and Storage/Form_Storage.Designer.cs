namespace Project_Tagay.Modules.Inventory_Management.Warehouse_and_Storage
{
    partial class Form_Storage
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            cmbCategory = new ComboBox();
            txtQuantity = new TextBox();
            dtpManufactured = new DateTimePicker();
            dtpExpiration = new DateTimePicker();
            txtLocation = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnRemove = new Button();
            dgvStock = new DataGridView();
            dataGridView1 = new DataGridView();
            colProductID = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colManufactured = new DataGridViewTextBoxColumn();
            Expiration = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 75);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 132);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 191);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 254);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Manufactured";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 315);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 5;
            label6.Text = "Expiration";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 370);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 6;
            label7.Text = "Storage Location";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(23, 36);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(196, 23);
            txtProductID.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(23, 93);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(196, 23);
            txtProductName.TabIndex = 8;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(23, 150);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(196, 23);
            cmbCategory.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(23, 209);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(196, 23);
            txtQuantity.TabIndex = 10;
            // 
            // dtpManufactured
            // 
            dtpManufactured.Location = new Point(23, 272);
            dtpManufactured.Name = "dtpManufactured";
            dtpManufactured.Size = new Size(200, 23);
            dtpManufactured.TabIndex = 11;
            // 
            // dtpExpiration
            // 
            dtpExpiration.Location = new Point(23, 333);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(200, 23);
            dtpExpiration.TabIndex = 12;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(27, 388);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(196, 23);
            txtLocation.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 433);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 34);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add Stock";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(119, 433);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(62, 36);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(196, 433);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(62, 36);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(252, 36);
            dgvStock.Name = "dgvStock";
            dgvStock.Size = new Size(505, 320);
            dgvStock.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProductID, colProductName, colCategory, colQuantity, colManufactured, Expiration, colLocation });
            dataGridView1.Location = new Point(269, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(505, 320);
            dataGridView1.TabIndex = 53;
            // 
            // colProductID
            // 
            colProductID.HeaderText = "ProductID";
            colProductID.Name = "colProductID";
            // 
            // colProductName
            // 
            colProductName.HeaderText = "ProductName";
            colProductName.Name = "colProductName";
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            // 
            // colManufactured
            // 
            colManufactured.HeaderText = "Manufactured";
            colManufactured.Name = "colManufactured";
            // 
            // Expiration
            // 
            Expiration.HeaderText = "Expiration";
            Expiration.Name = "Expiration";
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Location";
            colLocation.Name = "colLocation";
            // 
            // button1
            // 
            button1.Location = new Point(213, 429);
            button1.Name = "button1";
            button1.Size = new Size(62, 36);
            button1.TabIndex = 52;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(136, 429);
            button2.Name = "button2";
            button2.Size = new Size(62, 36);
            button2.TabIndex = 51;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(40, 429);
            button3.Name = "button3";
            button3.Size = new Size(81, 34);
            button3.TabIndex = 50;
            button3.Text = "Add Stock";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 384);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 49;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(40, 329);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(40, 268);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 47;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 46;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 45;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(196, 23);
            textBox3.TabIndex = 44;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(40, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(196, 23);
            textBox4.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 366);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 42;
            label8.Text = "Storage Location";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 311);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 41;
            label9.Text = "Expiration";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 250);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 40;
            label10.Text = "Manufactured";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 187);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 39;
            label11.Text = "Quantity";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 128);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 38;
            label12.Text = "Category";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 71);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 37;
            label13.Text = "Product Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(40, 14);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 36;
            label14.Text = "Product ID";
            // 
            // Form_Storage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 479);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(dgvStock);
            Controls.Add(btnRemove);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtLocation);
            Controls.Add(dtpExpiration);
            Controls.Add(dtpManufactured);
            Controls.Add(txtQuantity);
            Controls.Add(cmbCategory);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Storage";
            Text = "Form_Storage";
            Load += Form_Storage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private TextBox txtQuantity;
        private DateTimePicker dtpManufactured;
        private DateTimePicker dtpExpiration;
        private TextBox txtLocation;
        private Button btnAdd;
        private Button btnClear;
        private Button btnRemove;
        private DataGridView dgvStock;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProductID;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colManufactured;
        private DataGridViewTextBoxColumn Expiration;
        private DataGridViewTextBoxColumn colLocation;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}