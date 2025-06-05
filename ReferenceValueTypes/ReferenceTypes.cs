using csharp_otaku.Global;

namespace csharp_otaku.ReferenceValueTypes
{
  public static class ReferenceTypes
  {
    public static void MakeOld(Person person)
    {
      person.Age += 10;
    }
  }
}