namespace HackerRank._Arrays;

/// <summary>
/// Dado um número (n) verificar se ele é multiplo de 3 e de 5.
/// Se for múltiplo de 3 e 5, imprimir 'FizzBuzz'.
/// Se for múltiplo de 3 apenas, imprimir 'Fizz'.
/// Se múltiplo de 5 apenas, imprimir 'Buzz'.
/// Se não for múltiplo nem de 3, nem de 5, imprimir o próprio número.
/// Ex: 15 = FizzBuzz; 3 = Fizz; 5 = Buzz; 2 = 2.
/// </summary>
public class UnitTest5
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var n = 15;

        // Act
        var result = FizzBuzz(n);

        // Assert
        Assert.Equal("FizzBuzz", result);
    }


    [Fact]
    public void Test2()
    {
        // Arrange
        var n = 3;

        // Act
        var result = FizzBuzz(n);

        // Assert
        Assert.Equal("Fizz", result);
    }


    [Fact]
    public void Test3()
    {
        // Arrange
        var n = 5;

        // Act
        var result = FizzBuzz(n);

        // Assert
        Assert.Equal("Buzz", result);
    }


    [Fact]
    public void Test4()
    {
        // Arrange
        var n = 2;

        // Act
        var result = FizzBuzz(n);

        // Assert
        Assert.Equal("2", result);
    }


    private string FizzBuzz(int n)
    {
        if (n % 3 == 0 && n % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (n % 3 == 0)
        {
            return "Fizz";
        }
        else if (n % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return n.ToString();
        }
    }
}
