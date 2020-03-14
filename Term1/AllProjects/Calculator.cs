using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public class Calculator
    {
        public static float Addition(float a, float b)
        {
            float Answer = a + b;
            return Answer;
        }

        public static float Multiply(float a, float b)
        {
            float Answer = a * b;
            return Answer;
        }

        public static float Divide(float a, float b)
        {
            float Answer = a / b;
            return Answer;
        }

        public static float Minus(float a, float b)
        {
            float Answer = a - b;
            return Answer;
        }
    }
}
