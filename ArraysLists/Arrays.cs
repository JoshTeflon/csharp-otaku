namespace csharp_otaku.ArraysLists
{
  static class Arrays
  {
    public static void ArrayMethods()
    {
      int[] numbers = [5, 90, 25, 30, 75];

      // Length
      Console.WriteLine($"Length of array is: {numbers.Length}");

      // Get IndexOf
      var index = Array.IndexOf(numbers, 20);
      Console.WriteLine($"Index of 20 is: {index}");

      // Clear
      Array.Clear(numbers, 0, 3);

      Console.WriteLine("Effect of Clear()");
      foreach (int n in numbers)
      {
        Console.WriteLine(n);
      }

      // Copy
      int[] another = new int[4];
      Array.Copy(numbers, another, 4);

      Console.WriteLine("Effect of Copy()");
      foreach (int n in another)
      {
        Console.WriteLine(n);
      }

      // Sort
      Array.Sort(numbers);

      Console.WriteLine($"Effect of Sort()");
      foreach (int n in numbers)
      {
        Console.WriteLine(n);
      }

      // Reverse
      Array.Reverse(numbers);

      Console.WriteLine($"Effect of Reverse()");
      foreach (int n in numbers)
      {
        Console.WriteLine(n);
      }
    }
  }
}