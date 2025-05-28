using Xunit;
using AwesomeApplication;

namespace AwesomeApplication.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void AddNumbers_ReturnsSum()
        {
            int result = Program.AddNumbers(2, 3);
            Assert.Equal(5, result);
        }
    }
}
