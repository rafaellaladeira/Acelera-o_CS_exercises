using Xunit;
using FluentAssertions;
using triangulo;

namespace triangulo.test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve classificar o tipo de triângulo")]
    [InlineData(2,2,2, "Triângulo Equilátero")]
    [InlineData(5,6,6, "Triângulo Isósceles")]
    [InlineData(6,2,6, "Triângulo Isósceles")]
    [InlineData(6,6,2, "Triângulo Isósceles")]
    [InlineData(1,2,3, "Triângulo Escaleno")]
    public void Test1(double xSide, double ySide, double zSide, string expected)
    {
        var resultName = triangle.teste(xSide, ySide, zSide);
        resultName.Should().Be(expected);
    }
}