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
          Console.WriteLine($"{season}, Uhmm! Just there");
          break;

        case Season.Harmattan:
          Console.WriteLine($"{season}, I love it");
          break;

        default:
          Console.WriteLine($"{season}, I don't know, yet!");
          break;
      }
    }
  }
}