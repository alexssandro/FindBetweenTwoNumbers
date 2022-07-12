using FindBetweenTwoNumbers;
using FluentAssertions;

namespace FingBetweenTwoNumbersTests
{
    public class NumberFinderTest
    {
        [Theory]
        [InlineData(10, 30, 25)]
        [InlineData(10, 1000000, 45)]
        [InlineData(-50, 250, 12)]
        public void GivingMinAndMaxShouldDetermineTheNumber(int min, int max, int secret)
        {
            var numberFinder = new NumberFinder(secret);

            int foundNumber = numberFinder.FindSecretNumber(min, max);

            foundNumber.Should().Be(secret);
        }
    }
}