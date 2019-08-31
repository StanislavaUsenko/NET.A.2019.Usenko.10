using System;
using System.Collections.Generic;

namespace SortJaggedArraysWithDelegate
{
    /// <summary>
    /// Adapter for IComparer -> delegate
    /// </summary>
    internal class ComparerAdapter : IComparer<int[]>
    {
        /// <summary>
        /// private delegate
        /// </summary>
        private Func<int[], int[], int> comparer;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="comparer"></param>
        public ComparerAdapter(Func<int[], int[], int> comparer)
        {
            this.comparer = comparer;
        }

        /// <summary>
        /// relised method of IComparer interface
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

            return this.comparer.Invoke(x, y);
        }
    }
}
