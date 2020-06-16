using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DSED_02
{
    public class RentedMovies
    {
        Database moviesDatabase = new Database();
        sqlMethods sql = new sqlMethods();

        private string table = "RentedMovies_v_Customer_v_Movies";
        private string fields = "RMID, FirstName, LastName, Address, Phone, Title, Year, Rating, Genre, Rental_Cost, DateRented, DateReturned";

        public DataView ReadEntries(string whereClause)
        {
            DataView rentedMoviesTable = moviesDatabase.SelectAll(fields, table, whereClause);
            return rentedMoviesTable;
        }

        public bool IssueMovie(string custID, string movID)
        {
            string[] data = { custID, movID, DateTime.Now.ToString(), "" };
            string[] parameterAssign = { "@CustIDFK", "@MovieIDFK", "@DateRented", "@DateReturned" };
            string setFields = "CustIDFK, MovieIDFK, DateRented, DateReturned";
            string parameterAssignFields = "@CustIDFK, @MovieIDFK, @DateRented, @DateReturned";
            bool updateData = moviesDatabase.CreateData("RentedMovies", setFields, parameterAssign, parameterAssignFields, data);
            return updateData;
        }

        public bool ReturnMovie(string RMID)
        {
            string[] data = { RMID, DateTime.Now.ToString() };
            string[] parameterAssign = { "@RMID", "@DateReturned" };
            string setFields = "DateReturned=@DateReturned";
            string whereClause = "WHERE RMID=@RMID";
            bool updateData = moviesDatabase.UpdateData("RentedMovies", setFields, whereClause, parameterAssign, data);
            return updateData;
        }
    }
}
