using NUnit.Framework;

namespace NumbersToWords.Tests
{
    [TestFixture]
    public class WordifierTests
    {
        private static void DoTest(int input, string expected)
        {
            var unit = new Wordifier();

            var result = unit.Convert(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Convert_Zero()
        {
            DoTest(0, "Zero");
        }

        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(3, "Three")]
        [TestCase(4, "Four")]
        [TestCase(5, "Five")]
        [TestCase(6, "Six")]
        [TestCase(7, "Seven")]
        [TestCase(8, "Eight")]
        [TestCase(9, "Nine")]
        public void Convert_Digits(int input, string expected)
        {
            DoTest(input, expected);
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
        public void Convert_Decades(int input, string expected)
        {
            DoTest(input, expected);
        }

        [TestCase(53, "Fifty-Three")]
        [TestCase(99, "Ninety-Nine")]
        [TestCase(17, "Seventeen")]
        [TestCase(13, "Thirteen")]
        public void Convert_NumbersLessThan100(int input, string expected)
        {
            DoTest(input, expected);
        }

        [TestCase(101, "One hundred and One")]
        [TestCase(151, "One hundred and Fifty-One")]
        [TestCase(999, "Nine hundred and Ninety-Nine")]
        [TestCase(500, "Five hundred")]
        [TestCase(100, "One hundred")]
        public void Convert_NumbersLessThan1000(int input, string expected)
        {
            DoTest(input, expected);
        }

        [TestCase(9999, "Nine thousand, Nine hundred and Ninety-Nine")]
        [TestCase(2186, "Two thousand, One hundred and Eighty-Six")]
        [TestCase(2017, "Two thousand and Seventeen")]
        [TestCase(7100, "Seven thousand, One hundred")]
        [TestCase(1000, "One thousand")]
        public void Convert_NumbersLessThan10000(int input, string expected)
        {
            DoTest(input, expected);
        }

        [TestCase(10000, "Ten thousand")]
        [TestCase(10001, "Ten thousand and One")]
        [TestCase(99999, "Ninety-Nine thousand, Nine hundred and Ninety-Nine")]
        [TestCase(71453, "Seventy-One thousand, Four hundred and Fifty-Three")]
        public void Convert_NumbersLessThan100000(int input, string expected)
        {
            DoTest(input, expected);
        }
    }
}