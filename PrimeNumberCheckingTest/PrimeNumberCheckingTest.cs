namespace PrimeNumberCheckingTest
{
    public class PrimeNumberCheckingTest
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        public void IsPrimeNumber_WithCheckInputs_ReturnsExpectedResults(int input, bool expected)
        {
            bool result = PrimeNumberChecking.IsPrimeNumber(input);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(10, true)]
        [InlineData(23, false)]
        [InlineData(97, false)]
        public void IsPrimeNumber_WithNumberOutOfRange_ThrowsArgumentOutOfRangeException(int input, bool expected)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PrimeNumberChecking.IsPrimeNumber(input, expected));
        }
    }
}