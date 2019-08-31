using NUnit.Framework;
using SortJaggedArraysWithDelegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortJaggedArraysWithDelegate.Tests
{
    [TestFixture()]
    public class SortClassTests
    {
        int[][] jaggedSort = new int[][]{
            new int[] { 2, 2, 3, 4, 5 },
            new int[]{ 7, 6, 26, 134 },
            new int[]{ -1, -26, 2, -3, 4, 0 },
            new int[]{ 1, 2, 3, 4, 5, 61, 345, 132 }
            };
        IComparer<int[]> Min = new MinComparer();
        IComparer<int[]> Max = new MaxComparer();
        IComparer<int[]> Sum = new SumComparer();

        [Test()]
        public void SumSortTest()
        {
            int[][] expected = {new int []{ -1, -26, 2, -3, 4, 0 },
                new int []{  2, 2, 3, 4, 5},
                new int []{ 7, 6, 26, 134},
                new int [] { 1, 2, 3, 4, 5, 61, 345, 132} };
            Assert.AreEqual(expected, jaggedSort.Sort(Sum));
        }
        [Test()]
        public void MinSortTest()
        {
            int[][] expected = {new int []{ -1, -26, 2, -3, 4, 0 },
               new int [] { 1, 2, 3, 4, 5, 61, 345, 132},
                new int []{  2, 2, 3, 4, 5},
                new int []{ 7, 6, 26, 134} };

            Assert.AreEqual(expected, jaggedSort.Sort(Min));
        }
        [Test()]
        public void MaxSortTest()
        {

            int[][] expected = {new int []{ -1, -26, 2, -3, 4, 0},
               new int []{ 2, 2, 3, 4, 5},
               new int []{ 7, 6, 26, 134},
               new int [] { 1, 2, 3, 4, 5, 61, 345, 132}, };

            Assert.AreEqual(expected, jaggedSort.Sort(Max));
        }
    }
}