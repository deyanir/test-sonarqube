using Xunit;
using MyDotnetApp;

namespace MyDotnetApp.Tests
{
    public class MyClassTests
    {
        [Fact]
        public void AddNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var myClass = new MyClass("TestName");
            int num1 = 3;
            int num2 = 5;

            // Act
            int result = myClass.AddNumbers(num1, num2);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void NameProperty_ShouldBeSetCorrectly()
        {
            // Arrange
            var myClass = new MyClass("John Doe");

            // Assert
            Assert.Equal("John Doe", myClass.Name);
        }
    }
}
