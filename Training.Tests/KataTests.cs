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
        
        [Fact]
        public void GetMiddleTest()
        {
            Assert.Equal("es", Kata.GetMiddle("test"));
            Assert.Equal("t", Kata.GetMiddle("testing"));
            Assert.Equal("dd", Kata.GetMiddle("middle"));
            Assert.Equal("A", Kata.GetMiddle("A"));
        }

        [Fact]
        public void SumTwoSmallestNumbersTest_1()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.Equal(13, Kata.SumTwoSmallestNumbers(numbers));

        }

        [Fact]
        public void SumTwoSmallestNumbersTest_2()
        {
            int[] numbers2 = { 15, 28, 4, 2, 43 };
            Assert.Equal(6, Kata.SumTwoSmallestNumbers(numbers2));
        }

        [Fact]
        public void SumTwoSmallestNumbersTest_3()
        {
            int[] numbers3 = { 1000, 2, 3, 6 };
            Assert.Equal(5, Kata.SumTwoSmallestNumbers(numbers3));
        }

        private static Random rnd = new Random();

        private static int[] solution(int[] arr) => arr.Where(v => v != 0).Concat(arr.Where(v => v == 0)).ToArray();
    }

}
