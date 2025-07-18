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

    public static void ValidateImageOreintation()
    {
      Console.Write("Enter image width: ");
      var inputWidth = Console.ReadLine();
      int width = Convert.ToInt32(inputWidth);

      Console.Write("Enter image height: ");
      var inputHeight = Console.ReadLine();
      int height = Convert.ToInt32(inputHeight);

      if (width > height)
      {
        Console.WriteLine($"Landscape: {width} x {height}");
      }
      else if (height > width)
      {
        Console.WriteLine($"Portrait: {width} x {height}");
      }
      else
      {
        Console.WriteLine($"Square: {width} x {height}");
      }
    }
  }
}