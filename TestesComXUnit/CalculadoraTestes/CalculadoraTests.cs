using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSubtrair5Com10ERetornar5()
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(5, resultado);
    }

        [Fact]
    public void DeveSubtrair10Com5ERetornar5Negativo()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(-5, resultado);
    }

    [Fact]
    public void DeveMultiplicar5Com10ERetornar50()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(50, resultado);
    }


    [Fact]
    public void DeveDividir10Com5ERetornar2()
    {
        // Arrange
        int num1 = 10;
        int num2 = 5;

        // Act
        int resultado = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EParRetornarVerdadeiro()
    {
        // Arrange
        int num = 4;

        // Act
        bool resultado = _calc.EhPar(num);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int [] {2 , 4})]
    [InlineData(new int [] {6, 8, 10})]
    public void DeveVerificarSeOsNumerosSaoPares(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}