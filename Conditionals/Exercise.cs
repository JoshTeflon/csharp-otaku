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
  }
}