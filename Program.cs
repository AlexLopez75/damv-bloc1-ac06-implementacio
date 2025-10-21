using System;
namespace IsNaturalNumber
{
    public class Program
    {
        public static void Main()
        {
            // PRECONDITION: The algorithm is ready to accept any integer input value.
            const string MsgInput = "Enter a value to check if it's a natural number:";
            const string MsgError = "You have to enter a natural number.";
            const string MsgOk = " is a natural number.";
            const string MsgKo = " is NOT a natural number.";

            int value;
            bool isNatural, isInteger;

            Console.WriteLine(MsgInput);
            isInteger = Int32.TryParse(Console.ReadLine(), out value);

            if (isInteger)
            {
                if ((value >= 0) && (value == value))
                {
                    isNatural = true;
                }
                else
                {
                    isNatural = false;
                }

                if (isNatural)
                {
                    Console.WriteLine(MsgOk);
                }
                else
                {
                    Console.WriteLine(MsgKo);

                }
            }
            else
            {
                Console.Write(MsgError);
            }

        }
    }
}