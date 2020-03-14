using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public class ValuePasser
    {
        public static (float, float) ParseAssignValues(string txt1, string txt2)
        {
            float.TryParse(txt1, out float a); //This does a Try Catch statement so if it cannot convert it will make it null
            float.TryParse(txt2, out float b);
            var values = (one: a, two: b);
            return values;
        }
    }
}
