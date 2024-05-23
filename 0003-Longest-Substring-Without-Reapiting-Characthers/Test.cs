using NUnit.Framework;

namespace Questions
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("a", 1)]
        //[TestCase("({[]})", true)]

        public void IsCodeWork(string test, int answer)
        {
            var trying = new Code().LengthOfLongestSubstring(test);

            Assert.That(trying, Is.EqualTo(answer));

        }



    }
}
