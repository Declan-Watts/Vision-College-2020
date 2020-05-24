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
        private string fields = "MovieID, Title, Year, Rating, Genre, Rental_Cost, Copies, Plot,  Date";


        public DataView ReadEntries()
        {
            DataView moviesTable = moviesDatabase.SelectAll(fields, table, "");
            return moviesTable;
        }

        public bool Update(string[] data)
        {
            // parameterDefine, parameterAssign & insertArr need to be the same length.
            string[] parameterAssign = { "@MovieID", "@Title", "@Year", "@Rating", "@Genre", "@Rental_Cost" };
            string setFields = "Title=@Title, Year=@Year, Rating=@Rating, Genre=@Genre, Rental_Cost=@Rental_Cost";
            string whereClause = "WHERE MovieID=@MovieID";
            bool updateData = moviesDatabase.UpdateData(table, setFields, whereClause, parameterAssign, data);
            return updateData;
        }
    }
}
