using NUnit.Framework;

namespace Questions
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase("(", false)]
        [TestCase("({)", false)]
        [TestCase("({)}", false)]
        [TestCase("{[]}", true)]
        [TestCase("()[]{}", true)]
        [TestCase("({[]})", true)]

        public void IsCodeWork(string test, bool answer)
        {
            var trying = new Code().IsValid(test);

            Assert.That(trying, Is.EqualTo(answer));

        }



    }
}
