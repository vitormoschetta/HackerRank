using _JokenPo2.Entities;
using _JokenPo2.Enums;

namespace _JokenPo2;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var jogador1 = new Jogador { Name = "Vitor", JokenPo = EJokenPo.Pedra };
        var jogador2 = new Jogador { Name = "Cris", JokenPo = EJokenPo.Papel };

        // Act
        var vencedor = Jogo.Jogar2(jogador1, jogador2);

        // Assert
        Assert.Equal("Cris", vencedor);        
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var jogador1 = new Jogador { Name = "Vitor", JokenPo = EJokenPo.Tesoura };
        var jogador2 = new Jogador { Name = "Cris", JokenPo = EJokenPo.Papel };

        // Act
        var vencedor = Jogo.Jogar2(jogador1, jogador2);

        // Assert
        Assert.Equal("Vitor", vencedor);        
    }
}