using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyAgency2019.Business
{
    public class Agency
    {

        //properties
        public string Country { get; set; }
        public string AgencyName { get; set; }
        public int NumberOfAgents { get; set; }


        //constructor
        public Agency()
        {

            Country = "UK";
            AgencyName = "MI6";
            NumberOfAgents = 12;

        }

        //Methods
        public string CountryAgencyName()
        {
            string alldetails = Country + " " + AgencyName;
            return alldetails;
        }

    }
}
