using DataStructuresExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPracticeProblems
{
    public static class ExtraCandiesProblem
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            var greates = candies.Max(x => x);
            foreach (var candy in candies)
            {
                result.Add(candy + extraCandies > greates);
            }
            return result;
        }
    }
}
