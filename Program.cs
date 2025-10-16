using System;
namespace SumTwoNumbers
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInput = "Enter temperature in Celsius:";
            const string MsgResult = "Temperature in Kelvin is:";

            float celsius;
            float kelvin;
            
            Console.Write(MsgInput);
            celsius = Int32.Parse(Console.ReadLine());
            kelvin = (float) (celsius + 273.15);
            Console.WriteLine(MsgResult + kelvin);
        }
    }
}