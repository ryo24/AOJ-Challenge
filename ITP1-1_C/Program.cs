using System;

namespace ITP1_1_C
{
  class Program
  {
    static void Main(string[] args)
    {

      //どこかでmapと多重代入を使って書き直したい
      var line = Console.ReadLine();
      string[] data = line.Split(' ');
      int a = int.Parse(data[0]);
      int b = int.Parse(data[1]);
      int area = a * b;
      int length = a * 2 + b * 2;
      Console.WriteLine("{0} {1}", area, length);
    }
  }
}
