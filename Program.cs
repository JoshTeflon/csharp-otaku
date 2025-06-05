using HelloCsharp.Human;
using HelloCsharp.Math;

namespace HelloCsharp
{
  public enum ShippingMethod
  {
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
  }

  class Program
  {
    static void Main(string[] args)
    {
      var josh = new Person();

      josh.FirstName = "Josh";
      josh.LastName = "King";

      josh.Introduce();

      int result = Calculator.Add(100, 200);

      // Console.WriteLine(result);

      var numbers = new int[3];
      numbers[0] = 1;

      // Console.WriteLine(numbers[0]);
      // Console.WriteLine(numbers[1]);
      // Console.WriteLine(numbers[2]);

      var flags = new bool[3];
      flags[0] = true;

      // Console.WriteLine(flags[0]);
      // Console.WriteLine(flags[1]);
      // Console.WriteLine(flags[2]);

      var names = new string[3] { "Jack", "John", "Mary" };
      var formattedNames = string.Join("...", names);

      Console.WriteLine(formattedNames);

      var name = string.Format("{0} {1}", josh.FirstName, josh.LastName);

      Console.WriteLine(name);

      // verbatim strings
      var path = @"c:\projects\csharp\hello-csharp";

      Console.WriteLine(path);

      var method = ShippingMethod.Express;

      Console.WriteLine((int)method);

      // Casting with enums
      var methodId = 2;

      Console.WriteLine((ShippingMethod)methodId);

      // Parsing
      var methodName = "RegularAirMail";
      var shippingMethod = Enum.Parse<ShippingMethod>(methodName);
      
      Console.WriteLine(shippingMethod);
    }
  }
}