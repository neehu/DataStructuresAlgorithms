using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresExamples
{
    public class GreatestCommonDivisorOfStrings
    {
        public static string GcdOfStrings(string str1, string str2)
        {
           
           if(str1 + str2 != str1 + str2)
            {
                return "";
            }
            var n1 = str1.Length;
            var n2 = str2.Length;
            while (n1 != 0 && n2!= 0)
            {
                if(n1 > n2)
                {
                    n1 %= n2;
                }
                else
                {
                    n2 %= n1;
                }
            }
            return str1.Substring(0, n1 | n2);
        }
    }
}
