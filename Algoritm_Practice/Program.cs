
//using System.Net;
//using System.Numerics;

//List<List<int>> arr = new List<List<int>>() { new List<int> { 0, 0, 0,},
//                                                  new List<int> { 0, 0, 0 },
//                                                  new List<int> { 0, 0, 0 }};


//List<int> dynamicArray(int n, List<List<int>> queries)
//{
//    List<List<int>> arr = new List<List<int>>(n);

//    int lastAnswer = 0;


//    for (int i = 0; i < queries.Count; i++)
//    {

//    }



//    return new List<int>() { n };
//}

//List<int> rotateLeft(int d, List<int> arr)
//{

//    int n = arr.Count;

//    int x = 0;

//    int newIndex = 0;

//    for (int i = 0; i < n; i++)
//    {


//        if (i - d < 0)
//        {
//            newIndex = i - d + n;
//            (arr[x], arr[newIndex]) = (arr[newIndex], arr[x]);

//        }
//        else
//        {
//            newIndex = i - d;
//            (arr[x], arr[newIndex]) = (arr[newIndex], arr[x]);

//        }


//        if (d == n / 2 && x == n / 2)
//            break;

//        if (newIndex == x + 1)
//        {
//            int xx = x + 2;
//            if (xx > n-1)
//                break;
//            x += 2;

//        }
//        else
//            x++;




//    }

//    return arr;
//}

//List<int> ar = [41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51];
//List<int> so = [77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77];
////              0    1   2  3  4    5   6   7   8   9  10  11 12  13 14  15  16  17  18  19

//List<int> aaa = [98, 67, 35, 1, 74, 79, 7, 26, 54, 63, 24, 17, 32, 81];
//List<int> bbb = [26, 54, 63, 24, 17, 32, 81, 98, 67, 35, 1, 74, 79, 7];
//List<int> bb = [1, 2, 3, 4, 5];

//rotateLeft(4, bb);

//foreach (var item in bb)
//{
//    Console.WriteLine(item);
//}

using Algoritm_Practice.GrokkingAlgorithms;

int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];


bool a = BinarySearch.binarySearch(arr, 81);
Console.WriteLine(a);