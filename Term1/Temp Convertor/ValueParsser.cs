using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp_Convertor
{
    public class ValueParsser
    {
        public static float ParseFloat(string a)
        {
            float.TryParse(a, out float b);
            return b;
        }
    }
}
