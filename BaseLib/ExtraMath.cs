using System;


namespace Fei.BaseLib
{
    public static class ExtraMath
    {
        public static bool QuadraticRoots(float a, float b, float c, out float X1, out float X2)
        {
            X1 = float.MinValue;
            X2 = float.MaxValue;

            if (a == 0)
            {
                Console.WriteLine("Not a quadratic equation");
                return false;
            }

            if (b == 0)
            {
                X1 = MathF.Sqrt(-c / a);
                X2 = -X1;
                return true;
            }

            if (c == 0)
            {
                X1 = 0;
                X2 = -b / a;
            }

            float discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Discriminant is smaller than zero. Does not have real number roots");
                return false;
            }


            X1 = (-b + MathF.Sqrt(discriminant)) / (2 * a);
            X2 = (-b - MathF.Sqrt(discriminant)) / (2 * a);



            return true; // equation does not have roots in real numbers
        }

        public static double RandomDouble(double min, double max)
        {
            Random rand = new System.Random();
            return rand.NextDouble() * (max - min) + max;
        }
    }
}
