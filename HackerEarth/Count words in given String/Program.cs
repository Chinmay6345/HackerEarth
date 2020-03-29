using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerearth.com/practice/algorithms/string-algorithm/string-searching/practice-problems/algorithm/count-words-in-given-string-aca26de8/
/*
Given a long string containing spaces, Print the Count of Words.

"This is really good" has 4 words.

SAMPLE INPUT 
3
Being Zero believes in learn-by-doing approach
Coding is     fun.
Amazing Learning Experience.
SAMPLE OUTPUT 
6
3
3 
*/
namespace Count_words_in_given_String
{
    public static class Util
    {
        public static void CountOfWords(String str)
        {
            try
            {
                String[] arr = str.Split(' ');
                Int32 count = 0;
                foreach (String word in arr)
                {
                    if (!String.IsNullOrWhiteSpace(word))
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                Int32 n = Convert.ToInt32(Console.ReadLine());
                while (n != 0)
                {
                    String str = Console.ReadLine();
                    if (!String.IsNullOrEmpty(str))
                    {
                        Util.CountOfWords(str);
                    }
                    n = n - 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
