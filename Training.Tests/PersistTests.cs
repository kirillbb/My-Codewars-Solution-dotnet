using Training.Classes;
using Xunit;

namespace Training.Tests
{
    public class PersistTests
    {
        [Fact]
        public void PersistenceBasicTests()
        {
            Assert.Equal(3, Persist.Persistence(39));
            Assert.Equal(0, Persist.Persistence(4));
            Assert.Equal(2, Persist.Persistence(25));
            Assert.Equal(4, Persist.Persistence(999));
            Assert.Equal(3, Persist.Persistence(444));
        }
    }
}
