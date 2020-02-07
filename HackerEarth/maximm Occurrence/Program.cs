using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.hackerearth.com/practice/data-structures/hash-tables/basics-of-hash-tables/practice-problems/algorithm/maximum-occurrence-9/
namespace maximm_Occurrence
{
    public static class AppHelper
    {
        public static Int32 CompareByLength(String x, String y)
        {
            Int32 retval = x.Length.CompareTo(y.Length);
            if (retval != 0)
                return retval;
            else
                return String.CompareOrdinal(x, y);
        }

        public static void CharWithMaxOccurrence(String str)
        {
            var ans = str.GroupBy(t => t).Select(a => new { Key = a.Key.ToString(), Count = a.Count() });
            var first = ans.First();
            Int32 countofOne = Convert.ToInt32(first.Count);
            if (ans.All(g => g.Count == countofOne))
            {
                List<String> lst = new List<String>();
                foreach (var item in ans)
                {
                    lst.Add(item.Key.ToString());
                }
                lst.Sort(AppHelper.CompareByLength);
                foreach (var item in lst)
                {
                    Console.WriteLine(item + " " + countofOne);
                    break;
                }
            }
            else
            {
                var result = str.GroupBy(t => t)
                         .Select(a => new { Key = a.Key, Count = a.Count() })
                         .OrderByDescending(a => a.Count)
                         .First();
                Console.WriteLine(result.Key + " " + result.Count);
            }
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            AppHelper.CharWithMaxOccurrence(input);
        }
    }
}
