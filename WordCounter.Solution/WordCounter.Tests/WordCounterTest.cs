using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_ReturnsCountForandOccuringOnce_Integer()
    {
      int expected = 1;
      RepeatCounter count = new RepeatCounter("and", "i like icecream and pizza");
      int actual = count.CountRepeats();
      Assert.AreEqual(expected,actual);
    }
	[TestMethod]
    public void CountRepeats_ReturnsCountForandOccuringMoreThanOnce_Integer()
    {
      int expected = 2;
      RepeatCounter count = new RepeatCounter("and", "i like icecream and pizza and chocolates");
      int actual = count.CountRepeats();
      Assert.AreEqual(expected,actual);
    }
	[TestMethod]
    public void CountRepeats_ReturnsCountForaOccuringMoreThanOnceInASingleWord_Integer()
    {
      int expected = 0;
      RepeatCounter count = new RepeatCounter("a", "abcdeaaabca");
      int actual = count.CountRepeats();
      Assert.AreEqual(expected,actual);
    }
	[TestMethod]
    public void CountRepeats_ReturnsCountForaOccuringMoreThanOnceInMultipleWords_Integer()
    {
      int expected = 1;
      RepeatCounter count = new RepeatCounter("a", "a abcde aaab ca");
      int actual = count.CountRepeats();
      Assert.AreEqual(expected,actual);
    }
	[TestMethod]
    public void CountRepeats_ReturnsCountForandWhenNoOccurence_Integer()
    {
      int expected = 0;
      RepeatCounter count = new RepeatCounter("and", "i like icecream,pizza,chocolates");
      int actual = count.CountRepeats();
      Assert.AreEqual(expected,actual);
    }
  }
 }