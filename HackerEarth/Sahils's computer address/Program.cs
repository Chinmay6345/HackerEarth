using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/sahils-computer-address-20/
namespace Sahils_s_computer_address
{

    public class Constants
    {
        public const String YES = "YES";
        public const String NO = "NO";
    }

    public static class AppHelper
    {
        public static void ValidIPAddress(String str)
        {
            try
            {
                if (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str))
                {
                    Console.WriteLine(Constants.NO);
                }
                else if (!str.Contains("."))
                {
                    Console.WriteLine(Constants.NO);
                }
                else if (!str.Any(a => Char.IsDigit(a)))
                {
                    Console.WriteLine(Constants.NO);
                }
                else
                {
                    if (str.Where(a => a == '.').Count() != 3)
                    {
                        Console.WriteLine(Constants.NO);
                    }
                    else
                    {
                        Int32[] arr = str.Split(new Char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(a => Convert.ToInt32(a))
                                         .ToArray<Int32>();
                        if (arr.Length < 4)
                        {
                            Console.WriteLine(Constants.NO);
                        }
                        else
                        {
                            if (arr.Any(g => g > 255 || g < 0))
                            {
                                Console.WriteLine(Constants.NO);
                            }
                            else
                            {
                                Console.WriteLine(Constants.YES);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            AppHelper.ValidIPAddress(input);
        }

    }
}
