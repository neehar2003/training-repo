namespace TestProject;

public class CalculatorTests
{
    [Fact]
    public void Add_twoNumbers_returnSum()
    {
        //Arrange
        var calculator = new Calculator();
        int a = 2;
        int b = 3;

        //Act 
        int result = calculator.Add(a, b);

        //Assert
        Assert.Equal(5, result);
    }
    [Fact]
    public void Subtract_twoNumbers_returnsDifference()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 3;

        // Act
        int result = calculator.Subtract(a, b);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Divide_byZero_throwsException()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 10;
        int b = 0;

        // Act
        Action act = () => calculator.Divide(a, b);

        // Assert
        Assert.Throws<DivideByZeroException>(act);
    }
}