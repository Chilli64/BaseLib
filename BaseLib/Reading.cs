using System;

namespace Fei.BaseLib
{
    public static class Reading
    {
        public static double ReadDouble(string text)
        {
            while (true)
            {
                Console.Write(text + ": ");
                string value = Console.ReadLine();

                double y;

                if (double.TryParse(value, out y))
                {
                    return y;
                }
                else
                {
                    Console.WriteLine("Not a correct double value, please try again");
                }
            }
        }

        public static int ReadInt(string text)
        {
            while (true)
            {
                Console.Write(text + ": ");
                string value = Console.ReadLine();

                int y;

                if (int.TryParse(value, out y))
                {
                    return y;
                }
                else
                {
                    Console.WriteLine("Not a correct int value, please try again");
                }
            }
        }

        public static char ReadChar(string text)
        {
            Console.Write(text + ": ");
            string value = Console.ReadLine();

            if (value.Length > 1)
            {
                throw new Exception("Console.ReadLine() returns string with more than one char, cannot parse.");
            }

            return value.ToCharArray()[0];
        }

        public static string ReadString(string text)
        {
            Console.Write(text + ": ");
            return Console.ReadLine();
        }
    }
}
