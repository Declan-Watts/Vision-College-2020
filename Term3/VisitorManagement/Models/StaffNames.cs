using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorManagement.Models
{
    public class StaffNames
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public int visitorCount { get; set; }
    }
}
