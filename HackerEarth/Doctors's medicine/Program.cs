using System;

//https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/doctors-secret/

namespace Doctors_s_medicine
{
    public class Program
    {
        public static void Main(String[] args)
        {
            String[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (array[0].Length <= 23 && (Int32.Parse(array[1]) >= 500 && Int32.Parse(array[1]) <= 1000))
            {
                Console.WriteLine("Take Medicine");
            }
            else
            {
                Console.WriteLine("Don't take Medicine");
            }
        }
    }
}
