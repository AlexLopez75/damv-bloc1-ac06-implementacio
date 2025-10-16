using System;
using System.ComponentModel;
namespace CelsiusToKelvin
{
    public class Program
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input a temperature in Celsius.
            const string MsgInput = "Enter temperature in Celsius:";
            const string MsgResult = "Temperature in Kelvin is:";

            float celsius;
            float kelvin;
            
            Console.Write(MsgInput);
            celsius = Int32.Parse(Console.ReadLine());
            kelvin = (float) (celsius + 273.15);
            Console.WriteLine(MsgResult + kelvin);
            // POSTCONDITION: 'kelvin' contains the converted temperature, and it is displayed.
        }
    }
}