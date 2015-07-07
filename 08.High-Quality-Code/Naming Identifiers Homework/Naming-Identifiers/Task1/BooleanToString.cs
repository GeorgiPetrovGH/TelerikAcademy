namespace BooleanAsString
{
    using System;
    public class BooleanToString
    {
        const int MaxCount = 6;
        public class PrintBoolean
        {
            public void PrintBooleanAsString(bool value)
            {
                string boolAsString = value.ToString();
                Console.WriteLine(boolAsString);
            }
        }
        public static void ConvertBooleanToString()
        {
            var boolAsString = new PrintBoolean();
            boolAsString.PrintBooleanAsString(true);
        }
    }
}
