using Xunit;

public class MyClassTests
{
    private readonly MyClass _myClass;

    public MyClassTests()
    {
        _myClass = new MyClass();
    }

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        int result = _myClass.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void IsEven_ShouldReturnTrueForEvenNumber()
    {
        // Arrange
        int number = 4;

        // Act
        bool result = _myClass.IsEven(number);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsEven_ShouldReturnFalseForOddNumber()
    {
        // Arrange
        int number = 5;

        // Act
        bool result = _myClass.IsEven(number);

        // Assert
        Assert.False(result);
    }
}
