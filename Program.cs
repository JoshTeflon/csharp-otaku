using csharp_otaku.Global;
using csharp_otaku.ReferenceValueTypes;
using csharp_otaku.Conditionals;
using csharp_otaku.Iterations;
using csharp_otaku.ArraysLists;

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

      // conditionals exercise
      Conditionals.Exercise.ValidateOneToTen();
      Conditionals.Exercise.GetDualMax();
      Conditionals.Exercise.ValidateImageOreintation();
      Conditionals.Exercise.ValidateSpeedLimit();

      // iterations
      ForLoops.PrimeNumberCheck();
      ForLoops.ForForEachDifference();
      ForLoops.GenerateRandomPassword();

      WhileLoops.PrintEnteredName();

      // iterations exercise
      Iterations.Exercise.DivisbleByThree();
      Iterations.Exercise.SumOfEnteredNumbers();
      Iterations.Exercise.CalculateFactorial();
      Iterations.Exercise.GuessingGame();
      Iterations.Exercise.FindMaxNumberInList();

      // arrays and lists
      ArraysLists.Arrays.ArrayMethods();
      ArraysLists.Lists.ListMethods();

      // arrays and lists exercise
      ArraysLists.Exercise.DisplayLikesFromUsers();
      ArraysLists.Exercise.ReverseString();
      ArraysLists.Exercise.EnterUniqueNumbers();
      ArraysLists.Exercise.DisplayUniqueFromRandomNumbers();
    }
  }
}