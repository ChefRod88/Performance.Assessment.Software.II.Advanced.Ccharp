using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Performance.Assessment.Software.II.Advanced.Ccharp
{
    public partial class CustomerForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        public CustomerForm()
        {
            InitializeComponent();
            SetupCustomerDataGridView();
            LoadCustomerData();
        }

        // Sets up the DataGridView columns for customer data
        private void SetupCustomerDataGridView()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;

            // Customer ID (PK)
            DataGridViewTextBoxColumn customerIdColumn = new DataGridViewTextBoxColumn();
            customerIdColumn.Name = "CustomerId";
            customerIdColumn.HeaderText = "Customer ID";
            customerIdColumn.DataPropertyName = "customerId";
            customerIdColumn.Width = 80;
            customerIdColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(customerIdColumn);

            // Customer Name
            DataGridViewTextBoxColumn customerNameColumn = new DataGridViewTextBoxColumn();
            customerNameColumn.Name = "CustomerName";
            customerNameColumn.HeaderText = "Customer Name";
            customerNameColumn.DataPropertyName = "customerName";
            customerNameColumn.Width = 150;
            dgvCustomers.Columns.Add(customerNameColumn);

            // Address ID
            DataGridViewTextBoxColumn addressIdColumn = new DataGridViewTextBoxColumn();
            addressIdColumn.Name = "AddressId";
            addressIdColumn.HeaderText = "Address ID";
            addressIdColumn.DataPropertyName = "addressId";
            addressIdColumn.Width = 80;
            addressIdColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(addressIdColumn);

            // Active
            DataGridViewCheckBoxColumn activeColumn = new DataGridViewCheckBoxColumn();
            activeColumn.Name = "Active";
            activeColumn.HeaderText = "Active";
            activeColumn.DataPropertyName = "active";
            activeColumn.Width = 60;
            dgvCustomers.Columns.Add(activeColumn);

            // Create Date
            DataGridViewTextBoxColumn createDateColumn = new DataGridViewTextBoxColumn();
            createDateColumn.Name = "CreateDate";
            createDateColumn.HeaderText = "Create Date";
            createDateColumn.DataPropertyName = "createDate";
            createDateColumn.Width = 120;
            createDateColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(createDateColumn);

            // Created By
            DataGridViewTextBoxColumn createdByColumn = new DataGridViewTextBoxColumn();
            createdByColumn.Name = "CreatedBy";
            createdByColumn.HeaderText = "Created By";
            createdByColumn.DataPropertyName = "createdBy";
            createdByColumn.Width = 100;
            createdByColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(createdByColumn);

            // Last Update
            DataGridViewTextBoxColumn lastUpdateColumn = new DataGridViewTextBoxColumn();
            lastUpdateColumn.Name = "LastUpdate";
            lastUpdateColumn.HeaderText = "Last Update";
            lastUpdateColumn.DataPropertyName = "lastUpdate";
            lastUpdateColumn.Width = 120;
            lastUpdateColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(lastUpdateColumn);

            // Last Updated By
            DataGridViewTextBoxColumn lastUpdateByColumn = new DataGridViewTextBoxColumn();
            lastUpdateByColumn.Name = "LastUpdateBy";
            lastUpdateByColumn.HeaderText = "Last Update By";
            lastUpdateByColumn.DataPropertyName = "lastUpdateBy";
            lastUpdateByColumn.Width = 120;
            lastUpdateByColumn.ReadOnly = true;
            dgvCustomers.Columns.Add(lastUpdateByColumn);
        }

        // Loads customer data into the DataGridView
        private void LoadCustomerData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy FROM customer";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable customerTable = new DataTable();
                    adapter.Fill(customerTable);
                    dgvCustomers.DataSource = customerTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
