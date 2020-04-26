using System;

namespace ITP1_2_C
{
  class Program
  {
    static void Main(string[] args)
    {
      var tmp = "0";
      var input = Console.ReadLine();
      string[] line = input.Split(' ');
      if (int.Parse(line[0]) > int.Parse(line[1]))
      {
        tmp = line[0];
        line[0] = line[1];
        line[1] = tmp;

      }
      if (int.Parse(line[1]) > int.Parse(line[2]))
      {
        tmp = line[1];
        line[1] = line[2];
        line[2] = tmp;

      }
      if (int.Parse(line[0]) > int.Parse(line[1]))
      {
        tmp = line[0];
        line[0] = line[1];
        line[1] = tmp;

      }

      Console.WriteLine("{0} {1} {2}", line[0], line[1], line[2]);



    }


  }
}
