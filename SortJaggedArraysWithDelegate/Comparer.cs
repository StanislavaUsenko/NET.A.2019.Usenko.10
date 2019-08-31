using System;
using System.Collections.Generic;
using System.Linq;

namespace SortJaggedArraysWithDelegate
{
    /// <summary>
    /// class IComparer for min values
    /// </summary>
    public class MinComparer : IComparer<int[]>
    {
        /// <summary>
        /// IComparer for min values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(int[] x, int[] y)
        {
            if (x == null)
            {
                throw new ArgumentNullException();
            }

            if (y == null)
            {
                throw new ArgumentNullException();
            }

            int minX = x.Min();
            int minY = y.Min();

            if (minX > minY)
            {
                return -1;
            }
            else if (minX < minY)
            {
                return 0;
            }
            else
            {
                return 1;
            }             
        }
    }

    /// <summary>
    /// class IComparer for max values
    /// </summary>
    public class MaxComparer : IComparer<int[]>
    {
        /// <summary>
        /// IComparer for max values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(int[] x, int[] y)
        {
            if (x == null)
            {
                throw new ArgumentNullException();
            }

            if (y == null)
            {
                throw new ArgumentNullException();
            }

            int maxX = x.Max();
            int maxY = y.Max();

            if (maxX > maxY)
            {
                return -1;
            }
            else if (maxX < maxY)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    /// <summary>
    /// class IComparer for max values
    /// </summary>
    public class SumComparer : IComparer<int[]>
    {
        /// <summary>
        /// IComparer for sum values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(int[] x, int[] y)
        {
            if (x == null)
            {
                throw new ArgumentNullException();
            }

            if (y == null)
            {
                throw new ArgumentNullException();
            }

            int sumX = x.Sum();
            int sumY = y.Sum();

            if (sumX > sumY)
            {
                return -1;
            }
            else if (sumX < sumY)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
