using System;

namespace Algorithms4
{
    public class BinarySearch
    {
        // this class should not be instantiated
        private BinarySearch()
        {

        }

        /// <summary>
        /// Returns the index of the specified key in the specified array.
        /// </summary>
        /// <param name="a">the array of integers, must be sorted in ascending order</param>
        /// <param name="key">the search key</param>
        /// <returns>index of key in array a if present; -1 otherwise</returns>
        public static int indexOf(int[] a, int key)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while (lo <= hi)
            {
                // Key is in a[lo..hi] or not present.
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid]) hi = mid - 1;
                else if (key > a[mid]) lo = mid + 1;
                else return mid;
            }
            return -1;
        }

        /// <summary>
        /// Returns the index of the specified key in the specified array.
        /// This function is poorly named because it does not give the rank
        /// if the array has duplicate keys or if the key is not in the array
        /// </summary>
        /// <param name="key">the search key</param>
        /// <param name="a">the array of integers, must be sorted in ascending order</param>
        /// <returns>index of key in array a if present; -1 otherwise</returns>
        [Obsolete("This method is deprecated - use indexOf(int[], int) instead")]
        public static int rank(int key, int[] a)
        {
            return indexOf(a, key);
        }
    }
}
