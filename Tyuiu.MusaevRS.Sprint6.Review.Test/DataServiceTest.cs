using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MusaevRS.Sprint6.Review.Lib;

namespace Tyuiu.MusaevRS.Sprint6.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int n1 = 1;
            int n2 = 10;
            int R = 3;
            int N = 5;
            int M = 5;
            int k = 0;
            int l = 3;
            int[,] valueArray = new int[5,5] { { 5, -7, 3, 2, 7 },
                                         { -8, 4, -1, 3, 0 },
                                         { 4, 7, -9, -1, 6 },
                                         { -3, -2, 5, -9, 4 },
                                         { -1, 7, -8, 9, 3 } };
            int res = ds.GetMatrix(valueArray, R, k, l);
            int wait = -15;
            Assert.AreEqual(wait, res);
        }
    }
}
