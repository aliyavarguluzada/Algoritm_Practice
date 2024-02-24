using System.Collections.Generic;

int[] a = [1, 2, 3, 4, 5, 6, 7, 8, 9];


int[] Reverse(int[] array)
{

    int start = 0;
    int end = array.Length - 1;
    while (start < end)
    {
        int temp = array[start];
        array[start] = array[end];
        array[end] = temp;

        start++;
        end--;
    }

    return array;
}

int[] aa = Reverse(a);

foreach (int i in aa)
{
    Console.WriteLine(i);
}