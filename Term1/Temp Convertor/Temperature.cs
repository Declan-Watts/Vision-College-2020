using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp_Convertor
{
    public class Temperature
    {
        public static float ConvertToCelsius(float a)
        {
            return (a - 32) * 5 / 9;
        }

        public static float ConvertToFahrenheit(float a)
        {
            return (a * 9 / 5) + 32;
        }
    }
}
