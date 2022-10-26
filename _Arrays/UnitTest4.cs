namespace HackerRank._Arrays;

/// <summary>
/// Data duas strings com array de inteiros:
/// - Converte em dois arrays de inteiros
/// - Compara item de uma lista com da outra lista na mesma posição
/// - O item maior de uma determinada posição entre as duas lista ganha um ponto para a sua lista
/// - Retorna o número de pontos de cada lista
/// Ex: [1, 2, 3] e [3, 2, 1] = 1 ponto para a primeira lista e 1 ponto para a segunda lista
/// </summary>
public class UnitTest4
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var a = "5 6 7";
        var b = "3 6 10";

        // Act
        var (aPoints, bPoints) = Compare(a, b);

        // Assert
        Assert.Equal(1, aPoints);
        Assert.Equal(1, bPoints);
    }


    [Fact]
    public void Test2()
    {
        // Arrange
        var a = "1 2 3";
        var b = "1 2 3";

        // Act
        var (aPoints, bPoints) = Compare(a, b);

        // Assert
        Assert.Equal(0, aPoints);
        Assert.Equal(0, bPoints);
    }


    [Fact]
    public void Test3()
    {
        // Arrange
        var a = "1";
        var b = "1";

        // Act
        var (aPoints, bPoints) = Compare(a, b);

        // Assert
        Assert.Equal(0, aPoints);
        Assert.Equal(0, bPoints);
    }


    [Fact]
    public void Test4()
    {
        // Arrange
        var a = "5 6 9";
        var b = "1 2 3";

        // Act
        var (aPoints, bPoints) = Compare(a, b);

        // Assert
        Assert.Equal(3, aPoints);
        Assert.Equal(0, bPoints);
    }


    private (int, int) Compare(string a, string b)
    {
        var aList = a.Split(' ').Select(x => int.Parse(x)).ToList();
        var bList = b.Split(' ').Select(x => int.Parse(x)).ToList();

        var aPoints = 0;
        var bPoints = 0;

        for (int i = 0; i < aList.Count; i++)
        {
            if (aList[i] > bList[i])
                aPoints++;
            else if (aList[i] < bList[i])
                bPoints++;
        }

        return (aPoints, bPoints);
    }
}
