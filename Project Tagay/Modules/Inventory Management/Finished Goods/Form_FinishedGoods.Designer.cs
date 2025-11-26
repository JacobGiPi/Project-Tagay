namespace Project_Tagay.Modules.Inventory_Management.Finished_Goods
{
    partial class Form_FinishedGoods
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            MarkDefective = new DataGridViewButtonColumn();
            Status = new DataGridViewComboBoxColumn();
            ExpirationDate = new DataGridViewTextBoxColumn();
            DateProduced = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 64);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity (Liter/Bottles):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 138);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(157, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 23);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(157, 187);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(238, 187);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 4;
            button2.Text = "Update Item";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(336, 187);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Delete Item";
            button3.UseVisualStyleBackColor = true;
            // 
            // MarkDefective
            // 
            MarkDefective.HeaderText = "Action";
            MarkDefective.Name = "MarkDefective";
            MarkDefective.Text = "Mark";
            MarkDefective.UseColumnTextForButtonValue = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Items.AddRange(new object[] { "Good", "Expired", "Defective" });
            Status.Name = "Status";
            // 
            // ExpirationDate
            // 
            ExpirationDate.HeaderText = "Expiration Date";
            ExpirationDate.Name = "ExpirationDate";
            // 
            // DateProduced
            // 
            DateProduced.HeaderText = "Date Produced";
            DateProduced.Name = "DateProduced";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductName, Quantity, DateProduced, ExpirationDate, Status, MarkDefective });
            dataGridView1.Location = new Point(16, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 178);
            dataGridView1.TabIndex = 9;
            // 
            // Form_FinishedGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_FinishedGoods";
            Text = "Form_FinishedGoods";
            Load += Form_FinishedGoods_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewButtonColumn MarkDefective;
        private DataGridViewComboBoxColumn Status;
        private DataGridViewTextBoxColumn ExpirationDate;
        private DataGridViewTextBoxColumn DateProduced;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridView dataGridView1;
    }
}