namespace csharp_otaku.Iterations
{
  static class Exercise
  {
    /// <summary>
    /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
    /// </summary>

    public static void DivisbleByThree()
    {
      var divisibleNumbers = Array.Empty<int>();

      for (int i = 1; i <= 100; i++)
      {
        if (i % 3 == 0)
        {
          var tempList = divisibleNumbers.ToList();
          tempList.Add(i);
          divisibleNumbers = [.. tempList];
        }
      }

      Console.WriteLine($"There {(divisibleNumbers.Length > 1 ? "are" : "is")} {divisibleNumbers.Length} number{(divisibleNumbers.Length > 1 ? "s" : "")} divisible by 3 from 1 - 100");
    }
  }
}