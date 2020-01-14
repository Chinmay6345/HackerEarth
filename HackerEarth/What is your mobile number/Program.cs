using System;
using System.Collections.Generic;
using System.Linq;
namespace What_is_your_mobile_number
{
    public static class AppHelper
    {
        public static List<String> lstValidNumbers(List<String> lstinput)
        {
            List<String> lstOutput = new List<String>();
            foreach (String input in lstinput)
            {
                if (input.All(x => !Char.IsLetter(x)))
                {
                    if (input.StartsWith("0") || input.Length < 10 || input.Contains("."))
                    {
                        lstOutput.Add("NO");
                    }
                    else
                    {
                        lstOutput.Add("YES");
                    }
                }
                else
                {
                    lstOutput.Add("NO");
                }
            }
            return lstOutput;
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            int noOfCases = int.Parse(Console.ReadLine());
            List<String> ListMobileNo = new List<String>();
            while (noOfCases != 0)
            {
                String mobilenumber = Convert.ToString(Console.ReadLine());
                ListMobileNo.Add(mobilenumber);
                noOfCases--;
            }
            List<String> lst = AppHelper.lstValidNumbers(ListMobileNo);
            ListMobileNo = new List<String>();
            lst.ForEach(k => { Console.WriteLine(k); });
            lst = new List<String>();
        }
    }
}
