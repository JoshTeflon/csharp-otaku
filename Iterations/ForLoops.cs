namespace csharp_otaku.Iterations
{
  static class ForLoops
  {
    public static void PrimeNumberCheck()
    {
      Console.Write("Enter a number to check if it is prime: ");
      var input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      
      if (number < 2)
      {
        Console.WriteLine($"{number} is not a prime number.");
        return;
      }

      for (int i = 2; i <= (int)Math.Sqrt(number); i++)
      {
        if (number % i == 0)
        {
          Console.WriteLine($"{number} is not a prime number");
          return;
        }
      }

      Console.WriteLine($"{number} is a prime number");
    }

    public static void ForForEachDifference()
    {
      var name = "Teflon";

      for (var i = 0; i < name.Length; i++)
      {
        Console.WriteLine(name[i]);
      }

      foreach (var character in name)
      {
        Console.WriteLine(character);
      }

      var numbers = new int[] { 1, 2, 3, 4 };

      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }
    }
  }
}