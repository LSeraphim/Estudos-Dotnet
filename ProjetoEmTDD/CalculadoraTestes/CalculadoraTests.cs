using System.ComponentModel;
using Calculadora;

namespace CalculadoraTestes;
public class CalculadoraTests
{
    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }


    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        int resultadoSoma = _calc.Somar(num1, num2);
        Assert.Equal(resultado, resultadoSoma);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        int resultadoSoma = _calc.Multiplicar(num1, num2);
        Assert.Equal(resultado, resultadoSoma);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        int resultadoSoma = _calc.Dividir(num1, num2);
        Assert.Equal(resultado, resultadoSoma);
    }


    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        int resultadoSoma = _calc.Subtrair(num1, num2);
        Assert.Equal(resultado, resultadoSoma);
    }

    [Fact]
    public void TesteDividirPorZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3,0)
        );
    }


    [Fact]
    public void TesteHistorico()
    {
        _calc.Somar(2, 3);
        _calc.Somar(5, 6);
        _calc.Somar(1, 7);

        //List<string> lista = calc.historico();
        var lista = _calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

}