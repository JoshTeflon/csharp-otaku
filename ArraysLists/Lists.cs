namespace csharp_otaku.ArraysLists
{
  static class Lists
  {
    public static void ListMethods()
    {
      var numbers = new List<int>() { 1, 2, 3, 4 };

      // Add
      numbers.Add(1);

      // AddRange
      numbers.AddRange([6, 7]);

      Console.WriteLine("Add and AddRange Effect");
      foreach (var n in numbers)
      {
        Console.WriteLine(n);
      }

      // IndexOf
      int index = numbers.IndexOf(1);
      int lastIndex = numbers.LastIndexOf(1);

      Console.WriteLine($"Index of 1: {index}");
      Console.WriteLine($"Last Index of 1: {lastIndex}");

      // Count
      int listCount = numbers.Count;
      Console.WriteLine($"count: {listCount}");

      //Remove
      Console.WriteLine("Remove Effect");
      for (int i = 0; i < numbers.Count; i++)
      {
        if (numbers[i] == 1)
        {
          numbers.Remove(numbers[i]);
        }
      }

      foreach (var n in numbers)
      {
        Console.WriteLine(n);
      }

      // Clear
      numbers.Clear();
      Console.WriteLine($"count after clear: {numbers.Count}");
    }
  }
}