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

    /// <summary>
    /// Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
    /// </summary>

    public static void SumOfEnteredNumbers()
    {
      var enteredNumbers = Array.Empty<int>();

      while (true)
      {
        Console.Write("Enter a number");
        var number = Console.ReadLine();

        if (number == "ok")
        {
          var sum = enteredNumbers.Sum();
          Console.WriteLine($"The sum of the entered numbers is {sum}");

          break;
        }
        else
        {
          var tempList = enteredNumbers.ToList();
          tempList.Add(Convert.ToInt32(number));

          enteredNumbers = [.. tempList];
          continue;
        }
      }
    }

    /// <summary>
    /// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
    /// <summary>

    public static void CalculateFactorial()
    {
      var currentValue = 1;

      Console.Write("Enter a number");
      var number = Console.ReadLine();

      for (int i = Convert.ToInt32(number); i >= 1; i--)
      {
        currentValue *= i;
      }

      Console.WriteLine($"{number}! = {currentValue}");
    }
  }
}