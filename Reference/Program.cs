using System;

namespace Reference
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] targetNumbers = {23, 56, 90, 100};

      int[] targetNumbers2 = targetNumbers;


      targetNumbers[0] = 255;

      Console.WriteLine(targetNumbers2[0]);

      // Console.WriteLine(targetNumbers[0]);

      // DoStuff(targetNumbers);

      // Console.WriteLine(targetNumbers[0]);
      
      
      // int hp = 100;

      // hp = DecreaseHp(hp);

      // Console.WriteLine(hp);

      Console.ReadLine();
    }

    public static void DoStuff(int[] numbers)
    {
      numbers[0] = 100;
    }

    public static int DecreaseHp(int h)
    {
      h -= 50;
      return h;
    }
  }
}
