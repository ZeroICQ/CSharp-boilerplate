using Xunit;

namespace App.Tests
{
    public class AppTests
    {
        [Fact]
        public void SampleTest()
        {
            Assert.True(App.Program.SampleMethod());
        }
    }
}