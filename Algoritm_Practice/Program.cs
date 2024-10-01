using Algoritm_Practice.Leetcode;

int[] arr = [1, 1, 1, 2, 2, 2, 3, 3, 3, 3];

int[] a = TopKFrequentElements.TopKFrequent(arr,2);


foreach (var item in a)
{
    Console.WriteLine(item);
}