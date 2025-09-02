namespace csharp_otaku.ArraysLists
{
  static class Exercise
  {
    /// <summary>
    /// When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
    /// If no one likes your post, it doesn't display anything.
    /// If only one person likes your post, it displays: [Friend's Name] likes your post.
    /// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
    /// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
    /// Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
    /// </summary>
    public static void DisplayLikesFromUsers()
    {
      var names = new List<string>();

      while (true)
      {
        Console.Write("Type a name (or hit ENTER to quit): ");

        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
          break;
        names.Add(input);
      }

      if (names.Count > 2)
        Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} other{(names.Count > 3 ? "s" : "")} like your post");
      else if (names.Count == 2)
        Console.WriteLine($"{names[0]} and {names[1]} like your post");
      else if (names.Count == 1)
        Console.WriteLine($"{names[0]} likes your post");
      else
        Console.WriteLine();
    }

    /// <summary>
    /// Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
    /// </summary>
    public static void ReverseString()
    {
      Console.Write("Enter your name: ");
      var name = Console.ReadLine();

      if (!string.IsNullOrWhiteSpace(name))
      {
        var nameChars = new char[name.Length];

        for (var i = name.Length; i > 0; i--)
          nameChars[name.Length - i] = name[i - 1];

        var reversedName = new string(nameChars);

        Console.WriteLine(reversedName);

        // Optimized version of reversedName.toLower() == name.toLower()
        if (reversedName.Equals(name, StringComparison.CurrentCultureIgnoreCase))
          Console.WriteLine("Wow! Your name is a palindrome🔄");
      }
      else
      {
        Console.WriteLine("You didn't enter a name 🤲");
      }
    }

    /// <summary>
    /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
    /// Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
    /// </summary>
    public static void EnterUniqueNumbers(int limit = 5)
    {
      var numbers = new List<int>();

      while (numbers.Count < limit)
      {
        Console.Write("Enter a new number: ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("Input cannot be empty.");
        }
        else if (!int.TryParse(input, out _))
        {
          Console.WriteLine("Please enter a valid number.");
        }
        else if (numbers.Contains(Convert.ToInt32(input)))
        {
          Console.WriteLine($"You've already entered {input}! Try again.");
        }
        else
        {
          numbers.Add(Convert.ToInt32(input));
        }
      }

      numbers.Sort();

      Console.WriteLine("Sorted list of entered numbers:");
      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }
    }

    /// <summary>
    /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
    /// </summary>
    public static void DisplayUniqueFromRandomNumbers()
    {
      var numbers = new List<int>();
      var uniqueNumbers = new List<int>();

      while (true)
      {
        Console.Write("Enter a random number or type \"Quit\" to exit: ");
        var input = Console.ReadLine();

        if (input?.ToLower() == "quit")
        {
          break;
        }
        else if (string.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("Input cannot be empty.");
        }
        else if (!int.TryParse(input, out _))
        {
          Console.WriteLine("Please enter a valid number.");
        }
        else
        {
          numbers.Add(Convert.ToInt32(input));
        }
      }

      if (numbers.Count > 0)
      {
        Console.WriteLine("Filtered list of unique numbers:");

        // Optimized methods of achieving the below
        // uniqueNumbers.AddRange(numbers.Distinct());
        // uniqueNumbers.AddRange(numbers.Where(n => !uniqueNumbers.Contains(n)));

        foreach (var number in numbers)
        {
          if (!uniqueNumbers.Contains(number))
            uniqueNumbers.Add(number);
        }

        foreach (var uniqueNumber in uniqueNumbers)
          Console.WriteLine(uniqueNumber);
      }
    }

    /// <summary>
    /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
    /// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
    /// </summary>
    public static void DisplaySmallestThreeNumbers()
    {
      var numbers = new List<int>();

      while (numbers.Count != 5)
      {
        Console.Write("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10): ");
        var input = Console.ReadLine();

        var inputList = input?.Split(",");
        if (inputList?.Length == 5)
        {
          foreach (var item in inputList)
          {
            numbers.Add(Convert.ToInt32(item));
          }
        }
        else
        {
          Console.WriteLine("Invalid List");
        }
      }

      var sortedList = numbers.OrderBy(x => x).Take(3);

      foreach (var number in sortedList)
      {
        Console.WriteLine($"list item: {number}");
      }
    }
  }
}