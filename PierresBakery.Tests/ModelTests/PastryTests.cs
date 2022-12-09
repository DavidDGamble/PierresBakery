using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryTotal_ReturnsPastryTotal_Int()
    {
      int expected = 5;
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(expected, testPastry.GetPastryTotal());
    }

    [TestMethod]
    public void GetTotalCost_ReturnsTotalCost_Int()
    {
      int expected = 0;
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(expected, testPastry.GetTotalCost());
    }

    [TestMethod]
    public void CalcTotal_CalculatesTotalCostOf1Pastry_Int()
    {
      int expected = 2;
      Pastry testPastry = new Pastry(1);
      testPastry.CalcTotal();
      Assert.AreEqual(expected, testPastry.GetTotalCost());
    }

    [TestMethod]
    public void CalcTotal_CalculatesTotalCostOf3Pastiries_Int()
    {
      int expected = 5;
      Pastry testPastry = new Pastry(3);
      testPastry.CalcTotal();
      Assert.AreEqual(expected, testPastry.GetTotalCost());
    }
  }
}