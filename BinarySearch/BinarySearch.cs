namespace DataStructureAlgo.BinarySearch
{
    public class BinarySearch
    {
        public static int FindKeyElementInSortedArray(int[] arr, int k)
        {
            if (!arr.Any()) return 0;

            var start = 0;
            var end = arr.Length -1;

            while (start <= end)
            {
                var mid = (start + end) / 2;

                if (arr[mid] == k) return mid;

                else if (arr[mid] > k) end = mid - 1; 

                else start = mid + 1;
            }
            return start;
        }
    }
}
