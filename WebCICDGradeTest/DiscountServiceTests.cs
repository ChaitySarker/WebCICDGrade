using Xunit;
using GradeSystem;

namespace GradeSystemTest
{
    public class DiscountServiceTests
    {
        DiscountService s = new DiscountService();

        [Fact]
        public void Amount_12000_Gives_20_Percent()
            => Assert.Equal(2400, s.GetDiscount(12000));

        [Fact]
        public void Amount_6000_Gives_10_Percent()
            => Assert.Equal(600, s.GetDiscount(6000));

        [Fact]
        public void Amount_1500_Gives_5_Percent()
            => Assert.Equal(75, s.GetDiscount(1500));

        [Fact]
        public void Amount_500_Gives_Zero()
            => Assert.Equal(0, s.GetDiscount(500));
    }
}
