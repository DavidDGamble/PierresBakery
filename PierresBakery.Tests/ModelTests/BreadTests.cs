using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadTotal_ReturnsBreadTotal_Int()
    {
      int expected = 5;
      Bread testBread = new Bread(5);
      Assert.AreEqual(expected, testBread.GetBreadTotal());
    }

    [TestMethod]
    public void GetTotalCost_ReturnsTotalCost_Int()
    {
      int expected = 0;
      Bread testBread = new Bread(5);
      Assert.AreEqual(expected, testBread.GetTotalCost());
    }
  }
}