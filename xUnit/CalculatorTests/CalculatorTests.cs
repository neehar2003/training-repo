namespace CalculatorTests;

public class CalculatorTests
{
    [Fact]
    public void Add_twoNumbers_returnsSum()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Add(2, 3);

        //Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_twoNumbers_returnsDifference()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Subtract(5, 3);

        //Assert
        Assert.Equal(2, result);
    }
    [Fact]
    public void Multiply_twoNumbers_returnsProduct()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Multiply(7, 0);

        //Assert
        Assert.Equal(0, result);
    }
    [Fact]
    public void Divide_twoNumbers_returnsQuotient()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Divide(7, 2);

        //Assert
        Assert.Equal(3, result);
    }
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, -5, -6)]
    [InlineData(5, 0, 5)]
    public void Add_inputs_returnsExpectedSum(int a, int b, int expected)
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Add(a, b);

        //Assert
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(-1, -5, 4)]
    [InlineData(0, -5, 5)]
    public void Subtract_inputs_returnsExpectedDifference(int a, int b, int expected)
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Subtract(a, b);

        //Assert
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(3, 2, 6)]
    [InlineData(-1, -5, 5)]
    [InlineData(0, -5, 0)]
    public void Multiply_inputs_returnsExpectedProduct(int a, int b, int expected)
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Multiply(a, b);

        //Assert
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(10, 5, 2)]
    [InlineData(10, -5, -2)]
    [InlineData(0, 5, 0)]
    public void Divide_inputs_returnsExpectedQuotient(int a, int b, int expected)
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Divide(a, b);

        //Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Divide_byZero_throwsDivideByZeroException()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        //stores the call to Divide by 0, nothing is divided yet
        Action act = () => calculator.Divide(5, 0);

        //Assert
        //runs stored action and assert that running act throws a DivideByZero exception
        Assert.Throws<DivideByZeroException>(act);
    }
}
