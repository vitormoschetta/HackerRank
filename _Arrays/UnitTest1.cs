namespace HackerRank._Arrays;

/// <summary>
/// Dado um array binário, que é um array que contém apenas 0s e 1s, identifique a quantidade mínima de saltos que são necessários para chegar ao final do array.
/// Regras: Deve evitar os 1s. Só pode pular no máximo 2 casas.
/// </summary>
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var nuvens = new List<int> { 0, 0, 0, 0, 1, 0 };

        // Act
        var jumps = JumpingOnClouds(nuvens);

        // Assert
        Assert.Equal(3, jumps);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var nuvens = new List<int> { 0, 0, 1, 0, 0, 1, 0 };

        // Act
        var saltos = JumpingOnClouds(nuvens);

        // Assert
        Assert.Equal(4, saltos);
    }

    private static int JumpingOnClouds(List<int> c)
    {
        var jumps = 0;
        var i = 0;
        while (i < c.Count - 1)
        {
            if (i + 2 < c.Count && c[i + 2] == 0)
            {
                i += 2;
            }
            else
            {
                i++;
            }
            jumps++;
        }
        return jumps;
    }
}

