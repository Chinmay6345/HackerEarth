using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerearth.com/practice/data-structures/hash-tables/basics-of-hash-tables/practice-problems/algorithm/statistics-2/
/*
Max likes football very much. In order to check the popuplarity of the game, he decided to talk to random people and ask them about their favourite game and note it down in a list.

Given a list of name of people and their favourite sport, help Max in finding the sport liked by most of the people, and also how many people like football.

He could have met same people more than once, he will only count response of his first meet with any person.

Note : Name of person as well as sport is a single string in lowercase. Length of name of people as well as sport is less than 11.

Input :: First line will contain no of entries in the list. i.e. N Next N lines will contain two strings, person's name and sports he like.

Output :: In first ine, name of sport liked by most no of people (In case of more than one games is liked by highest no of people, output the first one in lexicographical order). In second line, no of people having football as their favourite game.

Constraints: 1<=N<=100000 1<=Name of person<=10 1<=Name of sport<=10

SAMPLE INPUT 
7
abir cricket
aayush cricket
newton kabaddi
abhinash badminton
sanjay tennis
abhinash badminton
govind football
SAMPLE OUTPUT 
cricket
1
Explanation
2 people likes cricket, ans so it liked by maximum people. 1 person has football as his favourite sport 
*/

namespace Statistics
{
    public static class AppHelper
    {
        public static void Stats(List<String> lst)
        {
            try
            {
                Dictionary<String, Int32> dictionary = new Dictionary<String, Int32>();
                if (lst.Count() > 0)
                {
                    foreach (var item in lst)
                    {
                        if (item.Contains(" "))
                        {
                            String[] arr = item.Split(' ');
                            if (!dictionary.ContainsKey(Convert.ToString(arr.ElementAt(1))))
                            {
                                dictionary[Convert.ToString(arr.ElementAt(1))] = 1;
                            }
                            else
                            {
                                dictionary[Convert.ToString(arr.ElementAt(1))]++;

                            }
                        }
                    }
                    foreach (var element in dictionary.OrderByDescending(g => g.Value))
                    {
                        Console.WriteLine(element.Key);
                        break;
                    }
                    if (dictionary.ContainsKey("football"))
                    {
                        Console.WriteLine(dictionary.Where(a => a.Key == "football").Count());
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("message= " + ex.Message + " inner =" + ex.InnerException.ToString());
            }
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            List<String> lst = new List<String>();
            try
            {

                while (n != 0)
                {
                    String str = Console.ReadLine();
                    if (!String.IsNullOrEmpty(str))
                    {
                        lst.Add(str);
                    }

                    n = n - 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            AppHelper.Stats(lst);
        }
    }
}
