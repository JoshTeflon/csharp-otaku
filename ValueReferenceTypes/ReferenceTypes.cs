using csharp_otaku.Global;

namespace csharp_otaku.ValueReferenceTypes
{
  public static class ReferenceTypes
  {
    public static void Increment(int number)
    {
      number += 10;
    }

    public static void MakeOld(Person person)
    {
      person.Age += 10;
    }
  }
}