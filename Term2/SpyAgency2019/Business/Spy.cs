using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyAgency2019.Business
{
    public class Spy
    {

        //Spy Properties
        public string codeName { get; set; }
        public Agency Agency { get; set; }
        public string dateLastSeen { get; set; }
        public string weapon { get; set; }
        public string killAbility { get; set; }
        public string gadgets { get; set; }
        public int charmLevel { get; set; }


        //Constructor
        public Spy()
        {
            Agency = new Agency();
            weapon = "Rubberband";
            killAbility = "Slap";
            gadgets = "Pen";
            charmLevel = 1;
            codeName = "Rouge Killer";
        }

        //Methods

        // Returns the Age of the Spy
        public double YearsOld(DateTime born)
        {
            TimeSpan ts = DateTime.Now - born;
            double age = ts.TotalDays / 365;
            age = Math.Round(age, 1);
            return age;
        }

        // How long since last Spy Apperance
        public virtual double DaysSinceLastSeen(DateTime contactDate)
        {
            TimeSpan ts = DateTime.Now - contactDate;
            double lastSeen = ts.TotalDays;
            lastSeen = Math.Round(lastSeen, 1);
            return lastSeen;
        }

        public string Home()
        {
            return "Park Lane";
        }

    }
}
