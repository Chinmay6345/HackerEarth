using System;
using System.Text;

//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/modify-the-string/

namespace Toggle_Strings
{
    public class Program
    {
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            StringBuilder builder = new StringBuilder(input);
            for (int i = 0; i < builder.Length; i++)
            {
                if (Char.IsLower(builder[i]))
                {
                    builder[i] = Char.ToUpper(builder[i]);
                }
                else
                {
                    builder[i] = Char.ToLower(builder[i]);
                }
            }
            Console.WriteLine(Convert.ToString(builder));
        }
    }
}
