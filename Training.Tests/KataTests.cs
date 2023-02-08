using Training.Classes;
using Xunit;

namespace Training.Tests
{
    public class KataTests
    {
        [Fact]
        public void MoveZeroesSampleTest()
        {
            Assert.Equal(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }

        [Fact]
        public void MoveZeroesRandomTest()
        {
            const int Tests = 100;

            for (int i = 0; i < Tests; ++i)
            {
                int[] test = new int[rnd.Next(4, 100)].Select(_ => rnd.Next(0, 6)).ToArray();

                int[] expected = solution(test);
                int[] actual = Kata.MoveZeroes(test);

                Assert.Equal(expected, actual);
            }
        }

        private static Random rnd = new Random();

        private static int[] solution(int[] arr) => arr.Where(v => v != 0).Concat(arr.Where(v => v == 0)).ToArray();
    }

}
