namespace csharp_otaku.Iterations
{
  static class ForLoop
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
  }
}