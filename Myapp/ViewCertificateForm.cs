using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;

namespace Myapp
{
    public partial class ViewCertificateForm : Form
    {
        private string connectionString = "Server=localhost,1433;Database=BirthRecords;User ID=sa;Password=Test1234";

        public ViewCertificateForm()
        {
            InitializeComponent();
        }

        // Load record from the database when btnLoadRecord is clicked
        private void btnLoadRecord_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BirthRecords WHERE RecordID = @RecordID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RecordID", txtSearchRecordID.Text);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the text fields with the retrieved data
                        txtName.Text = reader["Name"].ToString();
                        dtpDateOfBirth.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                        txtPlaceOfBirth.Text = reader["PlaceOfBirth"].ToString();
                        txtFatherName.Text = reader["FatherName"].ToString();
                        txtMotherName.Text = reader["MotherName"].ToString();
                        txtGender.Text = reader["Gender"].ToString() == "M" ? "Male" : "Female";
                        txtAddress.Text = reader["Address"].ToString();
                        string status = reader["Status"].ToString();
                        txtStatus.Text = status;

                        // Enable the download button if the status is approved
                        btnDownloadPDF.Enabled = status == "Approved";
                    }
                    else
                    {
                        // Clear all fields except the Record ID field
                        txtName.Clear();
                        dtpDateOfBirth.Value = DateTime.Now; // Reset to current date or a default value
                        txtPlaceOfBirth.Clear();
                        txtFatherName.Clear();
                        txtMotherName.Clear();
                        txtGender.Clear();
                        txtAddress.Clear();
                        txtStatus.Clear();

                        MessageBox.Show("No record found with the provided RecordID.");
                    }
                }
            }
        }

        // Download PDF button click event
        private void btnDownloadPDF_Click(object sender, EventArgs e)
        {
            // Create and configure a SaveFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save a PDF File";
                saveFileDialog.FileName = $"BirthCertificate_{txtName.Text.Replace(" ", "_")}.pdf"; // default file name

                // Show the SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pdfPath = saveFileDialog.FileName; // Get the selected file path

                    // Paths to your background image and logo (replace these with your actual paths)
                    string backgroundImagePath = @"C:\Users\HP\Downloads\certificate-background-template-design-61532cabfd81d39037fc86932b130ac6_screen.jpg";
                    string logoImagePath = @"C:\Users\HP\Downloads\birth-certificate-and-document-vector.jpg";

                    // Create a PDF document with the specified page size
                    Document document = new Document(new Rectangle(693f, 462f));
                    PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

                    // Add the background image using the PdfBackgroundHelper class
                    Image backgroundImage = Image.GetInstance(backgroundImagePath);
                    PdfBackgroundHelper backgroundHelper = new PdfBackgroundHelper(backgroundImage);
                    pdfWriter.PageEvent = backgroundHelper;

                    document.Open();

                    // Add the logo at the top-right corner
                    Image logo = Image.GetInstance(logoImagePath);
                    logo.ScaleToFit(110f, 110f);
                    logo.Alignment = Element.ALIGN_CENTER;
                        document.Add(logo);

                    // Define font styles
                    Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                    Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    Font bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                    // Add a centered title
                    Paragraph title = new Paragraph("Birth Certificate", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    // Add some spacing below the title
                    document.Add(new Paragraph(" ", bodyFont));

                    // Create a table with two columns for labels and values
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 60;

                    // Add cells to the table for each piece of information
                    table.AddCell(new PdfPCell(new Phrase("Name:", headerFont)) { Border = Rectangle.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(txtName.Text, bodyFont)) { Border = Rectangle.NO_BORDER });

                    table.AddCell(new PdfPCell(new Phrase("Date of Birth:", headerFont)) { Border = Rectangle.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(dtpDateOfBirth.Value.ToString("yyyy-MM-dd"), bodyFont)) { Border = Rectangle.NO_BORDER });

                    table.AddCell(new PdfPCell(new Phrase("Place of Birth:", headerFont)) { Border = Rectangle.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(txtPlaceOfBirth.Text, bodyFont)) { Border = Rectangle.NO_BORDER });

                    table.AddCell(new PdfPCell(new Phrase("Father's Name:", headerFont)) { Border = Rectangle.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(txtFatherName.Text, bodyFont)) { Border = Rectangle.NO_BORDER });

                    table.AddCell(new PdfPCell(new Phrase("Mother's Name:", headerFont)) { Border = Rectangle.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(txtMotherName.Text, bodyFont)) { Border = Rectangle.NO_BORDER });

                    table.AddCell(new PdfPCell(new Phrase("Gender:", headerFont)) { Border = Rectangle.NO_BORDER });
                    table.AddCell(new PdfPCell(new Phrase(txtGender.Text, bodyFont)) { Border = Rectangle.NO_BORDER });

                    table.AddCell(new PdfPCell(new Phrase("Address:", headerFont)) { Border = Rectangle.NO_BORDER });
                    _ = table.AddCell(new PdfPCell(new Phrase(txtAddress.Text, bodyFont)) { Border = Rectangle.NO_BORDER });

                    // Add the table to the document
                    document.Add(table);

                    // Add some spacing before closing
                    _ = document.Add(new Paragraph(" ", bodyFont));

                    document.Close();

                    MessageBox.Show("PDF generated successfully at " + pdfPath);
                }
            }
        }

        private void ViewCertificateForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(64, 211, 211, 211);
        }
    }

    // Helper class for setting the background image for the PDF
    public class PdfBackgroundHelper : PdfPageEventHelper
    {
        private Image backgroundImage;

        public PdfBackgroundHelper(Image backgroundImage)
        {
            this.backgroundImage = backgroundImage;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfContentByte content = writer.DirectContentUnder;
            content.AddImage(backgroundImage, document.PageSize.Width, 0, 0, document.PageSize.Height, 0, 0);
        }
    }
}
