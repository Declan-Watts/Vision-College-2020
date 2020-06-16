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
        Database database = new Database();
        Customer customer = new Customer();
        Movies movies = new Movies();
        RentedMovies rentedMovies = new RentedMovies();

        TextBox[] customerTextFields;
        TextBox[] moviesTextFields;
        TextBox[] rentedMoviesTextFields;
        TextBox[] bestMoviesTextFields;

        string dataSelected;

        public Form1()
        {
            InitializeComponent();
            LoadCustomers();
            customerTextFields = new TextBox[] { txtCustID, txtCustFirstName, txtCustLastName, txtCustAddress, txtCustPhone };
            moviesTextFields = new TextBox[] { txtMovID, txtMovTitle, txtMovYear, txtMovRating, txtMovGenre, txtMovCost, txtMovCopies, txtMovPlot };
            rentedMoviesTextFields = new TextBox[] { txtRMID, txtCustFirstName, txtCustLastName, txtCustAddress, txtCustPhone, txtMovTitle, txtMovYear, txtMovRating, txtMovGenre, txtMovCost };
            bestMoviesTextFields = new TextBox[] { txtMovID, txtMovTitle, txtMovYear, txtMovRating, txtMovGenre, txtMovCost, txtMovCopies };

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

        private void LoadRented(string whereClause)
        {
            dataSelected = "Rented";
            dgView.DataSource = rentedMovies.ReadEntries(whereClause);
        }
        private void LoadBestCustomer(string whereClause)
        {
            dataSelected = "BestCustomer";
            dgView.DataSource = customer.ReadEntriesBestCustomer(whereClause);
        }
        private void LoadBestMovies(string whereClause)
        {
            dataSelected = "BestMovies";
            dgView.DataSource = movies.ReadEntriesBestMovies(whereClause);
        }
        private void LoadMovies(string whereClause)
        {
            dataSelected = "Movies";
            dgView.DataSource = movies.ReadEntries(whereClause);
        }

        private void ReloadSelected()
        {
            if (dataSelected == "Customer")
            {
                LoadCustomers();
            }
            else if (dataSelected == "Movies")
            {
                LoadMovies("");
            }
            else if (dataSelected == "Rented")
            {
                LoadRented("");
            }
            else if (dataSelected == "BestCustomer")
            {
                LoadBestCustomer("");
            }
            else if (dataSelected == "BestMovies")
            {
                LoadBestMovies("");
            }
        }

        private void btnCustTab_Click(object sender, EventArgs e)
        {
            LoadCustomers();
            radAllAvailable.Checked = false;
            radOutRented.Checked = false;
        }

        private void btnMoviesTab_Click(object sender, EventArgs e)
        {
            LoadMovies("");
            radAllAvailable.Checked = false;
            radOutRented.Checked = false;
        }

        private void btnRentMoviesTab_Click(object sender, EventArgs e)
        {
            LoadRented("");
            radAllAvailable.Checked = false;
            radOutRented.Checked = false;
        }

        private void btnBestCustomers_Click(object sender, EventArgs e)
        {
            LoadBestCustomer("");
            radAllAvailable.Checked = false;
            radOutRented.Checked = false;
        }
        private void btnBestMovies_Click(object sender, EventArgs e)
        {
            LoadBestMovies("");
            radAllAvailable.Checked = false;
            radOutRented.Checked = false;
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

                if (dataSelected == "Customer" || dataSelected == "BestCustomer")
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
                    try
                    {
                        int year = Convert.ToInt32(dgView.Rows[e.RowIndex].Cells[2].Value.ToString());

                        if (year > 2015)
                        {
                            moviesTextFields[5].Text = "5.0000";

                        }
                        else
                        {
                            moviesTextFields[5].Text = "2.0000";
                        }
                    }
                    catch (Exception)
                    {
                        moviesTextFields[5].Text = "2.0000";
                    }

                }
                else if (dataSelected == "Rented")
                {
                    for (int i = 0; i < rentedMoviesTextFields.Length; i++)
                    {
                        rentedMoviesTextFields[i].Text = dgView.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                }
                else if (dataSelected == "BestMovies")
                {
                    for (int i = 0; i < rentedMoviesTextFields.Length; i++)
                    {
                        bestMoviesTextFields[i].Text = dgView.Rows[e.RowIndex].Cells[i].Value.ToString();
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
            if (customer.Delete(customerTextFields[0].Text))
            {
                for (int i = 0; i < customerTextFields.Length; i++)
                {
                    customerTextFields[i].Text = "";
                }
                ReloadSelected();
            }
            else
            {
                MessageBox.Show("This Customer cannot be Deleted because they have Rented in the past");
            }
        }

        private void txtMovCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMovRating_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMovYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMovTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMovIssue_Click(object sender, EventArgs e)
        {
            if (customerTextFields[0].Text.Length > 0 && moviesTextFields[0].Text.Length > 0)
            {
                if (rentedMovies.IssueMovie(customerTextFields[0].Text, moviesTextFields[0].Text))
                {
                    ReloadSelected();
                }
                else
                {
                    MessageBox.Show("There was an Error, Please make sure the Data is correct");

                }
            }
            else
            {
                MessageBox.Show("Please have a Movie and a Customer Selected");
            }
        }

        private void btnMovReturn_Click(object sender, EventArgs e)
        {
            if (rentedMoviesTextFields[0].Text.Length > 0)
            {
                if (rentedMovies.ReturnMovie(rentedMoviesTextFields[0].Text))
                {
                    ReloadSelected();
                }
                else
                {
                    MessageBox.Show("There was an Error, Please make sure the Data is correct");

                }

            }
            else
            {
                MessageBox.Show("Please have a Rented Movie Entry Selected");
            }
        }

        private void btnCustCreate_Click(object sender, EventArgs e)
        {
            string[] data = new string[customerTextFields.Length - 1];
            for (int i = 0; i < customerTextFields.Length - 1; i++)
            {
                data[i] = customerTextFields[i + 1].Text;
            }
            customer.Create(data);
            ReloadSelected();
        }

        private void btnCreateMovie_Click(object sender, EventArgs e)
        {
            string[] data = new string[moviesTextFields.Length - 1];
            for (int i = 0; i < moviesTextFields.Length - 1; i++)
            {
                data[i] = moviesTextFields[i + 1].Text;
            }
            movies.Create(data);
            ReloadSelected();
        }

        private void radAllRented_CheckedChanged(object sender, EventArgs e)
        {
            if (radAllAvailable.Checked == true)
            {
                LoadMovies("WHERE MovieID NOT IN (Select MovieIDFK FROM RentedMovies WHERE DateReturned IS NULL OR DateReturned = '') OR MovieID NOT IN (SELECT MovieIDFK FROM RentedMovies)");
            }
        }

        private void radOutRented_CheckedChanged(object sender, EventArgs e)
        {
            if (radOutRented.Checked == true)
            {
                LoadRented("WHERE DateReturned IS NULL OR DateReturned = ''");
            }
        }


    }
}
