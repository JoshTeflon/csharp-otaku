using csharp_otaku.Global;

namespace csharp_otaku.Conditionals
{
  public static class Switch
  {
    public static void SeasonReview(Season season)
    {
      switch (season)
      {
        case Season.Dry:
        case Season.Rainy:
          Console.WriteLine("Uhmm! Just there");
          break;

        case Season.Harmattan:
          Console.WriteLine("I love it");
          break;

        default:
          Console.WriteLine("I don't know, yet!");
          break;
      }
    }
  }
}