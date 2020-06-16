using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DSED_02
{
    class Movies
    {
        Database moviesDatabase = new Database();
        sqlMethods sql = new sqlMethods();

        private string table = "Movies";
        private string fields = "MovieID, Title, Year, Rating, Genre, Rental_Cost, Copies, Plot, Date  ";


        public DataView ReadEntries(string whereClause)
        {
            DataView moviesTable = moviesDatabase.SelectAll(fields, table, whereClause);
            return moviesTable;
        }

        public DataView ReadEntriesBestMovies(string whereClause)
        {
            DataView moviesTable = moviesDatabase.SelectAll("MovieIDFK, Title, Year, Rating, Genre, Rental_Cost, Copies, Date", "Movies_v_Best_v_RentedMovies", whereClause);
            return moviesTable;
        }

        public bool Create(string[] data)
        {
            string[] parameterAssign = { "@Title", "@Year", "@Rating", "@Genre", "@Rental_Cost", "@Copies", "@Plot" };
            string setFields = "Title, Year, Rating, Genre, Rental_Cost, Copies, Plot";
            string parameterAssignFields = "@Title, @Year, @Rating, @Genre, @Rental_Cost, @Copies, @Plot";
            bool updateData = moviesDatabase.CreateData(table, setFields, parameterAssign, parameterAssignFields, data);
            return updateData;
        }

        public bool Update(string[] data)
        {
            // parameterDefine, parameterAssign & insertArr need to be the same length.
            string[] parameterAssign = { "@MovieID", "@Title", "@Year", "@Rating", "@Genre", "@Rental_Cost", "@Copies", "@Plot" };
            string setFields = "Title=@Title, Year=@Year, Rating=@Rating, Genre=@Genre, Rental_Cost=@Rental_Cost, Copies=@Copies, Plot=@Plot";
            string whereClause = "WHERE MovieID=@MovieID";
            bool updateData = moviesDatabase.UpdateData(table, setFields, whereClause, parameterAssign, data);
            return updateData;
        }

        public bool Delete(string id)
        {
            string[] parameterAssign = { "@MovieID" };
            string whereClause = "WHERE MovieID=@MovieID";
            bool updateData = moviesDatabase.Delete(table, whereClause, parameterAssign, id);
            return updateData;
        }
    }
}
