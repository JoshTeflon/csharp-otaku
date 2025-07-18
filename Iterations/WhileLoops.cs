namespace csharp_otaku.Iterations
{
  static class WhileLoops
  {
    public static void PrintEnteredName()
    {
      while (true)
      {
        Console.Write("Type your name:");
        var name = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(name))
        {
          Console.WriteLine($"Hi {name}, How is C# While loops going?");
          continue;
        }

        break;
      }
    }
  }
}