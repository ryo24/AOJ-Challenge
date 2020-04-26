using System;

namespace ITP1_2_B
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = Console.ReadLine();
      string[] line = input.Split(' ');
      if (int.Parse(line[0]) < int.Parse(line[1]) && int.Parse(line[1]) < int.Parse(line[2]))
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
