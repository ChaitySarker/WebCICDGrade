using Xunit;
using GradeSystem;

namespace GradeSystemTest
{
    public class AttendanceServiceTests
    {
        AttendanceService a = new AttendanceService();

        [Fact]
        public void Attended_22_Days_Present()
            => Assert.True(a.IsPresent(22));

        [Fact]
        public void Attended_18_Days_Absent()
            => Assert.False(a.IsPresent(18));
    }
}
