using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresExamples
{
    public class MergeStringsAlternatively
    {
        public static string MergeAlternately(string word1, string word2)
        {
            var i = 1;
            var mergedString = new StringBuilder();

            while (i <= word1.Length && i <= word2.Length)
            {
                mergedString.Append(word1[i - 1]).Append(word2[i - 1]);
                i++;
            }
            while (i <= word1.Length)
            {
                mergedString.Append(word1[i - 1]);
                i++;
            }
            while (i <= word2.Length)
            {
                mergedString.Append(word2[i - 1]);
                i++;
            }
            return mergedString.ToString(); ;
        }
    }
}
