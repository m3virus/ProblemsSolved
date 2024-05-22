using NUnit.Framework;

namespace Questions
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase("III",3)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]

        public void IsCodeWork(string test, int answer)
        {
            var trying = new Code().RomanToInt(test);

            Assert.That(trying, Is.EqualTo(answer));

        }



    }
}
