using System;
namespace EuroToDollar
{
    public class Program
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input an amount in euros.
            const double ExchangeRate = 1.12;
            const string MsgInput = "Enter amount in euros:";
            const string MsgResult = "Amount in dollars:";

            float euros;
            float dollars;

            Console.Write(MsgInput);
            euros = Int32.Parse(Console.ReadLine());
            dollars = (float) (euros * ExchangeRate);
            Console.WriteLine(MsgResult + dollars);
            // POSTCONDITION: 'dollars' contains the converted amount, and it is displayed.
        }
    }
}