using System;
using System.Collections.Generic;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumber : ICloneable, IComparable
    {
        private ushort number = 1;

        private string romanNumber = "";
        private static readonly string[] thousands = { "", "M", "MM", "MMM" };
        private static readonly string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private static readonly string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private static readonly string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        public RomanNumber(ushort number)
        {
            if (number > 0 && number < 4000)
            {
                this.number = number;
                romanNumber = thousands[(number / 1000) % 10] + hundreds[(number / 100) % 10] + tens[(number / 10) % 10] + ones[number % 10];
            }
            else
                throw new RomanNumberException("#ERROR");
        }

        public RomanNumber(string number)
        {

            romanNumber = number;
            Dictionary<char, ushort> map = new Dictionary<char, ushort> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            if (number.Length == 1)
                this.number = map[number[0]];
            else
            {
                ushort result = 0, i = 0;

                while (i < number.Length - 1)
                {
                    if (map[number[i]] < map[number[i + 1]])
                    {
                        result += (ushort)(map[number[i + 1]] - map[number[i]]);
                        i += 2;
                    }
                    else
                    {
                        result += map[number[i]];
                        i++;
                        if (i == number.Length - 1)
                            result += map[number[i]];
                    }
                }
                this.number = result;
            }
            if (number != new RomanNumber(this.number).ToString())
                throw new RomanNumberException("#ERROR");
            if (!(this.number > 0 || this.number < 4000))
                throw new RomanNumberException("#ERROR");
        }

    public static RomanNumber Add(RomanNumber RomanNumber1, RomanNumber RomanNumber2) => new RomanNumber((ushort)(RomanNumber1.number + RomanNumber2.number));
    public static RomanNumber Sub(RomanNumber RomanNumber1, RomanNumber RomanNumber2) => new RomanNumber((ushort)(RomanNumber1.number - RomanNumber2.number));
    public static RomanNumber Mul(RomanNumber RomanNumber1, RomanNumber RomanNumber2) => new RomanNumber((ushort)(RomanNumber1.number * RomanNumber2.number));
    public static RomanNumber Div(RomanNumber RomanNumber1, RomanNumber RomanNumber2) => new RomanNumber((ushort)(RomanNumber1.number / RomanNumber2.number));

    public object Clone() => MemberwiseClone();

        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber num)
                return number.CompareTo(num.number);
            else
                throw new ArgumentException("#ERROR COMPARE");
        }

        public override string ToString() => romanNumber;

        public ushort ToUInt16() => number;
    }
}
