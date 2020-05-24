using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_02
{
    public partial class Form1 : Form
    {
        Database moviesDatabase = new Database();
        Customer customer = new Customer();
        Movies movies = new Movies();
        RentedMovies rentedMovies = new RentedMovies();

        TextBox[] customerTextFields;
        TextBox[] moviesTextFields;
        TextBox[] rentedMoviesTextFields;

        string dataSelected;

        public Form1()
        {
            InitializeComponent();
            LoadCustomers();
            customerTextFields = new TextBox[] { txtCustID, txtCustFirstName, txtCustLastName, txtCustAddress, txtCustPhone};
            moviesTextFields = new TextBox[] { txtMovID, txtMovTitle, txtMovYear, txtMovRating, txtMovGenre, txtMovCost };
            rentedMoviesTextFields = new TextBox[] { txtCustFirstName, txtCustLastName, txtCustAddress, txtCustPhone, txtMovTitle, txtMovYear, txtMovRating, txtMovGenre, txtMovCost };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadCustomers()
        {
            dataSelected = "Customer";
            dgView.DataSource = customer.ReadEntries();
            //Database moviesDatabase = new Database();
            //moviesDatabase.SelectAllCustomers();
        }

        private void LoadRented()
        {
            dataSelected = "Rented";
            dgView.DataSource = rentedMovies.ReadEntries();
        }
        private void LoadMovies()
        {
            dataSelected = "Movies";
            dgView.DataSource = movies.ReadEntries();
        }

        private void ReloadSelected()
        {
            if (dataSelected == "Customer")
            {
                LoadCustomers();
            }
            else if (dataSelected == "Movies")
            {
                LoadMovies();
            }
            else if (dataSelected == "Rented")
            {
                LoadRented();
            }
        }

        private void btnCustTab_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnMoviesTab_Click(object sender, EventArgs e)
        {
            LoadMovies();

        }

        private void btnRentMoviesTab_Click(object sender, EventArgs e)
        {
            LoadRented();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Grab the data from the cell clicked
                string newValue = dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row: " + e.RowIndex.ToString() + "     Col: " + e.ColumnIndex.ToString() + "     Value: " + newValue;

                if (dataSelected == "Customer")
                {

                    for (int i = 0; i < customerTextFields.Length; i++)
                    {
                        customerTextFields[i].Text = dgView.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                }
                else if (dataSelected == "Movies")
                {
                    for (int i = 0; i < moviesTextFields.Length; i++)
                    {
                        moviesTextFields[i].Text = dgView.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                } else if (dataSelected == "Rented")
                {
                    for (int i = 0; i < rentedMoviesTextFields.Length; i++)
                    {
                        rentedMoviesTextFields[i].Text = dgView.Rows[e.RowIndex].Cells[i + 1].Value.ToString();
                    }
                }
                // Pass data from this row to textboxes
               
            }
            catch
            {
            }
        }

        private void btnUpdCust_Click(object sender, EventArgs e)
        {
            string[] data = new string[customerTextFields.Length];
            for (int i = 0; i < customerTextFields.Length; i++)
            {
                data[i] = customerTextFields[i].Text;
            }
            customer.Update(data);
            ReloadSelected();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMovUpdate_Click(object sender, EventArgs e)
        {
            string[] data = new string[moviesTextFields.Length];
            for (int i = 0; i < moviesTextFields.Length; i++)
            {
                data[i] = moviesTextFields[i].Text;
            }
            movies.Update(data);
            ReloadSelected();
        }

        private void btnDelCust_Click(object sender, EventArgs e)
        {
            customer.Delete(customerTextFields[0].Text);
            for (int i = 0; i < customerTextFields.Length; i++)
            {
                customerTextFields[i].Text = "";
            }
            ReloadSelected();
        }
    }
}
