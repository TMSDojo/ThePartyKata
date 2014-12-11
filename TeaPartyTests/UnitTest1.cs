using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeaPartyTests
{
   [TestClass]
   public class UnitTest1
   {
      TeaPartyKata target;

      [TestInitialize]
      public void Setup()
      {
         target = new TeaPartyKata();
      }

      [TestMethod]
      public void isWoman()
      {
         var name = "Gugga";
         Assert.AreEqual(target.Welcome(name, true, false), "Hello Ms. " + name);
      }

      [TestMethod]
      public void isMan()
      {
         Assert.AreEqual(target.Welcome("Thatcher", false, false), "Hello Mr. Thatcher");
      }

      [TestMethod]
      public void KnightlyisWoman()
      {
         Assert.AreEqual(target.Welcome("Knightly", true, false), "Hello Ms. Knightly");
      }

      [TestMethod]
      public void MirrenisDame()
      {
         Assert.AreEqual(target.Welcome("Mirren", true, true), "Hello Dame Mirren");
      }

      [TestMethod]
      public void ConneryisSir()
      {
         var name = "Connery";
         Assert.AreEqual(target.Welcome(name, false, true), "Hello Sir " + name);
      }

   }
}
