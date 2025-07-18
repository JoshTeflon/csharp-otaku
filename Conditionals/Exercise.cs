namespace csharp_otaku.Conditionals
{
  static class Exercise
  {
    public static void ValidateOneToTen()
    {
      Console.Write("Enter a number between 1 and 10:");

      var input = Console.ReadLine();
      int number = Convert.ToInt32(input);

      bool isValid = number >= 1 && number <= 10;
      string message = isValid ? "Valid" : "Invalid";

      Console.WriteLine(message);
    }

    public static void GetDualMax()
    {
      Console.Write("Enter first number: ");
      var inputA = Console.ReadLine();
      int a = Convert.ToInt32(inputA);

      Console.Write("Enter second number: ");
      var inputB = Console.ReadLine();
      int b = Convert.ToInt32(inputB);

      if (a > b)
      {
        Console.WriteLine($"Max is {a}");
      }
      else if (b > a)
      {
        Console.WriteLine($"Max is {b}");
      }
      else
      {
        Console.WriteLine($"{a} == {b}");
      }
    }
  }
}