using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy.ValidParantheses;

namespace Testing.Easy.ValidParantheses
{
    [TestClass]
    public class TestNaive
    {
        [TestMethod]
        public void TrueTest1()
        {
            Assert.IsTrue(ValidParenthesesNaive.Run("()"));
        }

        [TestMethod]
        public void TrueTest2()
        {
            Assert.IsTrue(ValidParenthesesNaive.Run("()()"));
        }

        [TestMethod]
        public void TrueTest3()
        {
            Assert.IsTrue(ValidParenthesesNaive.Run("[]{}()"));
        }

        [TestMethod]
        public void TrueTest4()
        {
            Assert.IsTrue(ValidParenthesesNaive.Run("([{}])"));
        }

        [TestMethod]
        public void FalseTest1()
        {
            Assert.IsFalse(ValidParenthesesNaive.Run("([)]"));
        }

        [TestMethod]
        public void FalseTest2()
        {
            Assert.IsFalse(ValidParenthesesNaive.Run("({[])}"));
        }

        [TestMethod]
        public void FalseTest3()
        {
            Assert.IsFalse(ValidParenthesesNaive.Run("((())"));
        }
    }
}
