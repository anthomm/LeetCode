using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy.MergeLinked;

namespace Testing.Easy.MergeLinked
{
    [TestClass]
    public class TestMergeLinkedNaive
    {

        [TestMethod]
        public void EqualsTest1()
        {
            string left = "0 1 2 3 4";
            string right = "5 6 7 8 9";
            string expectedResult = "0 1 2 3 4 5 6 7 8 9";
            string result = MergeLinkedNaive.Run(left, right);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void EqualsTest2()
        {
            string left = "1 3 5 7 9";
            string right = "0 2 4 6 8 10";
            string expectedResult = "0 1 2 3 4 5 6 7 8 9 10";
            string result = MergeLinkedNaive.Run(left, right);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
