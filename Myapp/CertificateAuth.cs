using Myapp;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirthCertificate
{
    public partial class CertificateAuth : Form
    {
        // Connection string
        private string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";
        private LoginForm loginForm;
        private string _username;
        private AdminDashboard adminDashboard;



        public CertificateAuth(LoginForm loginForm, AdminDashboard adminDashboard)
        {
            InitializeComponent();
            LoadData();
            this.loginForm = loginForm;
            this.adminDashboard = adminDashboard;
        }

        // Method to load data from the database
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM BirthRecords WHERE Status = 'Pending'", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gunaDataGridViewApplications.DataSource = dataTable;
            }
        }

        // Approve button click event
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (gunaDataGridViewApplications.SelectedRows.Count > 0)
            {
                int recordId = Convert.ToInt32(gunaDataGridViewApplications.SelectedRows[0].Cells["RecordID"].Value);
                UpdateStatus(recordId, "Approved");
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a record to approve.");
            }
        }

        // Reject button click event
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (gunaDataGridViewApplications.SelectedRows.Count > 0)
            {
                int recordId = Convert.ToInt32(gunaDataGridViewApplications.SelectedRows[0].Cells["RecordID"].Value);
                UpdateStatus(recordId, "Rejected");
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a record to reject.");
            }
        }

        // Method to update the status of a record
        private void UpdateStatus(int recordId, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE BirthRecords SET Status = @Status WHERE RecordID = @RecordID", connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@RecordID", recordId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Refresh button click event
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            //AdminDashboard adminDashboard = new AdminDashboard(this.loginForm, this. _username);
            this.adminDashboard.Show();

            this.Close();
        }

        private void CertificateAuth_Load(object sender, EventArgs e)
        {

        }

        
    }
}

