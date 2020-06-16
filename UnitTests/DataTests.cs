using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSED_02;

namespace UnitTests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void DatabaseMoviesTable_DataLengthGreaterThan5_ReturnsTrue()
        {
            Movies movies = new Movies();
            var data = movies.ReadEntries("");
            Assert.IsTrue(data.Count > 5);
        }

        [TestMethod]
        public void DatabaseCustomersTable_DataLengthGreaterThan5_ReturnsTrue()
        {
            Customer customers = new Customer();
            var data = customers.ReadEntries();
            Assert.IsTrue(data.Count > 5);
        }

        [TestMethod]
        public void DatabaseRentedMoviesTable_DataLengthGreaterThan5_ReturnsTrue()
        {
            RentedMovies rentedMovies = new RentedMovies();
            var data = rentedMovies.ReadEntries("");
            Assert.IsTrue(data.Count > 5);
        }


    }
}
