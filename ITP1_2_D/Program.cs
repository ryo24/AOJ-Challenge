using System;

namespace ITP1_2_D
{
  class Program
  {
    static void Main(string[] args)
    {
      bool flag = true;
      var line = Console.ReadLine().Split();
      int[] input = new int[5];
      for (int i = 0; i < line.Length; i++)
      {
        input[i] = int.Parse(line[i]);
      }

      if (input[2] < input[4] || input[3] < input[4])
      {
        flag = false;
      }
      if (input[0] - input[2] < input[4] || input[1] - input[3] < input[4])
      {
        flag = false;
      }

      if (flag)
      {
        Console.WriteLine("Yes");

      }
      else
      {
        Console.WriteLine("No");

      }

    }
  }
}
