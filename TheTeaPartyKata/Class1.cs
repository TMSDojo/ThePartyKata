using System;
using System.Diagnostics.Eventing.Reader;
using System.Net.Configuration;
using System.Runtime.Remoting.Messaging;

public class TeaPartyKata : ITeaPartyKata
{
   public string Welcome(string lastName, bool isWoman, bool isKnighted)
   {
      return lastName.IsKnight(isKnighted).Greeting(isWoman, lastName);
   }
}

public static class extStr
{
   private static string NobleTitle(bool isWoman)
   {
      return (isWoman ? "Dame " : "Sir ");
   }

   private static string StandardTitle(bool isWoman)
   {
      return (isWoman ? "Ms. " : "Mr. ");
   }

   public static bool IsKnight(this string s, bool isKnighted)
   {
      return isKnighted;
   }

   public static string Greeting(this bool isKnight, bool isWoman, string sName)
   {
     return "Hello " + (isKnight ? NobleTitle(isWoman) : StandardTitle(isWoman)) + sName;
   }
}

public interface ITeaPartyKata
{
   /// <summary>
   /// Welcome a guest
   /// </summary>
   /// <param name="lastName">the last name of the guest</param>
   /// <param name="isWoman"><c>true</c> if the guest is female</param>
   /// <param name="isSir"><c>true</c> if the guest was knighted by the queen</param>
   /// <returns>issues welcome text to the guest</returns>
   string Welcome(string lastName, bool isWoman, bool isSir);
}