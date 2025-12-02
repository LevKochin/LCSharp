namespace LCSharp.Array.Tests;

using Library;

public class ArrayStirrerTest(ITestOutputHelper outputHelper)
{
    private readonly ArrayStirrerService _service = new();

    [Fact]
    public void ShuffleTest1()
    {
        // Arrange
        int[] input = [2, 5, 1, 3, 4, 7];
        int[] output = [2, 3, 5, 4, 1, 7];
        const int n = 3;

        // Act
        int[] result = _service.Shuffle(input, n);
        
        // View output
        outputHelper.WriteLine("input: {0} \n", string.Join(", ", input));
        outputHelper.WriteLine("expected output: {0}", string.Join(", ", output));
        outputHelper.WriteLine("resulted output: {0}", string.Join(", ", result));

        // Assert
        Assert.Equal(output, result);
    }

    [Fact]
    public void ShuffleTest2()
    {
        // Arrange
        int[] input = [1, 2, 3, 4, 4, 3, 2, 1];
        int[] output = [1, 4, 2, 3, 3, 2, 4, 1];
        const int n = 4;

        // Act
        int[] result = _service.Shuffle(input, n);
        
        // View output
        outputHelper.WriteLine("input: {0} \n", string.Join(", ", input));
        outputHelper.WriteLine("expected output: {0}", string.Join(", ", output));
        outputHelper.WriteLine("resulted output: {0}", string.Join(", ", result));

        // Assert
        Assert.Equal(output, result);
    }

    [Fact]
    public void ShuffleTest3()
    {
        // Arrange
        int[] input = [1,1,2,2];
        int[] output = [1, 2, 1, 2];
        const int n = 2;
        
        // Act
        int[] result = _service.Shuffle(input, n);
        
        // View output
        outputHelper.WriteLine("input: {0} \n", string.Join(", ", input));
        outputHelper.WriteLine("expected output: {0}", string.Join(", ", output));
        outputHelper.WriteLine("resulted output: {0}", string.Join(", ", result));
        
        // Assert
        Assert.Equal(output, result);
    }
}