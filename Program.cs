using System;
namespace IsNaturalNumber
{
    public class Program
    {
        public static void Main()
        {
            // PRECONDITION: The algorithm is ready to accept any integer input value.            const string MsgInput = "Enter a value to check if it's a natural number:";
            const string MsgInput = "Enter a value to check if it's within the interval (5, 50):";
            const string MsgError = "You have to enter a natural number.";
            const string MsgOk = " is within the interval (5, 50).";
            const string MsgKo = " is NOT within the interval (5, 50).";

            int number;
            bool isInteger;

            Console.WriteLine(MsgInput);
            isInteger = Int32.TryParse(Console.ReadLine(), out number);

            if (isInteger)
            {
                if ((number > 5) && (number < 50))
                {
                    Console.Write(MsgOk);
                }
                else
                {
                    Console.Write(MsgKo);
                }
            }
            else
            {
                Console.Write(MsgError);
            }
            // POSTCONDITION: The algorithm has read a 'number' and output a message indicating whether 'number' is strictly between 5 and 50.
        }
    }
}