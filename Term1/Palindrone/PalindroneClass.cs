using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrone
{
    public class PalindroneClass
    {
        public static bool CheckPalindrone(string text)
        {
            string a = text.Replace(" ", ""); ;
            char[] cArray = a.ToCharArray();
            string reverse = String.Empty;
            string normal = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                if (cArray[i] != '.' || cArray[i] != ',')
                {
                    reverse += cArray[i];
                }
            }
            for (int i = 0; i < cArray.Length; i++)
            {
                if (cArray[i] != '.' || cArray[i] != ',')
                {
                    normal += cArray[i];
                }
            }

            if (normal == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
