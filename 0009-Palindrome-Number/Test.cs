using NUnit.Framework;

namespace Questions
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase(121,true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        [TestCase(1000021, false)]
        [TestCase(100021, false)]
        [TestCase(100001, true)]

        public void IsCodeWork(int test, bool answer)
        {
            var trying = new Code().IsPalindrome(test);

            Assert.That(trying, Is.EqualTo(answer));

        }



    }
}
