using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NumbersToWords
{
    public class Wordifier
    {
        Dictionary<int, string> words = new Dictionary<int, string>
        {
                    {1,"One"},
                    {2,"Two"},
                    {3,"Three"},
                    {4,"Four"},
                    {5,"Five"},
                    {6,"Six"},
                    {7,"Seven"},
                    {8,"Eight"},
                    {9,"Nine"},
                    {10,"Ten"},
                    {11,"Eleven"},
                    {12,"Twelve"},
                    {13,"Thirteen"},
                    {14,"Fourteen"},
                    {15,"Fifteen"},
                    {16,"Sixteen"},
                    {17,"Seventeen"},
                    {18,"Eighteen"},
                    {19,"Nineteen"},
                    {20,"Twenty"},
                    {30,"Thirty"},
                    {40,"Fourty"},
                    {50,"Fifty"},
                    {60,"Sixty"},
                    {70,"Seventy"},
                    {80,"Eighty"},
                    {90,"Ninety"},
        }; 

        public string Convert(int number)
        {
            if (words.ContainsKey(number))
            {
                return words[number];
            }

            var stuff = new List<OrderOfMagnitude>
            {
                new OrderOfMagnitude()
                {
                    Size = 1000,
                    NameFormat = "{0} thousand",
                    RemainderDisplayFormat = "{0}, {1}",
                },
                new OrderOfMagnitude()
                {
                    Size = 100,
                    NameFormat = "{0} hundred",
                    RemainderDisplayFormat = "{0} and {1}",
                },
            };

            foreach (var magnitude in stuff)
            {
                if (number < magnitude.Size) continue;
                int howMany = number/magnitude.Size;
                var rem = number%magnitude.Size;
                var result = string.Format(magnitude.NameFormat, Convert(howMany));
                if (rem > 0)
                    return string.Format(magnitude.RemainderDisplayFormat, result, Convert(rem));
                return result;
            }

            // for tens, (52, etc...)
            var decade = (number/10)*10;
            var remainder = number%10;
            if (remainder > 0)
                return $"{words[decade]}-{words[remainder]}";
            return words[decade];
        }
    }
}