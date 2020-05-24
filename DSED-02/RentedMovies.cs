using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DSED_02
{
    class RentedMovies
    {
        Database moviesDatabase = new Database();
        sqlMethods sql = new sqlMethods();

        private string table = "RentedMovies_v_Customer_v_Movies";
        private string fields = "RMID, FirstName, LastName, Address, Phone, Title, Year, Rating, Genre, Rental_Cost, DateRented, DateReturned";

        public DataView ReadEntries()
        {
            DataView rentedMoviesTable = moviesDatabase.SelectAll(fields, table, "");
            return rentedMoviesTable;
        }
    }
}
