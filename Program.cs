using csharp_otaku.Global;
using csharp_otaku.ReferenceValueTypes;
using csharp_otaku.Conditionals;

namespace csharp_otaku
{
  static class Program
  {
    static void Main(string[] args)
    {
      // value types
      var number = 1;
      ValueTypes.Increment(number);
      Console.WriteLine(number);

      // reference types
      var person = new Person { Age = 20 };
      ReferenceTypes.MakeOld(person);
      Console.WriteLine(person.Age);

      // conditionals
      var hour = 12;
      IfElse.Greeting(hour);

      var isPremiumMember = true;
      IfElse.SubscriptionPrice(isPremiumMember);

      var season = Season.Harmattan;
      Switch.SeasonReview(season);
    }
  }
}