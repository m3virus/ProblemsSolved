using NUnit.Framework;

namespace Questions
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase(new string[]{"abb", "abcfhdtj", "abd"},"ab")]
        [TestCase(new string[]{"flower", "flow", "flight"}, "fl")]
        [TestCase(new string[]{"reflower", "flower", "flow"}, "")]

        public void IsCodeWork(string[] test, string answer)
        {
            var trying = new Code().LongestCommonPrefix(test);

            Assert.That(trying, Is.EqualTo(answer));

        }



    }
}
