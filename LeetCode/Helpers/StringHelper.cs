using System.Text;

namespace LeetCode.Helpers
{
    static class StringHelper
    {
        public static string IntArrayToString(int[] array)
        {
            StringBuilder sb = new StringBuilder();

            foreach(int i in array)
            {
                sb.Append($"{i} ");
            }

            string returnee = sb.ToString();
            returnee.Trim();

            return returnee;
        }
    }
}
