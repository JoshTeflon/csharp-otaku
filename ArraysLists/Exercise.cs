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
        Console.Write("Enter a name (or press ENTER to finish): ");
        var input = Console.ReadLine();

        if (input?.Length > 0)
        {
          names.Add(input);
        }
        else
        {
          int nameCount = names.Count;

          switch (nameCount)
          {
            case 0:
              break;
            case 1:
              Console.WriteLine($"{names[0]} likes your post");
              break;
            case 2:
              Console.WriteLine($"{names[0]} and {names[1]} like your post");
              break;
            default:
              Console.WriteLine($"{names[0]}, {names[1]} and {nameCount - 2} other{(nameCount > 3 ? "s" : "")} like your post");
              break;
          }

          break;
        }
      }
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
        char[] nameChars = name.ToCharArray();

        Array.Reverse(nameChars);
        Console.WriteLine(nameChars);

        if (new string(nameChars) == name)
        {
          Console.WriteLine("Wow! Your name is a palindrome🔄");
        }
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

        if (input == "Quit")
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

        uniqueNumbers.AddRange(numbers.Distinct());

        foreach (var uniqueNumber in uniqueNumbers)
        {
          Console.WriteLine(uniqueNumber);
        }
      }
    }
  }
}