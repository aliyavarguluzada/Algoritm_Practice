namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class FindTheMissingNumber
    {
        public static int Find(int[] arr)
        {

            // Sum of first natural numbers S = n(n + 1)/2

            int n = arr.Length;

            int sum = n * (n + 1) / 2;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum = sum - arr[i];
            //}
            foreach (int num in arr)
            {
                sum = sum - num;
            }
            return sum;
        }
        public static int Missing(int[] arr)
        {
            Array.Sort(arr);
            int missing = arr[0];

            for (global::System.Int32 i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1] - 1)
                    continue;
                else
                {
                    missing = arr[i] + 1;
                }
            }
            return missing;

        }
    }
}
