using System;
using System.Collections.Generic;
using System.Text;

namespace Fei.BaseLib
{
    public static class MathConvertor
    {
        public static string dec2bin(int dec)
        {
            return Convert.ToString(dec, 2);
        }

        public static int bin2dec(string bin)
        {
            return Convert.ToInt32(bin, 2);
        }

        public static string dec2rom(int dec)
        {
            if ((dec < 0) || (dec > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (dec < 1) return string.Empty;
            if (dec >= 1000) return "M" + dec2rom(dec - 1000);
            if (dec >= 900) return "CM" + dec2rom(dec - 900);
            if (dec >= 500) return "D" + dec2rom(dec - 500);
            if (dec >= 400) return "CD" + dec2rom(dec - 400);
            if (dec >= 100) return "C" + dec2rom(dec - 100);
            if (dec >= 90) return "XC" + dec2rom(dec - 90);
            if (dec >= 50) return "L" + dec2rom(dec - 50);
            if (dec >= 40) return "XL" + dec2rom(dec - 40);
            if (dec >= 10) return "X" + dec2rom(dec - 10);
            if (dec >= 9) return "IX" + dec2rom(dec - 9);
            if (dec >= 5) return "V" + dec2rom(dec - 5);
            if (dec >= 4) return "IV" + dec2rom(dec - 4);
            if (dec >= 1) return "I" + dec2rom(dec - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        public static int rom2dec(string rom)
        {
            rom = rom.ToUpper();
            var result = 0;

            foreach (var letter in rom)
            {
                result += ConvertLetterToNumber(letter);
            }

            if (rom.Contains("IV") || rom.Contains("IX"))
                result -= 2;

            if (rom.Contains("XL") || rom.Contains("XC"))
                result -= 20;

            if (rom.Contains("CD") || rom.Contains("CM"))
                result -= 200;


            return result;
        }

        private static int ConvertLetterToNumber(char letter)
        {
            switch (letter)
            {
                case 'M':
                    {
                        return 1000;
                    }

                case 'D':
                    {
                        return 500;
                    }

                case 'C':
                    {
                        return 100;
                    }

                case 'L':
                    {
                        return 50;
                    }

                case 'X':
                    {
                        return 10;
                    }

                case 'V':
                    {
                        return 5;
                    }

                case 'I':
                    {
                        return 1;
                    }

                default:
                    {
                        throw new ArgumentException("Ivalid character");
                    }
            }
        }
    }
}
