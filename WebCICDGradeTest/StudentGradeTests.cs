using Xunit;
using GradeSystem;

namespace GradeSystemTest
{
    public class StudentGradeTests
    {
        private readonly Grade service = new Grade();

        [Fact]
        public void Marks_85_Returns_A()
        {
            var result = service.GetGrade(85);
            Assert.Equal("A", result);
        }

        [Fact]
        public void Marks_65_Returns_B()
        {
            var result = service.GetGrade(65);
            Assert.Equal("B", result);
        }

        [Fact]
        public void Marks_45_Returns_C()
        {
            var result = service.GetGrade(45);
            Assert.Equal("C", result);
        }

        [Fact]
        public void Marks_30_Returns_F()
        {
            var result = service.GetGrade(30);
            Assert.Equal("F", result);
        }
    }
}
