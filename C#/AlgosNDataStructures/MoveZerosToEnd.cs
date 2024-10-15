namespace Algoritm_Practice.AlgosNDataStructures
{
    public static class MoveZerosToEnd
    {
        public static int[] moveZerosToEnd(int[] arr)
        {
            //int[] nums = [0, 0, 0, -1, -2, 1, 4, 8];

            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0 && arr[j] == 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                if (arr[j] != 0)
                    j++;
            }
            return arr;
        }
    }
}
