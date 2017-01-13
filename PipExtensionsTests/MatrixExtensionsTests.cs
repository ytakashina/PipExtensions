﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipExtensions.Tests
{
    [TestClass()]
    public class MatrixExtensionsTests
    {
        [TestMethod()]
        public void SwapRawsTest()
        {
            var matrix = new[,] {{1, 0, 1}, {1, 0, 0}, {0, 1, 0}};
            var ret = matrix.SwapRaws(1, 2);
            var ans = new[,] {{1, 0, 1}, {0, 1, 0}, {1, 0, 0}};
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Assert.AreEqual(ret[i, j], ans[i, j]);
                }
            }
        }

        [TestMethod()]
        public void SwapColsTest()
        {
            var matrix = new[,] {{1, 0, 1}, {1, 0, 0}, {0, 1, 0}};
            var ret = matrix.SwapCols(0, 1);
            var ans = new[,] {{0, 1, 1}, {0, 1, 0}, {1, 0, 0}};
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Assert.AreEqual(ret[i, j], ans[i, j]);
                }
            }
        }

        [TestMethod()]
        public void OrderRawsTest()
        {
            var matrix = new[,] {{1, 0, 1}, {1, 0, 0}, {0, 1, 0}};
            var ret = matrix.OrderRaws(new[] {0, 2, 1});
            var ans = new[,] {{1, 0, 1}, {0, 1, 0}, {1, 0, 0}};
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Assert.AreEqual(ret[i, j], ans[i, j]);
                }
            }
        }

        [TestMethod()]
        public void OrderColsTest()
        {
            var matrix = new[,] {{1, 0, 1}, {1, 0, 0}, {0, 1, 0}};
            var ret = matrix.OrderCols(new[] {1, 0, 2});
            var ans = new[,] {{0, 1, 1}, {0, 1, 0}, {1, 0, 0}};
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Assert.AreEqual(ret[i, j], ans[i, j]);
                }
            }
        }

        [TestMethod()]
        public void MulTest()
        {
            var a = new double[,] {{1, 2}, {3, 4}};
            var b = new double[,] {{0, 1}, {2, 3}};
            var c = new double[,] {{4, 7}, {8, 15}};
            var d = a.Mul(b);
            for (var i = 0; i < 4; i++)
            {
                Assert.AreEqual(c[i/2, i%2], d[i/2, i%2]);
            }
        }
    }
}