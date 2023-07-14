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
        [InlineData(5,"V")]
        [InlineData(6,"VI")]
        [InlineData(7,"VII")]
        [InlineData(8,"VIII")]
        [InlineData(9,"IX")]
        [InlineData(10,"X")]
        [InlineData(11,"XI")]
        [InlineData(12,"XII")]
        [InlineData(19,"XIX")]
        [InlineData(20,"XX")]
        [InlineData(40,"XL")]
        [InlineData(50,"L")]
        [InlineData(90,"XC")]
        public void convert_integers_into_roman_numeral_equivalent(int givenValue, string expectedResult)
        {
            var actual = Romanizer.Romanize(givenValue);
            actual.ShouldBe(expectedResult);
            actual.Count(x=>x=='I').ShouldBeLessThanOrEqualTo(3);
        }
    }
}