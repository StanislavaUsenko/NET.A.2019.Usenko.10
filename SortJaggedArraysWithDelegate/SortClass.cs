using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortJaggedArraysWithDelegate
{
    /// <summary>
    /// Class for sorting jagged array
    /// </summary>
    public static class SortClass
    {
        /// <summary>
        /// sorting method with interface
        /// </summary>
        /// <param name="jaggedarray"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static int[][] Sort(this int[][] jaggedarray, IComparer<int[]> comparer)
        {
            if (jaggedarray == null)
            {
                throw new ArgumentNullException();
            }

            if (comparer == null)
            {
                throw new ArgumentNullException();
            }

            jaggedarray.Sort(comparer.Compare);

            return jaggedarray;
        }

        /// <summary>
        /// sorting method with delegate
        /// </summary>
        /// <param name="jaggedarray"></param>
        /// <param name="comparer"></param>
        public static void Sort(this int[][] jaggedarray, Func<int[], int[], int> comparer)
        {
            if (jaggedarray == null)
            {
                throw new ArgumentNullException();
            }

            if (comparer == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < jaggedarray.Length; i++)
            {
                for (int j = 0; j < jaggedarray.Length - 1; j++)
                {
                    int resultOfCompare = comparer.Invoke(jaggedarray[j], jaggedarray[j + 1]);

                    if (resultOfCompare.Equals(1))
                    {
                        Swap(ref jaggedarray[j], ref jaggedarray[j + 1]);
                    }
                    else if (resultOfCompare.Equals(-1))
                    {
                        Swap(ref jaggedarray[j + 1], ref jaggedarray[j]);
                    }
                }
            }
        }

        /// <summary>
        /// private method for bubble sorting
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        private static void Swap(ref int[] arr1, ref int[] arr2)
        {
            var temp = arr1;
            arr1 = arr2;
            arr2 = temp;
        }
    }
}
