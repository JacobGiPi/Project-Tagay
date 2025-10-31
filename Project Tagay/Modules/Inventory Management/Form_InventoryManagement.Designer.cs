namespace Project_Tagay.Modules.Inventory_Management
{
    partial class Form_InventoryManagement
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
            button_Back_MainInterface = new Button();
            button_RawMaterials = new Button();
            button_FinishedGoods = new Button();
            button_WarehouseAndStorage = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button_Back_MainInterface
            // 
            button_Back_MainInterface.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Back_MainInterface.Location = new Point(28, 51);
            button_Back_MainInterface.Margin = new Padding(4);
            button_Back_MainInterface.Name = "button_Back_MainInterface";
            button_Back_MainInterface.Size = new Size(122, 53);
            button_Back_MainInterface.TabIndex = 0;
            button_Back_MainInterface.Text = "Back";
            button_Back_MainInterface.UseVisualStyleBackColor = true;
            // 
            // button_RawMaterials
            // 
            button_RawMaterials.Location = new Point(216, 164);
            button_RawMaterials.Name = "button_RawMaterials";
            button_RawMaterials.Size = new Size(250, 250);
            button_RawMaterials.TabIndex = 1;
            button_RawMaterials.Text = "Raw Materials";
            button_RawMaterials.UseVisualStyleBackColor = true;
            // 
            // button_FinishedGoods
            // 
            button_FinishedGoods.Location = new Point(616, 164);
            button_FinishedGoods.Name = "button_FinishedGoods";
            button_FinishedGoods.Size = new Size(250, 250);
            button_FinishedGoods.TabIndex = 2;
            button_FinishedGoods.Text = "Finished Goods";
            button_FinishedGoods.UseVisualStyleBackColor = true;
            // 
            // button_WarehouseAndStorage
            // 
            button_WarehouseAndStorage.Location = new Point(1010, 164);
            button_WarehouseAndStorage.Name = "button_WarehouseAndStorage";
            button_WarehouseAndStorage.Size = new Size(250, 250);
            button_WarehouseAndStorage.TabIndex = 3;
            button_WarehouseAndStorage.Text = "Warehouse and Storage";
            button_WarehouseAndStorage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(216, 476);
            button1.Name = "button1";
            button1.Size = new Size(250, 250);
            button1.TabIndex = 4;
            button1.Text = "Raw Materials";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(616, 476);
            button2.Name = "button2";
            button2.Size = new Size(250, 250);
            button2.TabIndex = 5;
            button2.Text = "Raw Materials";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1010, 476);
            button3.Name = "button3";
            button3.Size = new Size(250, 250);
            button3.TabIndex = 6;
            button3.Text = "Raw Materials";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form_InventoryManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_WarehouseAndStorage);
            Controls.Add(button_FinishedGoods);
            Controls.Add(button_RawMaterials);
            Controls.Add(button_Back_MainInterface);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form_InventoryManagement";
            Text = "Inventory Management";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Back_MainInterface;
        private Button button_RawMaterials;
        private Button button_FinishedGoods;
        private Button button_WarehouseAndStorage;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}