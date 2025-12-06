// See https://aka.ms/new-console-template for more information

using LCSharp.Array.Library;

int[] output = [1,1,0,1,1,1];

ArrayConsecutiveCounterService s = new();
int r = s.FindMaxConsecutiveOnes(output);
Console.WriteLine(r);