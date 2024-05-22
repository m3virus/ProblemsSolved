using NUnit.Framework;

namespace Questions
{
    [TestFixture]
    public class Test
    {
        [Test]
        [TestCase(new int[] { 9 }, new int[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
        [TestCase(new int[] { 5, 0, 9 }, new int[] { 4, 5, 6 }, new int[] { 9, 5, 5, 1 })]
        [TestCase(new int[] { 9, 2, 1 }, new int[] { 4, 5, 6 }, new int[] { 3, 8, 7 })]

        public void IsTwoSumWorked(int[] l1, int[] l2, int[] answer)
        {
            var func = new Code();

            var list1 = Code.MakeListNode(l1);
            var list2 = Code.MakeListNode(l2);
            var response = func.AddTwoNumbers(list1, list2);
            var result = Code.MakeListNode(answer);

            while (response != null)
            {
                Assert.That(response.val, Is.EqualTo(result.val));

                response = response.next;
                result = result.next;

            }


        }



    }
}
