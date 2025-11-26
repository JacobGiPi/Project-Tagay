namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
            label4 = new Label();
            txtProductID = new TextBox();
            label5 = new Label();
            cmbUnitType = new ComboBox();
            dtpExpirationDate = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 60);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 105);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity(Litter/Bottles)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 148);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(42, 78);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(250, 23);
            txtProductName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(42, 122);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 23);
            txtQuantity.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(42, 166);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(246, 23);
            cmbCategory.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Stock";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(149, 256);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Stock";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(254, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Stock";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(34, 352);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(434, 150);
            dgvProducts.TabIndex = 9;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 9);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Cursor = Cursors.SizeAll;
            txtProductID.Location = new Point(46, 27);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(249, 23);
            txtProductID.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 105);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Unit Type";
            // 
            // cmbUnitType
            // 
            cmbUnitType.FormattingEnabled = true;
            cmbUnitType.Location = new Point(322, 122);
            cmbUnitType.Name = "cmbUnitType";
            cmbUnitType.Size = new Size(146, 23);
            cmbUnitType.TabIndex = 13;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Location = new Point(46, 215);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(200, 23);
            dtpExpirationDate.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 197);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 15;
            label6.Text = "Expiration Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(label6);
            Controls.Add(dtpExpirationDate);
            Controls.Add(cmbUnitType);
            Controls.Add(label5);
            Controls.Add(txtProductID);
            Controls.Add(label4);
            Controls.Add(dgvProducts);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvProducts;
        private Label label4;
        private TextBox txtProductID;
        private Label label5;
        private ComboBox cmbUnitType;
        private DateTimePicker dtpExpirationDate;
        private Label label6;
    }
}
