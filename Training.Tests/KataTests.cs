using Training.Classes;
using Xunit;

namespace Training.Tests
{
    public class KataTests
    {
        [Fact]
        public void ToWeirdCaseTests()
        {
            Assert.Equal("Oh", Kata.ToWeirdCase("oh"));
            Assert.Equal("BoY", Kata.ToWeirdCase("BOY"));
            Assert.Equal("ThIs Is A TeSt", Kata.ToWeirdCase("This is a test"));
            Assert.Equal("OnCe, WhEn I WaS YoUnG, I CoDeD On ThE AmIgA!", Kata.ToWeirdCase("Once, when I was young, I coded on the Amiga!"));
        }

        [Fact]
        public void ValidatePinLengthTest()
        {
            Assert.False(Kata.ValidatePin("1"));
            Assert.False(Kata.ValidatePin("12"));
            Assert.False(Kata.ValidatePin("123"));
            Assert.False(Kata.ValidatePin("12345"));
            Assert.False(Kata.ValidatePin("1234567"));
            Assert.False(Kata.ValidatePin("-1234"));
            Assert.False(Kata.ValidatePin("-12345"));
            Assert.False(Kata.ValidatePin("1.234"));
            Assert.False(Kata.ValidatePin("-1.234"));
            Assert.False(Kata.ValidatePin("00000000"));
        }

        [Fact]
        public void ValidatePinNonDigitTest()
        {
            Assert.False(Kata.ValidatePin("a234"));
            Assert.False(Kata.ValidatePin(".234"));
        }

        [Fact]
        public void ValidatePinValidTest()
        {
            Assert.True(Kata.ValidatePin("0000"));
            Assert.True(Kata.ValidatePin("1234"));
            Assert.True(Kata.ValidatePin("1111"));
            Assert.True(Kata.ValidatePin("123456"));
            Assert.True(Kata.ValidatePin("098765"));
            Assert.True(Kata.ValidatePin("000000"));
            Assert.True(Kata.ValidatePin("090909"));
        }


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

        [Fact]
        public void DescendingOrderTest0()
        {
            Assert.Equal(0, Kata.DescendingOrder(0));
        }

        [Fact]
        public void DescendingOrderTest1()
        {
            Assert.Equal(1, Kata.DescendingOrder(1));
        }

        [Fact]
        public void DescendingOrderTest15()
        {
            Assert.Equal(51, Kata.DescendingOrder(15));
        }

        [Fact]
        public void DescendingOrderTest1021()
        {
            Assert.Equal(2110, Kata.DescendingOrder(1021));
        }

        [Fact]
        public void ToCamelCaseTest()
        {
            Assert.Equal("helloTests", Kata.ToCamelCase("hello-Tests"));
            Assert.Equal("HelloTests", Kata.ToCamelCase("Hello_tests"));
        }

        private static Random rnd = new Random();

        private static int[] solution(int[] arr) => arr.Where(v => v != 0).Concat(arr.Where(v => v == 0)).ToArray();
    }

}
