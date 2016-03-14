using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRM656RandomPancakeStackDiv2;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      int[][] allDeliciousnesses = new int[][] {
        new int[] { 1,1,1}
        };
      double[] allExpected = new double[] { 1.6666666666666667d };

      int length = allDeliciousnesses.Length;
      for (int i = 0; i < length; i++)
      {
        int[] deliciousness = allDeliciousnesses[i];

        Program p = new Program();

        double actual = p.expectedDeliciousness(deliciousness);

        double expected = allExpected[i];

        Assert.AreEqual(expected, actual, 1e-6);
      }
    }
  }
}
