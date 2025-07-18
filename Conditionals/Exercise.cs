namespace csharp_otaku.Conditionals
{
  static class Exercise
  {
    /// <summary>
    /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
    /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
    /// applications where values entered into input boxes need to be validated.)
    /// </summary>
    public static void ValidateOneToTen()
    {
      Console.Write("Enter a number between 1 and 10:");

      var input = Console.ReadLine();
      int number = Convert.ToInt32(input);

      bool isValid = number >= 1 && number <= 10;
      string message = isValid ? "Valid" : "Invalid";

      Console.WriteLine(message);
    }

    /// <summary>
    /// Write a program which takes two numbers from the console and displays the maximum of the two.
    /// </summary>
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

    /// <summary>
    /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
    /// is landscape or portrait.
    /// </summary>
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

    /// <summary>
    /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
    /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
    /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
    /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
    /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
    /// the console. If the number of demerit points is above 12, the program should display License Suspended.
    /// </summary>
    public static void ValidateSpeedLimit()
    {
      Console.Write("Enter speed limit:");
      var inputSpeedLimit = Console.ReadLine();
      int speedLimit = Convert.ToInt32(inputSpeedLimit);

      Console.Write("Enter car speed:");
      var inputSpeedOfCar = Console.ReadLine();
      int speedOfCar = Convert.ToInt32(inputSpeedOfCar);

      if (speedOfCar <= speedLimit)
      {
        Console.WriteLine($"Ok! {speedOfCar} is below the limit set as {speedLimit}");
      }
      else
      {
        int limitGap = speedOfCar - speedLimit;
        int demeritPoints = limitGap / 5;

        if (demeritPoints <= 12)
        {
          Console.WriteLine($"Demerit points: {demeritPoints}⚠️");
        }
        else
        {
          Console.WriteLine("License Suspended!⛔️");
        }
      }
    }
  }
}