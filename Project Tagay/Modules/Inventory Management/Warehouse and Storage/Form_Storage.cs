using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tagay.Modules.Inventory_Management.Warehouse_and_Storage
{
    public partial class Form_Storage : Form
    {

        public Form_Storage()
        {
            InitializeComponent();
            LoadAlcoholCategories();
            SetupGrid();

        }

        private void LoadAlcoholCategories()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("Beer");
            cmbCategory.Items.Add("Wine");
            cmbCategory.Items.Add("Vodka");
            cmbCategory.Items.Add("Whiskey");
            cmbCategory.Items.Add("Rum");
            cmbCategory.Items.Add("Gin");
            cmbCategory.Items.Add("Tequila");
            cmbCategory.Items.Add("Brandy");
            cmbCategory.Items.Add("Champagne");
            cmbCategory.Items.Add("Soju");
            cmbCategory.Items.Add("Sake");
            cmbCategory.Items.Add("Cocktails");
            cmbCategory.Items.Add("Liquor");
            cmbCategory.Items.Add("Other Alcohol");
        }
        private string GetStatus(DateTime expDate)
        {
            if (expDate < DateTime.Now)
                return "Expired";
            else
                return "Good";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtProductID.Text == "" || txtProductName.Text == "" || cmbCategory.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Fill all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = int.Parse(txtQuantity.Text);


            dgvStock.Rows.Add(
                txtProductID.Text,
                txtProductName.Text,
                cmbCategory.Text,
                qty,
                dtpManufactured.Value.ToShortDateString(),
                dtpExpiration.Value.ToShortDateString(),
                txtLocation.Text,
                CheckStatus(qty, dtpExpiration.Value)
            );

            ClearInputs();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row first!");
                return;
            }

            dgvStock.Rows.RemoveAt(dgvStock.SelectedRows[0].Index);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();           
            dgvStock.Rows.Clear();   
        }

        private string CheckStatus(int qty, DateTime expiry)
        {
            if (expiry <= DateTime.Today)
                return "EXPIRED";

            if (qty <= 5)
                return "LOW STOCK";

            return "OK";
        }

        private void ClearInputs()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            cmbCategory.SelectedIndex = -1;
            txtQuantity.Text = "";
            txtLocation.Text = "";
            dtpManufactured.Value = DateTime.Today;
            dtpExpiration.Value = DateTime.Today;
        }

        private void SetupGrid()
        {
            dgvStock.Columns.Clear();

            dgvStock.Columns.Add("ProductID", "Product ID");
            dgvStock.Columns.Add("ProductName", "Product Name");
            dgvStock.Columns.Add("Category", "Category");
            dgvStock.Columns.Add("Quantity", "Quantity");
            dgvStock.Columns.Add("Manufactured", "Manufactured Date");
            dgvStock.Columns.Add("Expiration", "Expiration Date");
            dgvStock.Columns.Add("Location", "Location");
            dgvStock.Columns.Add("Status", "Status");

            dgvStock.Columns["ProductID"].Width = 80;
            dgvStock.Columns["ProductName"].Width = 150;
            dgvStock.Columns["Category"].Width = 100;
            dgvStock.Columns["Quantity"].Width = 70;
            dgvStock.Columns["Manufactured"].Width = 120;
            dgvStock.Columns["Expiration"].Width = 120;
            dgvStock.Columns["Location"].Width = 100;
            dgvStock.Columns["Status"].Width = 100;

            dgvStock.Columns["Status"].ReadOnly = true;
        }
    }
}

