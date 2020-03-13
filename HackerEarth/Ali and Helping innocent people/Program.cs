using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/cartag-948c2b02/

/*
Arpasland has surrounded by attackers. A truck enters the city. The driver claims the load is food and medicine from Iranians. Ali is one of the soldiers in Arpasland. He doubts about the truck, maybe it's from the siege. He knows that a tag is valid if the sum of every two consecutive digits of it is even and its letter is not a vowel. Determine if the tag of the truck is valid or not.

We consider the letters "A","E","I","O","U","Y" to be vowels for this problem.

Input Format

The first line contains a string of length 9. The format is "DDXDDD-DD", where D stands for a digit (non zero) and X is an uppercase english letter.

Output Format

Print "valid" (without quotes) if the tag is valid, print "invalid" otherwise (without quotes)

SAMPLE INPUT 
12X345-67
SAMPLE OUTPUT 
invalid 
*/


namespace Ali_and_Helping_innocent_people
{

    /*
// Sample code to perform I/O:
 
name = Console.ReadLine();                  // Reading input from STDIN
Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT
 
// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/

    // Write your code here
    public static class AppHelper
    {
        public static void ValidTruck(String str)
        {
            try
            {
                if (str.Contains("A") || str.Contains("E") || str.Contains("I") || str.Contains("O") || str.Contains("U") || str.Contains("Y"))
                {
                    Console.WriteLine("invalid");
                }
                else
                {
                    Boolean Isvalid = true;
                    for (Int32 i = 0; i <= str.Length; i++)
                    {
                        if (i < str.Length)
                        {
                            if (Char.IsDigit(str[i]) && Char.IsDigit(str[i + 1]))
                            {
                                Int32 sum = Convert.ToInt32(Convert.ToString(str[i])) +
                                         Convert.ToInt32(Convert.ToString(str[i + 1]));
                                if (sum % 2 == 0)
                                {
                                    Isvalid = true;
                                }
                                else
                                {
                                    Isvalid = false;
                                    break;
                                }
                                i++;
                            }
                        }
                    }
                    if (Isvalid)
                    {
                        Console.WriteLine("valid");
                    }
                    else
                    {
                        Console.WriteLine("invalid");
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
            try
            {
                String str = Console.ReadLine();
                AppHelper.ValidTruck(str);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
