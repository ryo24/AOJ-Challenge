using System;

namespace ITP1_2_A
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = Console.ReadLine();
      string[] line = input.Split(' ');
      if (int.Parse(line[0]) < int.Parse(line[1]))
      {
        Console.WriteLine("a < b");
      }
      else if (int.Parse(line[0]) > int.Parse(line[1]))
      {
        Console.WriteLine("a > b");
      }
      else
      {
        Console.WriteLine("a == b");
      }


    }
  }
}
