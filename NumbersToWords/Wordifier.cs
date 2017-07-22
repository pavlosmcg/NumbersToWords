using System.Collections.Generic;

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

            if (number > 100)
            {
                int hundred = number/100;
                var remainder1 = number % 100;
                var result = $"{Convert(hundred)} hundred";
                if (remainder1 > 0)
                    return result + $" and {Convert(remainder1)}";
                return result;
            }

            int decade = (number/10)*10;
            var remainder = number%10;
            return $"{Convert(decade)}-{Convert(remainder)}";
        }
    }
}