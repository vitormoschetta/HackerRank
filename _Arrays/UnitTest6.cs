namespace HackerRank._Arrays;
public class UnitTest6
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var input = new List<int> { 1, 2, 3 };

        // Act
        var result = LeftRotation(input, 1);

        // Assert
        Assert.Equal(new List<int> { 2, 3, 1 }, result);
    }


    [Fact]
    public void Test2()
    {
        // Arrange
        var input = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        var result = LeftRotation(input, 3);

        // Assert
        Assert.Equal(new List<int> { 4, 5, 1, 2, 3 }, result);
    }


    public List<int> LeftRotation(List<int> a, int d)
    {
        var result = new List<int>();
        for (int i = 0; i < a.Count; i++)
        {
            var index = (i + d) % a.Count;
            result.Add(a[index]);
        }
        return result;
    }
}