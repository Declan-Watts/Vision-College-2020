using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VisitorManagement.Models
{
    public class Visitors
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string business { get; set; }
        public DateTime dateIn { get; set; }
        public DateTime dateOut { get; set; }
        public StaffNames StaffNames { get; set; }
    }
}
