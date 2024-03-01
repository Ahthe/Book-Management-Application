/**
 * Ahthesham Ali Syed 
 * 02/25/2023
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementApp
{
    public partial class frmMain : Form
    {

        private bool loggedIn = false;
        private List<Book> books;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            books = new List<Book>(); 
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (btnLogin.Text == "Log in")
            {

              frmLogin loginForm = new frmLogin();

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    loggedIn = true;
                    btnLogin.Text = "Log out";
                    btnReadFile.Enabled = true;
                    btnDisplayBooks.Enabled = true;
                    btnWriteCsv.Enabled = true;
                    txtOutput.Text = "Logged in Welcome!";
                }
                else
                {
                    txtOutput.Text = "Login unsuccessful.";
                }

            }
            else
            {
                btnLogin.Text = "Log in";
                btnReadFile.Enabled = false;
                btnDisplayBooks.Enabled = false;
                btnWriteCsv.Enabled = false;
                txtOutput.Text = "You have been Logged out, Thank You :)";
            }

        }


        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (FileStream stream = new FileStream("C:\\Temp\\Books.dat", FileMode.Open, FileAccess.Read))
                {
                    BinaryReader reader = new BinaryReader(stream);
                    while (stream.Position < stream.Length)
                    {
                        string title = reader.ReadString();
                        string author = reader.ReadString();
                        int numberOfPages = reader.ReadInt32();

                        Book book = new Book(title, author, numberOfPages);
                        books.Add(book);
                    }
                }
                txtOutput.Text = "Books read successfully.";
            }
            catch (Exception ex)
            {
                txtOutput.Text = "Error reading the books: " + ex.Message;
            }
        }

        private void btnDisplayBooks_Click(object sender, EventArgs e)
        {
            if (books.Count == 0)
            {
                txtOutput.Text = "No books to display.";
                return;
            }

            txtOutput.Text = "";
            for (int i = 0; i < books.Count; i++)
            {
                txtOutput.Text += books[i].ToString() + "\r\n";
            }
            txtOutput.Text += "There are " + books.Count + " books";
        }

        private void btnWriteCsv_Click(object sender, EventArgs e)
        {

            string fileName = "C:\\Temp\\Books.csv";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // Write header row
                    writer.WriteLine("Title,Author,Number of Pages");

                    // Write data rows
                    foreach (Book book in books)
                    {
                        writer.WriteLine($"{book.Title},{book.Author},{book.NumberOfPages}");
                    }
                }

                txtOutput.Text = "Books written to CSV file successfully.";
            }
            catch (Exception ex)
            {
                txtOutput.Text = "Error writing books to CSV file: " + ex.Message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
