namespace csharp_otaku.Conditionals
{
  static class IfElse
  {
    public static void Greeting(int hour)
    {
      string prefix = "Hey man!";

      if (hour > 0 && hour < 12)
      {
        Console.WriteLine($"{prefix} It's morning");
      }
      else if (hour >= 12 && hour < 18)
      {
        Console.WriteLine($"{prefix} It's afternoon");
      }
      else
      {
        Console.WriteLine($"{prefix} It's evening");
      }
    }

    public static float SubscriptionPrice(Boolean isPremium)
    {
      float defaultPrice = 9.99f;
      float premiumPrice = 19.99f;

      float price = isPremium ? premiumPrice : defaultPrice;

      Console.WriteLine($"The price is ${price}");
      return price;
    }
  }
}