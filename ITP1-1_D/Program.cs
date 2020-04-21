using System;

namespace ITP1_1_D
{
  class Program
  {
    static void Main(string[] args)
    {
      int line = int.Parse(Console.ReadLine());
      int hour = line / (60 * 60);
      int minuts = (line % 3600) / 60;
      int second = line % 60;


      Console.WriteLine("{0}:{1}:{2}", hour, minuts, second);
    }
  }
}
