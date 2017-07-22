using NUnit.Framework;

namespace NumbersToWords.Tests
{
    [TestFixture]
    public class WordifierTests
    {
        [Test]
        public void DoTheThings()
        {
            var unit = new Wordifier();

            var result = unit.Convert(1);

            Assert.That(result, Is.EqualTo("One"));
        }
        
    }
}