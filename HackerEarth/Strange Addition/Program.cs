using System;
using System.Linq;


//https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/the-reversed-numbers/
/*
HackerMan has a message that he has coded in form of digits, which means that the message contains only numbers and nothing else. He is fearful that the enemy may get their hands on the secret message and may decode it. HackerMan already knows the message by heart and he can simply destroy it.

But he wants to keep it incase its needed in a worse situation. He wants to further encode the message in such a format which is not completely reversible. This way if enemies gets hold of the message they will not be completely able to decode the message.

Since the message consists only of number he decides to flip the numbers. The first digit becomes last and vice versa. For example, if there is  in the code, it becomes  now. All the leading zeros are omitted e.g.  gives . So this way the encoding can not completely be deciphered and has some loss of information.

HackerMan is further thinking of complicating the process and he needs your help. He decides to add the two flipped numbers and print the result in the encoded (flipped) form. There is one problem in this method though. For example,  could be ,  or  before reversing. Hence the method ensures that no zeros were lost, that is it can be assumed that the original number was .

Input

The input consists of T test cases. The first line of the input contains only positive integer T. Then follow the cases. Each case consists of exactly one line with two positive integers separated by space. These are the flipped numbers you are to add.

Output

For each case, print exactly one line containing only one integer - the flipped sum of two flipped numbers.

Constraints

The value of T will be less than 1000
The value of digits will be less than 500000
 
*/
namespace Strange_Addition
{
    public class Utility
    {
        public static void StrangeAddition(String[] arr)
        {
            String first = String.Empty;
            String second = String.Empty;
            for (Int32 i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                    first = Convert.ToString(arr[i]).TrimStart(new Char[] { '0' }).TrimEnd(new Char[] { '0' });
                else
                    second = Convert.ToString(arr[i]).TrimStart(new Char[] { '0' }).TrimEnd(new Char[] { '0' });
            }
            Char[] chr1 = first.ToCharArray();
            Char[] chr2 = second.ToCharArray();
            Array.Reverse(chr1);
            Array.Reverse(chr2);
            Int32 num1 = Convert.ToInt32(new String(chr1));
            Int32 num2 = Convert.ToInt32(new String(chr2));
            Int32 num3 = num1 + num2;
            String output = Convert.ToString(num3).TrimStart(new Char[] { '0' }).TrimEnd(new Char[] { '0' });
            Char[] chr3 = output.ToCharArray();
            Array.Reverse(chr3);
            Console.WriteLine(new String(chr3));
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                String[] arr = Console.ReadLine()
                               .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .ToArray<String>();
                Utility.StrangeAddition(arr);
                n = n - 1;
            }
        }
    }

}
