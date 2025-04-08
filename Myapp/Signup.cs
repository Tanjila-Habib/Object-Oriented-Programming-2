using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Needed for Regex
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Myapp
{
    public partial class Signup : Form
    {
        public static Signup instance;
        private LoginForm loginForm;

        public Signup(LoginForm loginFr)
        {
            InitializeComponent();
            instance = this;
            this.loginForm = loginFr;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(64, 211, 211, 211);
        }

        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm previousForm = new LoginForm();
            previousForm.ShowDialog();
        }

        private void Current_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?",
                                                  "Confirm Close",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // If the user clicks 'No', cancel the close operation
            if (result == DialogResult.No)
            {
                e.Cancel = true;  // This cancels the closing event
            }
            else
            {
                loginForm.Close();
            }
        }

        private void guna2GradientButtonCreate_Click(object sender, EventArgs e)
        {
            string username = guna2TextBoxUsername.Text;
            string email = guna2TextBoxEmail.Text;
            string password = guna2TextBox1.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                // Validate email format
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate password strength
                if (!IsValidPassword(password))
                {
                    MessageBox.Show("Password must be at least 8 characters long and contain uppercase, lowercase letters, a number, and a special character.",
                        "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (IsUsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InsertUser(username, email, password);
                    MessageBox.Show("Account created successfully!");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }

        // Validate Email Format using Regular Expression
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Simple email regex pattern
            return Regex.IsMatch(email, emailPattern);
        }

        // Validate Password Strength
        private bool IsValidPassword(string password)
        {
            // At least 8 characters, with upper and lower case, digits, and special characters
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        private bool IsUsernameExists(string username)
        {
            string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void InsertUser(string username, string email, string password)
        {
            string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO users (Username, Email, Password, Status, UserType) VALUES (@Username, @Email, @Password, @Status, @UserType)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // Consider hashing passwords in real applications
                    cmd.Parameters.AddWithValue("@Status", "Inactive");
                    cmd.Parameters.AddWithValue("@UserType", "User");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ClearFields()
        {
            guna2TextBoxUsername.Text = string.Empty;
            guna2TextBoxEmail.Text = string.Empty;
            guna2TextBox1.Text = string.Empty; // Assuming guna2TextBox1 is the password field
        }
    }
}

