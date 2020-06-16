using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_Courses.Business
{
    // Abstract can be Inherited but not Instantiated
    abstract class Student
    {

        // Base class, every student has this
        public int ID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime DOB { get; set; }

        public Course course { get; set; } //Aggregation Students Have a Course

        public string email { get; set; }



    }
}
