namespace calculadora.tests;
public class CalculadoraTest
{
    [Fact]
    public void Somar_RetornarValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Somar(10, 20);
        Assert.Equal(30, resultado);
    }

    [Fact]
    public void Subtrair_RetornarValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Subtrair(10, 5);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Multiplicar_RetornarValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Multiplicar(10, 20);
        Assert.Equal(200, resultado);
    }

    [Fact]
    public void Dividir_RetornarValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Dividir(20, 20);
        Assert.Equal(1, resultado);
    }

}

