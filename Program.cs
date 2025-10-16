using System;
namespace SumTwoNumbers
{
    public class Program
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input two integers.
            const string MsgInput1 = "Enter the first integer:";
            const string MsgInput2 = "Enter the second integer:";
            const string MsgResult = "The sum is:";

            int num1;
            int num2;
            int sum;

            Console.Write(MsgInput1);
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write(MsgInput2);
            num2 = Int32.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine(MsgResult + sum);
            // POSTCONDITION: 'sum' contains the sum of 'num1' and 'num2', and it is // displayed.
        }
    }
}