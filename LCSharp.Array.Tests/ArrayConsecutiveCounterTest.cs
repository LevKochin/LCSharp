namespace LCSharp.Array.Tests;

using Library;

public class ArrayConsecutiveCounterTest(ITestOutputHelper outputHelper)
{
    private readonly ArrayConsecutiveCounterService _service = new();
    
    [Fact]
    public void CounterTest1()
    {
        // Arrange
        int[] input = [1,1,0,1,1,1];
        int output = 3;
        
        // Act
        int result = _service.FindMaxConsecutiveOnes(input);
        
        // Output View
        outputHelper.WriteLine("input: {0}", string.Join(", ", input));
        outputHelper.WriteLine("expected output: {0}", string.Join(", ", output));
        outputHelper.WriteLine("resulted output: {0}", string.Join(", ", result));
        
        // Assert
        Assert.Equal(output, result);
    }

    [Fact]
    public void CounterTest2()
    {
        // Arrange
        int[] input = [1,0,1,1,0,1];
        int output = 2;
        
        // Act
        int result =  _service.FindMaxConsecutiveOnes(input);
        
        // Output View
        outputHelper.WriteLine("input: {0}", string.Join(", ", input));
        outputHelper.WriteLine("expected output: {0}", string.Join(", ", output));
        outputHelper.WriteLine("resulted output: {0}", string.Join(", ", result));

        // Assert
        Assert.Equal(output, result);
    }
}