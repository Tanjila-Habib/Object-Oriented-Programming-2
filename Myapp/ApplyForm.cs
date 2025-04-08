using Myapp;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirthCertificate
{
    public partial class ApplyForm : Form
    {
        private string _username;
        private LoginForm loginForm;

        public ApplyForm(LoginForm form, string username)
        {
            InitializeComponent();
            _username = username;
            loginForm = form;
        }

        // Add record to the database when btnAddRecord is clicked
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";

            string query = "INSERT INTO BirthRecords (Name, DateOfBirth, PlaceOfBirth, FatherName, MotherName, Gender, Address) VALUES (@Name, @DateOfBirth, @PlaceOfBirth, @FatherName, @MotherName, @Gender, @Address)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value);
                    command.Parameters.AddWithValue("@PlaceOfBirth", txtPlaceOfBirth.Text);
                    command.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    command.Parameters.AddWithValue("@MotherName", txtMotherName.Text);
                    command.Parameters.AddWithValue("@Gender", rdoMale.Checked ? "M" : "F");
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Your Application Request is Submitted");
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Back button click event
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of Userdashboard (or the appropriate form)
            Userdashboard userDashboard = new Userdashboard(this.loginForm, this._username);

            // Show Userdashboard
            userDashboard.Show();

            // Hide the current ApplyForm
            this.Hide();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            // Optional: You can implement any functionality here if needed
        }

        private void ClearFields()
        {
            // Clear the text boxes
            txtName.Clear();
            txtPlaceOfBirth.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            txtAddress.Clear();

            // Reset the DateTimePicker to the current date
            dtpDateOfBirth.Value = DateTime.Now;

            // Uncheck the radio buttons
            rdoMale.Checked = false;
            rdoFemale.Checked = false; // Assuming you have a female radio button as well
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ClearFields();
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

        private void ApplyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
