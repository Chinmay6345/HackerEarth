using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest_in_Peace
{
    //https://www.hackerearth.com/practice/algorithms/searching/linear-search/practice-problems/algorithm/rest-in-peace-21-1/
    public class Constants
    {
        public const String StreakAlive = "The streak lives still in our heart!";
        public const String StreakBroken = "The streak is broken!";
        public const String TwentyOne = "21";
    }
    public static class AppHelper
    {
        public static List<String> LstStreak(List<Int32> lst)
        {
            List<String> lststreak = new List<String>();
            foreach (Int32 inputInt in lst)
            {
                if (inputInt % 21 == 0)
                {
                    lststreak.Add(Constants.StreakBroken);
                }
                else if (Convert.ToString(inputInt).Contains(Constants.TwentyOne))
                {
                    lststreak.Add(Constants.StreakBroken);
                }
                else
                {
                    lststreak.Add(Constants.StreakAlive);
                }
            }
            return lststreak;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 NoOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<Int32> lst = new List<Int32>();
            List<String> outputlist = new List<String>();
            for (Int32 i = 0; i < NoOfTestCases; i++)
            {
                Int32 InputIntg = Int32.Parse(Console.ReadLine());
                lst.Add(InputIntg);
            }
            outputlist = AppHelper.LstStreak(lst);
            outputlist.ForEach(k => { Console.WriteLine(k); });
        }
    }
}
