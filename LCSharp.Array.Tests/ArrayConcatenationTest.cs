namespace LCSharp.Array.Tests;

using Library;

public class ArrayConcatenationTest(ITestOutputHelper outputHelper)
{
    private readonly ArrayConcatenationService _service = new();

    [Fact]
    public void ConcatArrayTest1()
    {
        // Arrange
        int[] input = [1, 2, 1];
        int[] output = [1, 2, 1, 1, 2, 1];
        
        // Act
        int[] result = _service.ConcatArray(input);
        
        // View Output
        outputHelper.WriteLine("input: {0}", string.Join(", ", input));
        outputHelper.WriteLine("expected output: {0}", string.Join(", ", output));
        outputHelper.WriteLine("resulted output: {0}", string.Join(", ", result));
        
        // Assert
        Assert.Equal(result, output);
    }

    [Fact]
    public void ConcatArrayTest2()
    {
        // Arrange
        int[] input = [1, 3, 2, 1];
        int[] output = [1, 3, 2, 1, 1, 3, 2, 1];
        
        // Act
        int[] result = _service.ConcatArray(input);
        
        // View Output
        outputHelper.WriteLine("input: {0}", string.Join(", ", input));
        outputHelper.WriteLine("expected output: {0}", string.Join(", ", output));
        outputHelper.WriteLine("resulted output: {0}", string.Join(", ", result));
        
        // Assert
        Assert.Equal(result, output);
    }
}