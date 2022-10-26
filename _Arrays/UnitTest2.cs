namespace HackerRank._Arrays;

/// <summary>
/// Dada uma string com letras minúsculas, e um número inteiro que representa a quantidade de caracteres que deve existir na string, 
/// verifique quantas vezes a string deve ser repetida para que a quantidade de caracteres seja igual ao número informado.
/// E depois disso verifique quantas vezes a letra 'a' aparece na string.
/// Ex: "abc" e 10, a string deve ser repetida 3 vezes por completo + uma letra pra compeletar os 10 caracteres, ficando "abcabcabca", e a letra 'a' aparece 4 vezes.
/// </summary>
public class UnitTest2
{
    [Fact]
    public void Test0()
    {
        // Arrange
        var s = "abc";
        var n = 10;

        // Act
        var a = RepeatedString(s, n);

        // Assert
        Assert.Equal(4, a);
    }

    [Fact]
    public void Test1()
    {
        // Arrange
        var s = "aba";
        var n = 10;

        // Act
        var a = RepeatedString(s, n);

        // Assert
        Assert.Equal(7, a);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var s = "abcac";
        var n = 10;

        // Act
        var a = RepeatedString(s, n);

        // Assert
        Assert.Equal(4, a);
    }


    [Fact]
    public void Test3()
    {
        // Arrange
        var s = "a";
        var n = 1000000000000;

        // Act
        var a = RepeatedString(s, n);

        // Assert
        Assert.Equal(1000000000000, a);
    }


    /// <summary>
    /// Essa é uma possível solução, mas não é a mais performática. Ela falha no Test3, pois o resultado é muito grande para ser armazenado em um inteiro.
    /// Sem contar que ela é muito lenta, e consome muita memória, desnecessariamente.
    /// </summary>
    private static long RepeatedString1(string s, long n)
    {
        var length = s.Length;
        var repeat = (int)(n / length);
        var rest = (int)(n % length);
        var text = string.Empty;

        for (int i = 0; i < repeat; i++)
        {
            text += s;
        }

        text += s.Substring(0, rest);

        return text.Count(x => x == 'a');
    }

    /// <summary>
    /// Essa é a solução mais performática, e que consome menos memória.
    /// Ela consiste em calcular quantas vezes a letra 'a' aparece na string inicial.
    /// Depois disso basta multiplicar a quantidade de vezes que ela aparece na string inicial pelo número de repetições necessárias para atingir o número informado.
    /// E por fim, basta somar a quantidade de vezes que a letra 'a' aparece no resto da string.    
    /// </summary>
    private static long RepeatedString(string s, long n)
    {
        if (s == "a")
        {
            return n;
        }

        long count = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                count++;
            }
        }

        var q = n / s.Length;

        count = count * q;

        var r = n % s.Length;

        for (var i = 0; i < r; i++)
        {
            if (s[i] == 'a')
            {
                count++;
            }
        }

        return count;
    }
}