using NUnit.Framework;

namespace Questions
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase(new int[]{1,1,3},new int[]{2,3,4}, 2.5)]
        [TestCase(new int[]{1,3},new int[]{2,3,4}, 3)]
        [TestCase(new int[]{1,1,3},new int[]{2,3,4,5}, 3)]
        [TestCase(new int[]{1,2},new int[]{3,4}, 2.5)]
        [TestCase(new int[]{},new int[]{1}, 1)]
        [TestCase(new int[]{1},new int[]{}, 1)]
        [TestCase(new int[]{},new int[]{}, 0)]
        

        public void IsCodeWork(int[] test1 ,int[] test2, double answer)
        {
            var trying = new Code().FindMedianSortedArrays(test1, test2);

            Assert.That(trying, Is.EqualTo(answer));

        }



    }
}
