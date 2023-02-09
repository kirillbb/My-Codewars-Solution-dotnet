using Training.Classes;
using Xunit;

namespace Training.Tests
{
    public class DnaStrandTests
    {
        [Fact]
        public void MakeComplementSimpleTests()
        {
            Assert.Equal("ATGC", DnaStrand.MakeComplement("TACG"));
            Assert.Equal("TATAG", DnaStrand.MakeComplement("ATATC"));
            Assert.Equal("CCGGAT", DnaStrand.MakeComplement("GGCCTA"));
        }
    }
}
