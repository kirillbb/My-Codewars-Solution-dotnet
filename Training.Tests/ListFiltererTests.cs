using Training.Classes;
using Xunit;

namespace Training.Tests
{
    public class ListFiltererTests
    {
        [Fact]
        public void GetIntegersFromListTest()
        {
            var list = new List<object>() { 1, 2, "a", "b" };
            var expected = new List<int>() { 1, 2 };
            var actual = ListFilterer.GetIntegersFromList(list);

            Assert.True(expected.SequenceEqual(actual));
        }
    }
}
