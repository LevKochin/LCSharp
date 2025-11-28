// See https://aka.ms/new-console-template for more information

using LCSharp.Array.Library;

int[] output = [2, 3, 5, 4, 1, 7];

ArrayStirrerService r = new();
int[] result = r.Shuffle( [2, 5, 1, 3, 4, 7], 3);
if (output == result)
{
    Console.WriteLine("Отлично!");
}

Console.WriteLine(string.Join(", " ,result));

// int[] result2 = r.Shuffle( [1,2,3,4,4,3,2,1], 4);
// Console.WriteLine(string.Join(", " ,result2));