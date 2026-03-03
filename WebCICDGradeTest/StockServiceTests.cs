using Xunit;
using GradeSystem;

namespace GradeSystemTest
{
    public class StockServiceTests
    {
        StockService s = new StockService();

        [Fact]
        public void Stock_10_Request_5_True()
            => Assert.True(s.CanSell(10, 5));

        [Fact]
        public void Stock_5_Request_8_False()
            => Assert.False(s.CanSell(5, 8));
    }
}
