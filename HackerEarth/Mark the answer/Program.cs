using System;
using System.Linq;
//https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/mark-the-answer-1/description/
/*
Our friend Monk has an exam that has quite weird rules. Each question has a difficulty level in the form of an Integer. Now, Monk can only solve the problems that have difficulty level less than X . Now the rules are-

Score of the student is equal to the maximum number of answers he/she has attempted without skipping a question.
Student is allowed to skip just "one" question that will not be counted in the continuity of the questions.
Note- Assume the student knows the solution to the problem he/she attempts and always starts the paper from first question.

Given the number of Questions, N ,the maximum difficulty level of the problem Monk can solve , X ,and the difficulty level of each question ,  can you help him determine his maximum score?

Input Format
First Line contains Integer N , the number of questions and the maximum difficulty X Monk can solve.
Next line contains N integers,  denoting the difficulty level of each question.

Output Format
Maximum score Monk can achieve in the exam.

Constraints

SAMPLE INPUT 
7 6
4 3 7 6 7 2 2
SAMPLE OUTPUT 
3
Explanation
In this example, maximum difficulty = 6, Monk solves question 0 and 1, but skips the question 2 as A[2]>6. Monk then solves the question 3 , but stops at 4 because A[4]>6 and question 2 was already skipped. As 3 questions (0,1 and 3) were solved and 2 questions (2 and 4) have been skipped, therefore we print "3".
*/
namespace Mark_the_answer
{
    public static class AppHelper
{
    public static void Answer(Int32 element,Int32 [] arr)
    {
        Int32 skip=0;
        Int32 answered=0;
        for(Int32 i=0;i<arr.Length;i++)
        {
            if(skip > 1)
               break;
            if(arr[i]>element)
            {
                skip++;
            }
            else
            {
                answered++;
            }
        }
        Console.WriteLine(answered);
    }
}
 
public class Program
{
    public static void Main(String [] args)
    {
        Int32 [] arr1= Console.ReadLine()
                      .Split(' ')
                      .Select(a=>Int32.Parse(a))
                      .ToArray<Int32>();
        Int32 [] arr=  Console.ReadLine()
                      .Split(' ')
                      .Select(a=>Int32.Parse(a))
                      .ToArray<Int32>();
        AppHelper.Answer(arr1[1],arr);
                        
    }
}
}
