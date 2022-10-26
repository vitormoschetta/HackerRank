namespace HackerRank._Arrays;

/// <summary>
/// Dada uma lista de inteiros, identifique quantos pares de números existem na lista.
/// Ex: [1, 2, 3, 2, 1] = 2 pares (1, 1) e (2, 2)
/// Ex2: [10, 20, 20, 10, 10, 30, 50, 10, 20] = 3 pares (10, 10), (20, 20) e (10, 10)
/// </summary>
public class UnitTest3
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var list = new int[] { 1, 2, 3, 2, 1 };

        // Act
        var pairs = GetPairs3(list);

        // Assert
        Assert.Equal(2, pairs);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var numbers = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20, 20, 10 };

        // Act
        var pairs = GetPairs3(numbers);

        // Assert
        Assert.Equal(4, pairs);
    }


    private int GetPairs1(int[] numbers)
    {
        var pairs = 0;

        var numbersList = new List<int>(numbers);

        while (numbersList.Count > 0)
        {
            var number = numbersList[0];
            numbersList.Remove(number);

            if (numbersList.Contains(number))
            {
                numbersList.Remove(number);
                pairs++;
            }
        }

        return pairs;
    }


    private int GetPairs2(int[] numbers)
    {
        var pairs = 0;

        while (numbers.Length > 1)
        {
            var initial = numbers[0];
            var items = numbers.Where(x => x == initial).ToList();

            if (items.Count() > 1)
                pairs = pairs + items.Count / 2;

            numbers = numbers.Where(x => x != items[0]).ToArray();
        }

        return pairs;
    }


    private int GetPairs3(int[] numbers)
    {
        var pairs = 0;

        var numbersCount = new Dictionary<int, int>();

        foreach (var number in numbers)
        {
            if (numbersCount.ContainsKey(number))
            {
                numbersCount[number]++;
            }
            else
            {
                numbersCount.Add(number, 1);
            }
        }

        foreach (var number in numbersCount)
        {
            if (number.Value > 1)
            {
                pairs += number.Value / 2;
            }
        }

        return pairs;
    }
}
