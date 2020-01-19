using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajan_and_odd_frequency_number
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray<Int32>();
            Int32 result = array.GroupBy(a => a).Where(a => a.Count() == 1).Select(a => Convert.ToInt32(a.Key.ToString())).First();
            Console.WriteLine(result);
        }
    }
}
