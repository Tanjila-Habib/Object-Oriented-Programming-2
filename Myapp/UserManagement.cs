using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MyApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Myapp
{
    
    public partial class UserManagement : Form
    {
        private AdminDashboard adminDashboard;

        public UserManagement(AdminDashboard adminDashboard)
        {
            InitializeComponent();
            LoadUserData();
            checkBoxChangePassword.CheckedChanged += CheckBoxChangePassword_CheckedChanged;
            PopulateStatusComboBox(); // Populate status dropdown
            this.adminDashboard = adminDashboard;
        }

        private void LoadUserData()
        {
            // Get the connection string from App.config
            string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to select data from the users table
                    string query = "SELECT Id, Username, UserType, Email, Password, Status FROM users"; // Include Status column

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear any existing columns in the DataGridView (if needed)
                    dataGridView.Columns.Clear();

                    // Set the data source for the DataGridView
                    dataGridView.DataSource = dataTable;

                    // Add a delete button column at the end
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true,
                        Name = "Delete" // Give it a name to access later
                    };
                    dataGridView.Columns.Add(deleteButtonColumn);
                }
                catch (Exception ex)
                {
                    // Show an error message if data retrieval fails
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
                }
            }
        }

        private void PopulateStatusComboBox()
        {
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.Add("Active");
            comboBoxStatus.Items.Add("Inactive");
            comboBoxStatus.Items.Add("Pending");
            // Add more statuses as needed
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != dataGridView.Columns["Delete"].Index)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                textBoxID.Text = row.Cells["Id"].Value.ToString();
                textBoxUsername.Text = row.Cells["Username"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxPassword.Text = row.Cells["Password"].Value.ToString();

                // Set the selected status in the ComboBox
                string userType = row.Cells["UserType"].Value.ToString(); // Ensure "Status" matches your DB column name
                comboBoxUser.SelectedItem = userType; // Set the selected status

                // Set the selected status in the ComboBox
                string status = row.Cells["Status"].Value.ToString(); // Ensure "Status" matches your DB column name
                comboBoxStatus.SelectedItem = status; // Set the selected status
            }
        }


        private void CheckBoxChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.ReadOnly = !checkBoxChangePassword.Checked;
            if (!checkBoxChangePassword.Checked)
            {
                textBoxPassword.Text = ""; // Clear password when changing is unchecked
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxUsername.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            checkBoxChangePassword.Checked = false;
            comboBoxStatus.SelectedIndex = -1;
            comboBoxUser.SelectedIndex = -1;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Delete"].Index) // Check if the delete button is clicked
            {
                if (e.RowIndex >= 0) // Ensure the row index is valid
                {
                    var userIdCell = dataGridView.Rows[e.RowIndex].Cells["Id"].Value;
                    if (userIdCell != null && int.TryParse(userIdCell.ToString(), out int userId))
                    {
                        var confirmResult = MessageBox.Show("Are you sure to delete this user?",
                                                             "Confirm Delete",
                                                             MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            DeleteUser(userId);
                            LoadUserData(); // Reload the data after deletion
                            ClearTextFields(); // Clear text fields after deletion
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: User ID is invalid or not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteUser(int userId)
        {
            // Get the connection string from App.config
            string connectionString = Constants.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to delete a user by ID
                    string query = "DELETE FROM users WHERE Id = @userId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Show an error message if deletion fails
                    MessageBox.Show("An error occurred while deleting the user: " + ex.Message);
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // Check if password is empty
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty. Setting default password to '123'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password = "123"; // Set default password
            }

            // Check for existing username
            if (UserExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert user into the database
            InsertUser(username, email, password);

            // Clear text fields after adding
            ClearTextFields();
            LoadUserData(); // Reload user data after adding
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Please select a user to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = int.Parse(textBoxID.Text);
            string username = textBoxUsername.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string status = comboBoxStatus.SelectedItem.ToString(); // Get the selected status
            string userType = comboBoxUser.SelectedItem.ToString(); // Get the selected usertype

            // Check if password is empty
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty. Setting default password to '123'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password = "123"; // Set default password
            }

            UpdateUser(userId, username, email, password, status, userType); // Pass the status
            ClearTextFields();
            LoadUserData(); // Reload user data after updating
        }

        private bool UserExists(string username)
        {
            bool exists = false;

            // Get the connection string from App.config
            string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // SQL query to check if the user exists by username
                string query = "SELECT COUNT(*) FROM users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0; // Check if count is greater than 0
                }
            }

            return exists;
        }

        private void InsertUser(string username, string email, string password)
        {
            // Get the connection string from App.config
            string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // SQL query to insert a new user
                string query = "INSERT INTO users (Username, Email, Password, Status) VALUES (@Username, @Email, @Password, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // In real applications, consider hashing the password
                    cmd.Parameters.AddWithValue("@Status", "Active"); // Default status or set as needed
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateUser(int userId, string username, string email, string password, string status, string userType)
        {
            // Get the connection string from App.config
            string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // SQL query to update an existing user
                string query = "UPDATE users SET Username = @Username, Email = @Email, Password = @Password, Status = @Status, UserType = @userType WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // In real applications, consider hashing the password
                    cmd.Parameters.AddWithValue("@Status", status); // Include status in update
                    cmd.Parameters.AddWithValue("@userType", userType); // Include status in update
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ClearTextFields()
        {
            textBoxID.Clear();
            textBoxUsername.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            comboBoxStatus.SelectedIndex = -1; // Clear the ComboBox selection
            comboBoxUser.SelectedIndex = -1; // Clear the ComboBox selection
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
