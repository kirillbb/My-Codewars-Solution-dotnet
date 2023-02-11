using Training.Classes;
using Xunit;

namespace Training.Tests
{
    public class TowerBuilderTests
    {
        [Fact]
        public void BuildBasicTest()
        {
            Assert.Equal(string.Join(",", new[] { "*" }), string.Join(",", TowerBuilder.Build(1)));
            Assert.Equal(string.Join(",", new[] { " * ", "***" }), string.Join(",", TowerBuilder.Build(2)));
            Assert.Equal(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", TowerBuilder.Build(3)));
        }
    }
}
