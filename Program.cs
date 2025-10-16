using System;
namespace AverageThreeNumbers
{
    public class Program
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input three real numbers.
            const string MsgInput1 = "Enter the first number:";
            const string MsgInput2 = "Enter the second number:";
            const string MsgInput3 = "Enter the third number:";
            const string MsgResult = "The average is:";

            float num1;
            float num2;
            float num3;
            float average;

            Console.Write(MsgInput1);
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write(MsgInput2);
            num2 = Int32.Parse(Console.ReadLine());
            Console.Write(MsgInput3);
            num3= Int32.Parse(Console.ReadLine());
            average = (float) ((num1 + num2 + num3)/3);
            Console.WriteLine(MsgResult + average);
            // POSTCONDITION: 'average' contains the arithmetic mean of the three numbers, and it is displayed.
        }
    }
}