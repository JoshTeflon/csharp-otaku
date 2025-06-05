using csharp_otaku.Global;
using csharp_otaku.ValueReferenceTypes;

namespace csharp_otaku
{
  static class Program
  {
    static void Main(string[] args)
    {
      // Reference types
      var number = 1;
      ReferenceTypes.Increment(number);
      Console.WriteLine(number);

      var person = new Person { Age = 20 };
      ReferenceTypes.MakeOld(person);
      Console.WriteLine(person.Age);
    }
  }
}