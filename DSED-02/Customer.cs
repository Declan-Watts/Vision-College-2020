﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DSED_02
{
    public class Customer
    {
        Database moviesDatabase = new Database();
        sqlMethods sql = new sqlMethods();

        private string table = "Customer";
        private String fields =  "CustID, FirstName, LastName, Address, Phone, Date";

        public DataView ReadEntries()
        {
            DataView customerTable = moviesDatabase.SelectAll(fields, table, "");
            return customerTable;
        }

        public bool Update(string[] data)
        {
            string[] parameterAssign = { "@CustID", "@FirstName", "@LastName", "@Address", "@Phone"};
            string setFields = "FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone";
            string whereClause = "WHERE CustID=@CustID";
            bool updateData = moviesDatabase.UpdateData(table, setFields, whereClause, parameterAssign, data);
            return updateData;
        }

        public bool Delete(string id)
        {
            string[] parameterAssign = { "@CustID" };
            string whereClause = "WHERE CustID=@CustID";
            bool updateData = moviesDatabase.Delete(table, whereClause, parameterAssign, id);
            return updateData;
        }

    }
}
