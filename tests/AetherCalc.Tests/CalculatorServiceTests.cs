using Xunit;
using AetherCalc.Models;
using System;

namespace AetherCalc.Tests;

public class CalculatorServiceTests
{
    private readonly CalculatorService _service;

    public CalculatorServiceTests()
    {
        _service = new CalculatorService();
    }

    [Theory]
    [InlineData(10, 5, "+", 15)]
    [InlineData(10, 5, "-", 5)]
    [InlineData(10, 5, "*", 50)]
    [InlineData(10, 5, "/", 2)]
    public void ExecuteOperation_ShouldReturnCorrectResult(double left, double right, string op, double expected)
    {
        // Act
        var result = _service.ExecuteOperation(left, right, op);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ExecuteOperation_DivideByZero_ShouldThrowException()
    {
        // Assert
        Assert.Throws<DivideByZeroException>(() => 
            _service.ExecuteOperation(10, 0, "/"));
    }

    [Fact]
    public void ExecuteOperation_InvalidOperator_ShouldThrowException()
    {
        // Assert
        Assert.Throws<InvalidOperationException>(() => 
            _service.ExecuteOperation(10, 10, "%"));
    }
}