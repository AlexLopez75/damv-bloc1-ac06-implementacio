using System;
namespace SumTwoNumbers
{
    public class Program
    {
        public static void Main()
        {
            const string MSG_INPUT = "Enter temperature in Celsius:";
            const string MSG_RESULT = "Temperature in Kelvin is:";

            float celsius;
            float kelvin;
            
            Console.Write(MSG_INPUT);
            celsius = Int32.Parse(Console.ReadLine());
            kelvin = (float) (celsius + 273.15);
            Console.WriteLine(MSG_RESULT + kelvin);
        }
    }
}