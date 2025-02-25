
using MyLibrary;
using Xunit;

namespace MyConsoleApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            Assert.Equal("Hello, World!", class1.HelloWorld());
        }
    }
}