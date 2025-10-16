using System;
namespace RectangleArea
{
    public class Program
    {
        public static void Main()
        {
            // PRECONDITION: The user is prompted to input the width and height of a rectangle.
            const string MsgInputWidth = "Enter the width of the rectangle:";
            const string MsgInputHeight = "Enter the height of the rectangle:";
            const string MsgResult = "The area of the rectangle is:";

            float width;
            float height;
            float area;

            Console.Write(MsgInputWidth);
            width = Int32.Parse(Console.ReadLine());
            Console.Write(MsgInputHeight);
            height = Int32.Parse(Console.ReadLine());
            area = width * height;
            Console.WriteLine(MsgResult + area);
        }
    }
}