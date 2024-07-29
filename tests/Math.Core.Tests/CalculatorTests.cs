namespace Math.Core.Tests;

using FluentAssertions;

public class CalculatorTests
{
    [Fact]
    public void Add()
    {
        var result = Calculator.Add(3.0f, 5.0f);
        result.Should().Be(8.0f);
    }
}