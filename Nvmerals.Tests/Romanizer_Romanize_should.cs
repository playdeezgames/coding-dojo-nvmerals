using Shouldly;

namespace Nvmerals.Tests
{
    public class Romanizer_Romanize_should
    {
        [Theory]
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        [InlineData(3,"III")]
        [InlineData(4,"IV")]
        public void convert_integers_into_roman_numeral_equivalent(int givenValue, string expectedResult)
        {
            Romanizer.Romanize(givenValue).ShouldBe(expectedResult);
        }
    }
}