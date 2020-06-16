using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyAgency2019.Business
{
    class Double07 : Spy
    {
        public Double07()
        {
            weapon = "Football";
            killAbility = "Nuke";
            gadgets = "Button";
            charmLevel = 2;
            codeName = "Donald Trump";
        }

        public override double DaysSinceLastSeen(DateTime contactDate)
        {
            return 0;
        }
    }
}
