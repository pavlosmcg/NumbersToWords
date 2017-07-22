using NUnit.Framework;

namespace NumbersToWords.Tests
{
    [TestFixture]
    public class WordifierTests
    {
        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(3, "Three")]
        [TestCase(4, "Four")]
        [TestCase(5, "Five")]
        [TestCase(6, "Six")]
        [TestCase(7, "Seven")]
        [TestCase(8, "Eight")]
        [TestCase(9, "Nine")]
        public void Convert_WordsForDigits(int input, string expected)
        {
            var unit = new Wordifier();

            var result = unit.Convert(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, "Ten")]
        [TestCase(20, "Twenty")]
        [TestCase(30, "Thirty")]
        [TestCase(40, "Fourty")]
        [TestCase(50, "Fifty")]
        [TestCase(60, "Sixty")]
        [TestCase(70, "Seventy")]
        [TestCase(80, "Eighty")]
        [TestCase(90, "Ninety")]
        public void Convert_WordsForDecades(int input, string expected)
        {
            var unit = new Wordifier();

            var result = unit.Convert(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(53, "Fifty-Three")]
        [TestCase(99, "Ninety-Nine")]
        [TestCase(17, "Seventeen")]
        [TestCase(13, "Thirteen")]
        public void Convert_WordsForNumbersLessThan100(int input, string expected)
        {
            var unit = new Wordifier();

            var result = unit.Convert(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}