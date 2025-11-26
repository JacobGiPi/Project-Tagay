using DistilleryManagementSystem;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            SetupCategory();
            SetupUnitTypes();
            SetupGrid();
        }
        private string GenerateProductID()
        {
            return "P" + (products.Count + 1).ToString("000");
        }

        private void SetupCategory()
        {
            cmbCategory.Items.AddRange(new string[]
            {
                "Wine", "Whisky", "Rum", "Vodka", "Brandy", "Gin", "Tequila"
            });
        }

        private void SetupUnitTypes()
        {
            cmbUnitType.Items.AddRange(new string[]
            {
                "Liters", "ML", "Bottles", "Case", "Barrel"
            });
        }

        private void SetupGrid()
        {
            dgvProducts.Columns.Add("ProductID", "Product ID");
            dgvProducts.Columns.Add("ProductName", "Product Name");
            dgvProducts.Columns.Add("Quantity", "Quantity");
            dgvProducts.Columns.Add("UnitType", "Unit");
            dgvProducts.Columns.Add("Category", "Category");
            dgvProducts.Columns.Add("Expiration", "Expiration Date");
            dgvProducts.Columns.Add("Status", "Status");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtProductName.Text == "" ||
                txtQuantity.Text == "" || cmbCategory.Text == "" ||
                cmbUnitType.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Product p = new Product()
            {
                ProductID = txtProductID.Text,
                ProductName = txtProductName.Text,
                Quantity = txtQuantity.Text,
                UnitType = cmbUnitType.Text,
                Category = cmbCategory.Text,
                ExpirationDate = dtpExpirationDate.Value
            };

            products.Add(p);

            string status = GetExpiryStatus(p);
            dgvProducts.Rows.Add(p.ProductID, p.ProductName, p.Quantity, p.UnitType,
                p.Category, p.ExpirationDate.ToShortDateString(), status);

            ColorRow();

            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to update.");
                return;
            }

            int index = dgvProducts.SelectedRows[0].Index;

            products[index].ProductID = txtProductID.Text;
            products[index].ProductName = txtProductName.Text;
            products[index].Quantity = txtQuantity.Text;
            products[index].UnitType = cmbUnitType.Text;
            products[index].Category = cmbCategory.Text;
            products[index].ExpirationDate = dtpExpirationDate.Value;

            dgvProducts.Rows[index].Cells[0].Value = products[index].ProductID;
            dgvProducts.Rows[index].Cells[1].Value = products[index].ProductName;
            dgvProducts.Rows[index].Cells[2].Value = products[index].Quantity;
            dgvProducts.Rows[index].Cells[3].Value = products[index].UnitType;
            dgvProducts.Rows[index].Cells[4].Value = products[index].Category;
            dgvProducts.Rows[index].Cells[5].Value = products[index].ExpirationDate.ToShortDateString();
            dgvProducts.Rows[index].Cells[6].Value = GetExpiryStatus(products[index]);

            ColorRow();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            int index = dgvProducts.SelectedRows[0].Index;

            products.RemoveAt(index);
            dgvProducts.Rows.RemoveAt(index);

            ClearFields();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductID.Text = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProductName.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbUnitType.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbCategory.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();

                dtpExpirationDate.Value = DateTime.Parse(
                    dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString()
                );
            }
        }

        private string GetExpiryStatus(Product p)
        {
            if (p.ExpirationDate < DateTime.Now)
                return "EXPIRED";

            if ((p.ExpirationDate - DateTime.Now).TotalDays <= 7)
                return "NEAR EXPIRY";

            return "SAFE";
        }

        private void ColorRow()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                string status = row.Cells[6].Value?.ToString();

                if (status == "EXPIRED")
                    row.DefaultCellStyle.BackColor = Color.Red;

                else if (status == "NEAR EXPIRY")
                    row.DefaultCellStyle.BackColor = Color.Orange;

                else
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbUnitType.SelectedIndex = -1;
        }
    }
}