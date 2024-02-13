//using System.Text;

//bool Check(int num)
//{
//    if (num > 100 && num < 200)
//    {

//        return true;
//    }
//    else
//    {
//        return false;
//    }

//}

//Console.WriteLine(Check(3));
//Console.WriteLine(Check(300));
//Console.WriteLine(Check(123));
//Console.WriteLine(Check(333));



//string func(string word)
//{
//   if(word.Length > 2 && word.Substring(0,2).Equals("If"))
//    {
//        return word;
//    }


//    return "if" + word;
//}


//Console.WriteLine(func("as"));
//Console.WriteLine(func("as"));
//Console.WriteLine(func("as"));
//Console.WriteLine(func("if"));


//string cut(string a, int index)
//{


//    string result =  a.Remove(index,1);
//    return result;
//}

//Console.WriteLine(cut("salam",2));



//int ReverseDigits(int number)
//{
//    int reversedNumber = 0;

//    while (number > 0)
//    {
//        int digit = number % 10;
//        reversedNumber = (reversedNumber * 10) + digit;
//        number /= 10;
//    }

//    return reversedNumber;
//}
//Console.WriteLine(ReverseDigits(526));



//int[] a = { 25, 1, 9, 75, 42, 31, 7 };

//int[] ad(int[] a)
//{

//    for (int i = 0; i < a.Length; i++)
//    {
//        for (int j = 0; j < a.Length - i - 1; j++)
//        {
//            if (a[j] > a[j + 1])
//            {
//                int temp = a[j];
//                a[j] = a[j + 1];
//                a[j + 1] = temp;
//            }
//        }
//    }
//    for (int i = 0; i < a.Length; i++)
//    {
//        Console.WriteLine(a[i]);
//    }
//    return a;
//}

//Console.WriteLine(ad(a));



//using System.Text;

//int reverse(int a)
//{

//    string b = a.ToString();

//    StringBuilder sb = new StringBuilder();
//    for (int i = b.Length - 1; i >= 0; i--)
//    {
//        sb.Append(b[i]);
//    }
//    int reversedNumber = int.Parse(sb.ToString());

//    return reversedNumber;
//}

//Console.WriteLine(reverse(526));



//int a, b, c;
//a = 4; b= 5;
//c = a;
//a = b; b = c;
//string answer = $"a: {a} b: {b}";
//Console.WriteLine(answer);


//string CreateWord(string word)
//{
//    //salam return sasasasa
//    if (word.Length < 2)
//    {
//        return word;

//    }
//    else
//    {

//        return word.Substring(0, 2) + word.Substring(0, 2) + word.Substring(0, 2);
//    }




//}

//Console.WriteLine(CreateWord("l"));



//string word(string a)
//{
//    // red dredd

//    var s = a.Substring(a.Length - 1);
//    return s + a + s;
//}

//Console.WriteLine(word("salam"));

//object[] myArray = { 678, "Freelance", 45, 67, 89, "Raymond", 23, true, "Michael", "Joseph", 545, 188, 293 };

//int StringCount()
//{
//    int Count = 0;
//    foreach (var item in myArray)
//    {
//        if (item is string)
//        {
//            Count++;
//        }
//    }
//    return Count;
//}


//foreach (var item in myArray)
//{
//    if (item is string)
//    {
//        Console.WriteLine($"{item.ToString()} {item.ToString().Count()}");
//    }
//}



//foreach (var item in myArray)
//{

//    StringBuilder hexStringBuilder = new StringBuilder();

//    if (item is string) // Check if the item is a string
//    {
//        string strItem = (string)item;
//        foreach (char c in strItem)
//        {
//            // Convert each character to its hexadecimal representation
//            hexStringBuilder.Append($"{(int)c:X}");
//        }
//    }
//    Console.WriteLine(hexStringBuilder.ToString());


//}



//string ReverseArray(object[] array)
//{
//    string[] reversed = new string[array.Length];

//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] is string)
//        {
//            char[] c = ((string)array[i]).ToCharArray();

//            Array.Reverse(c);
//            reversed[i] = new string(c);
//        }
//    }
//    return reversed.ToString();
//}

//Console.WriteLine(ReverseArray(myArray));




//Stack<string> myStack = new();
//myStack.Push("Hello");
//myStack.Push("World");
//myStack.Push("!");

//// Displays the properties and values of the Stack.
//Console.WriteLine("myStack");
//Console.WriteLine("\tCount:    {0}", myStack.Count);
//Console.Write("\tValues:");

//foreach (Object obj in myStack)
//    Console.Write("    {0}", obj);
//Console.WriteLine();


//Dictionary<int, string> s = new();
//s.Add(1, "Hello");

//int n = int.Parse(Console.ReadLine());
//List<int> fibo = new List<int> { 0, 1 };

//for (int i = 0; i < n; i++)
//{
//    int next = fibo[fibo.Count - 1] + fibo[fibo.Count - 2];
//    fibo.Add(next);
//}
//for (int i =0;i < fibo.Count;i++)
//{
//    Console.WriteLine(fibo[i]);
//}


//string a = "ali as led asd dasda";

//string[] ass = a.Split();
//foreach (string s in ass)
//{
//    Console.WriteLine(s);
//}


//int A = int.Parse(Console.ReadLine());
//int B = int.Parse(Console.ReadLine());
//int T = int.Parse(Console.ReadLine());

//int result = 0;

//for (int i = 0; i < T; i++)
//{
//    result = A + B;
//}

//Console.WriteLine(result);

//void calculate(int n)
//{
//    if (n > 0)
//    {
//        calculate(n - 1);
//        int k = n * n;
//        Console.WriteLine(k);
//    }
//}


//calculate(4);
//Console.ReadKey();





//void calculate(int n)
//{
//    if (n > 0)
//    {
//        calculate(n - 1);
//        int k = n * n;
//        Console.WriteLine(k);
//        calculate(n - 1);
//    }
//}

//calculate(4);
//Console.ReadKey();


//int linearSearch(int[] A, int key)
//{
//    int index = 0;

//    while (index < A.Length)
//    {
//        if (A[index] == key)
//            return index;
//        index++;

//    }



//    return -1;
//}


//int[] a = { 1, 2, 4, 5, 6, 7, 8, 9, 12, 342, 345, 123 };

//Console.WriteLine(linearSearch(a,5));



//int linearSearch(int[] A, int b)
//{
//    int index = 0;
//    int length = A.Length;
//    int key = b;
//    //while (index < length)
//    //{
//    //    if (A[index] == key)
//    //    {
//    //        return index;
//    //    }
//    //    index++;
//    //}
//    for(int i = 0; i < length; i++)
//    {
//        if (A[i] == key)
//        {
//            return i;
//        }
//    }


//    return -1;
//}

//Console.WriteLine(linearSearch(a,5));


//int[] a = { 1, 2, 4, 5, 6, 7, 8, 9, 12, 342, 345 };


//int binarySearch(int[] arr, int key)
//{
//    int leftIndex = 0;
//    int rightIndex = arr.Length - 1;
//    while (leftIndex <= rightIndex)
//    {
//        int middleIndex = (leftIndex + rightIndex) / 2;

//        if (key == arr[middleIndex])
//            return middleIndex;
//        else if (key < arr[middleIndex])
//            rightIndex = middleIndex - 1;
//        else if (key > arr[middleIndex])
//            leftIndex = middleIndex + 1;

//    }
//    return -1;
//}

//Console.WriteLine(binarySearch(a, 4));





//int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// linearSearch

//int linearSearch(int[] A, int key)
//{
//    for (int i = 0; i < A.Length; i++)
//    {
//        if (A[i] == key)
//            return i;
//    }
//    return -1;
//}

//Console.WriteLine(linearSearch(a, 5));






//int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//// binarySearch

//int binarySearch(int[] A, int key)
//{

//    int li = 0;
//    int ri = A.Length - 1;

//    while (li <= ri)
//    {
//        int mid = (li + ri) / 2;
//        if (A[mid] == key)
//            return mid;
//        else if (key > A[mid])
//            li = mid + 1;
//        else if(key < A[mid])
//            ri = mid - 1;
//    }



//    return -1;
//}


//Console.WriteLine(binarySearch(a, 8));

//int[] a = { 3, 2, 6, 4, 8, 5, 10, 9, 1, 7 };

//int[] bubbleSort(int[] A)
//{
//    for (int i = 0; i < A.Length; i++)
//    {

//        for (int j = i + 1; j < A.Length; j++)
//        {
//            if (A[i] > A[j])
//            {
//                int c = A[i];
//                A[i] = A[j];
//                A[j] = c;
//            }

//        }
//    }
//    int[] Sorted = A;

//    return Sorted;
//}


//int[] x = bubbleSort(a);

//for (int i = 0; i < x.Length; i++)
//{
//    Console.WriteLine(x[i]);
//}





//int[] a = { 3, 2, 6, 4, 8, 5, 10, 9, 1, 7 };
//int[] c = { 3, 2, 6, 4, 8, 5, 10, 9, 1, 7 };

//int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



//int linearSearch(int[] A, int key)
//{
//    for (int i = 0; i < A.Length; i++)
//    {
//        if (A[i] == key)
//            return i;
//    }

//    return -1;
//}


//Console.WriteLine(linearSearch(a, 5));



//int binarySearch(int[] A, int key)
//{
//    int left = 0;
//    int right = A.Length - 1;

//    while (left <= right)
//    {
//        int middle = (left + right) / 2;

//        for (int i = 0; i < A.Length; i++)
//        {
//            if (A[middle] == key)
//                return middle;
//            else if (key < A[middle])
//                right = middle - 1;
//            else if(key > A[middle])
//                left = middle + 1;
//        }
//    }
//    return -1;
//}

//Console.WriteLine(binarySearch(b, 4));








//int[] bubbleSort(int[] A)
//{
//    for (int i = 0; i < A.Length; i++)
//    {
//        for (int j = i + 1; j < A.Length; j++)
//        {
//            int temp = A[i];
//            if (A[i] > A[j])
//            {
//                A[i] = A[j];
//                A[j] = temp;
//            }
//        }

//    }
//    int[] Sorted = A;
//    return Sorted;
//}

//int[] d = bubbleSort(a);


//for (int i = 0; i < d.Length; i++)
//{
//    Console.WriteLine(d[i]);
//}






//int[] insertionSort(int[] A)
//{

//    for (int i = 1; i < A.Length; i++)
//    {
//        int temp = A[i];
//        int position = i;

//        while (position > 0 && A[position - 1] > temp)
//        {
//            A[position] = A[position - 1];
//            position--;
//        }
//        A[position] = temp;


//    }

//    int[] Sorted = A;


//    return Sorted;
//}







//int[] insertionSort(int[] A)
//{
//    for (int i = 1; i < A.Length; i++)
//    {
//        int temp = A[i];
//        int position = i;

//        while (position > 0 && A[position - 1] > temp)
//        {
//            A[position] = A[position - 1];
//            position--;
//        }
//        A[position] = temp;
//    }
//    return A;
//}



//int[] sorted = insertionSort(a);

//for (int i = 0; i < sorted.Length; i++)
//{
//    Console.WriteLine(sorted[i]);
//}




//int[] insert(int[] A)
//{
//    for (int i = 1; i < A.Length; i++)
//    {
//        int temp = A[i];

//        while (i > 0 && A[i - 1] > temp)
//        {
//            A[i] = A[i - 1];
//            i--;
//        }
//        A[i] = temp;

//    }
//    return A;
//}



//int[] sorted = insert(a);

//for (int i = 0; i < sorted.Length; i++)
//{
//    Console.WriteLine(sorted[i]);
//}





//int[] inst(int[] A)
//{
//    for (int i = 1; i < A.Length; i++)
//    {
//        int temp = A[i];

//        while (i > 0 && A[i - 1] > A[i])
//        {
//            A[i] = A[i - 1];
//            i--;
//        }
//        A[i] = temp;

//    }
//    return A;
//}




//int[] selectionSort(int[] A)
//{

//    for (int i = 0; i < A.Length; i++)
//    {
//        for (int j = i + 1; j < A.Length; j++)
//        {
//            int position = i;

//            if (A[j] < A[position])
//            {
//                position = j;
//            }
//            int temp = A[i];
//            A[i] = A[position];
//            A[position] = temp;
//        }
//    }





//    return A;
//}


//int[] select = selectionSort(a);


//for (int i = 0; i < select.Length; i++)
//{
//    Console.WriteLine(select[i]);
//}



//int[] selection(int[] A)
//{
//    for (int i = 0; i < A.Length; i++)
//    {
//        for (int j = i + 1; j < A.Length; j++)
//        {
//            int position = i;
//            if (A[j] < A[position])
//            {
//                position = j;
//            }
//            int temp = A[i];
//            A[i] = A[position];
//            A[position] = temp;
//        }
//    }


//    return A;
//}








//int[] bubble(int[] A)
//{

//    for (int i = 0; i < A.Length; i++)
//    {
//        for (int j = 0; j < A.Length; j++)
//        {
//            if (A[j] > A[i])
//            {
//                int temp = A[i];
//                A[i] = A[j];
//                A[j] = temp;
//            }
//        }
//    }
//    return A;
//}

//int[] bb = bubble(a);


//for (int i = 0; i < a.Length; i++)
//{
//    Console.WriteLine(bb[i]);
//}







//int linearSearch(int[] A, int key)
//{
//    for (int i = 0; i < A.Length; i++)
//    {
//        if (A[i] == key)
//        {
//            return i;
//        }
//    }


//    return -1;
//}


//Console.WriteLine(linearSearch(a, 8));



//int binarySearch(int[] A, int key)
//{
//    int left = 0;
//    int right = A.Length - 1;
//    int mid = (left + right) / 2;

//    while (left <= right)
//    {
//        if (A[mid] == key)
//            return mid;
//        else if (A[mid] < key)
//            right = mid - 1;
//        else if (A[mid] > key)
//            left = mid + 1;
//        mid++;
//    }


//    return -1;
//}


//Console.WriteLine(binarySearch(b,10));








//int[] bubbleSort(int[] A)
//{
//    for (int i = 0; i < A.Length; i++)
//    {
//        for (int j = 0; j < A.Length; j++)
//        {
//            if (A[i] < A[j])
//            {
//                int temp = A[i];
//                A[i] = A[j];
//                A[j] = temp;
//            }
//        }
//    }



//    return A;
//}
//int[] sorted = bubbleSort(a);

//for (int i = 0; i < sorted.Length; i++)
//{
//    Console.WriteLine(sorted[i]);
//}








//int[] insertionSort(int[] A)
//{

//    for (int i = 1; i < A.Length; i++)
//    {
//        int temp = A[i];
//        int position = i;
//        while (position > 0 && A[position - 1] > temp)
//        {
//            A[position] = A[position - 1];
//            position--;
//        }
//        A[position] = temp;
//    }
//    return A;
//}

//int[] ax = insertionSort(a);

//for (int i = 0; i < ax.Length; i++)
//{
//    Console.WriteLine(ax[i]);
//}


//int[] insert(int[] A)
//{
//    for (int i = 1; i < A.Length; i++)
//    {
//        int temp = A[i];

//        int position = i;


//        while (position > 0 && A[position - 1] > temp)
//        {
//            A[position] = A[position - 1];
//            position--;
//        }
//        A[position] = temp;
//    }

//    return A;
//}









//int[] selectionSort(int[] A)
//{

//    for (int i = 0; i < A.Length; i++)
//    {
//        int position = i;

//        for (int j = i + 1; j < A.Length; j++)
//        {
//            if (A[j] < A[position])
//            {
//                position = j;
//            }
//        }
//        int temp = A[i];
//        A[i] = A[position];
//        A[position] = temp;
//    }




//    return A;
//}






//int[] select = selectionSort(a);


//for (int i = 0; i < select.Length; i++)
//{
//    Console.WriteLine(select[i]);
//}










//int[] twoSum(int[] nums, int target)
//{

//    Dictionary<int, int> indexes = new Dictionary<int, int>();

//    for (int i = 0; i < nums.Length; i++)
//    {
//        int comp = target - nums[i];

//        if (indexes.ContainsKey(comp))
//        {
//            return new int[] { comp };
//        }
//    }




//    return new int[0];
//}


//valid parantheses





//int[] shellSort(int[] A)
//{
//    int gap = A.Length / 2;

//    while (gap > 0)
//    {
//        int i = gap;
//        while (i < A.Length)
//        {
//            int temp = A[i];
//            int j = i - gap;

//            while (j >= 0 && A[j] > temp)
//            {
//                A[j + gap] = A[j];
//                j = j - gap;
//            }
//            A[j + gap] = temp;
//            i++;
//        }
//        gap = gap / 2;
//    }


//    return A;
//}


//int[] result = shellSort(a);

//for (int i = 0; i < result.Length; i++)
//{
//    Console.WriteLine(result[i]);
//}

//using Algoritm_Practice;
//using System.Buffers;
//using System.Numerics;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography;
//using System.Text;

//int[] a = { 3, 2, 6, 4, 8, 5, 10, 9, 1, 7 };

//int[] c = { 3, 2, 6, 4, 8, 5, 10, 9, 1, 7 };

//int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


//int[] newArr = new int[20];


//for (int i = 0; i < 20; i++)
//{
//    newArr[i] = i;
//}

//for(int i = 0; i < newArr.Length; i++)
//{
//    Console.WriteLine(newArr[i]);
//}



//List<int> compareTriplets(List<int> a, List<int> b)
//{
//    List<int> score = new List<int>();
//    int bob = 0;
//    int alice = 0;
//    for (int i = 0; i < a.Count; i++)
//    {
//        if (a[i] > b[i])
//        {
//            alice++;
//        }
//        else if (a[i] < b[i])
//        {
//            bob++;
//        }

//    }
//    score.Add(alice);
//    score.Add(bob);

//    return score;

//}

//List<int> alice = [ 2, 2, 4 ];
//List<int> bob = [ 1, 1, 5 ];


//List<int> neww = compareTriplets(alice, bob);

//foreach (int item in neww)
//{
//    Console.WriteLine(item);
//}


//Matrix

//List<List<int>> matrix = new List<List<int>> {
//                 new List<int> { 11, 2, 4 },
//                 new List<int> { 4, 5, 6 },
//                 new List<int> { 10, 8, -12 }
//                };


//int diagonalDifference(List<List<int>> arr)
//{
//    int sum_1 = 0;
//    int sum_2 = 0;
//    int result = 0;
//    arr.ToArray<List<int>>();


//    for (int i = 0; i < arr.Count; i++)
//    {

//        sum_1 = arr[i][i];
//        sum_2 = arr[i][arr.Count - 1 - i];

//    }


//    result = Math.Abs(sum_1 - sum_2);

//    return result;
//}
//int res = diagonalDifference(matrix);

//Console.WriteLine(res);

//List<int> array = [1, 1, 0, -1, -1];

//void plusMinus(List<int> arr)
//{
//    int n = arr.Count;
//    int count_1 = 0;
//    int count_2 = 0;
//    int count_3 = 0;

//    decimal result_1 = 0;
//    decimal result_2 = 0;
//    decimal result_3 = 0;

//    for (int i = 0; i < arr.Count; i++)
//    {

//        if (arr[i] == 0)
//            count_1++;

//        if (arr[i] < 0)
//            count_2++;

//        if (arr[i] > 0)
//            count_3++;


//    }
//    result_1 = (decimal)count_1 / n;
//    result_2 = (decimal)count_2 / n;
//    result_3 = (decimal)count_3 / n;

//    Console.WriteLine(result_1);
//    Console.WriteLine(result_2);
//    Console.WriteLine(result_3);
//}


//plusMinus(array);




//void staircase(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        for (int j = 1; j <= n - i; j++)
//        {
//            Console.Write(" ");
//        }
//        for (int k = 1; k <= i; k++)
//        {
//            Console.Write("#");
//        }
//        Console.WriteLine();
//    }

//}

//staircase(4);



//List<int> s = [1, 3, 5, 7, 9];
//void miniMaxSum(List<int> arr)
//{
//    long result = 0;
//    long minSum = 0;
//    long maxSum = 0;

//    for (int i = 0; i < arr.Count; i++)
//    {
//        result += arr[i];

//        maxSum = result - arr.Min();
//        minSum = result - arr.Max();
//    }

//    Console.WriteLine(result);

//    Console.WriteLine($"{minSum} {maxSum}");


//}



//miniMaxSum(s);


//List<int> candles = [2, 3, 2, 4, 4];

//int birthdayCakeCandles(List<int> candles)
//{
//    int tallestCandles = 0;

//    int tallestCandle = candles.Max();

//    tallestCandles = candles.Count(c => c == tallestCandle);
//    Console.WriteLine(tallestCandle);

//    Console.WriteLine(tallestCandles);
//    return tallestCandles;
//}


//birthdayCakeCandles(candles);


//string time = "07:05:45PM";

//string timeConversion(string s)
//{


//    int hours = int.Parse(s.Substring(0, 2));
//    int minutes = int.Parse(s.Substring(3, 2));
//    int seconds = int.Parse(s.Substring(6, 2));

//    string amp = s.Substring(8, 2);

//    if (amp == "PM" && hours != 12)
//    {
//        hours += 12;
//    }
//    else if (amp == "AM" && hours == 12)
//    {
//        hours = 0;
//    }
//    string result = $"{hours:D2}:{minutes:D2}:{seconds:D2}";

//    Console.WriteLine(result);

//    return result;
//}

//timeConversion(time);




//Given an array of n integers where every number is repeated except for one, find the unique number. numbers are repeated 2 times

//int[] arr = { 1, 2, 1, 3, 2, 3, 5 };


//int unique(int[] arr)
//{

//    int unique = 0;

//    foreach (int i in arr)
//    {
//        unique ^= i; // XOR
//    }
//    Console.WriteLine(unique);
//    return unique;
//}

//unique(arr);



//List<int> arr = [73, 67, 38, 33];


//List<int> gradingStudents(List<int> grades)
//{
//    List<int> newGrades = new List<int>();


//    foreach (int grade in grades)
//    {
//        int round = (int)Math.Ceiling(grade / 5.0) * 5;

//        if (grade < 38 || round - grade >= 3)
//        {
//            newGrades.Add(grade);
//        }
//        else
//        {
//            newGrades.Add(round);
//        }

//    }


//    return newGrades;
//}



//int[,,,] matr = new int[4, 2, 2, 2];


//int[,] matrix = {   { 1,4,1 },
//                    { 2,4,1 },
//                    { 1,1,1 },
//                    { 2,4,1 },
//                    { 2,4,1 },
//                    { 2,4,1 },
//                    { 2,4,1 },};



//// Usage of ref parameter

//int a = 3;
//int b = 4;

//int Sum(ref int a, int b)
//{
//    a = 6;
//    return a + b;
//}

//Sum(ref a, b);

//Console.WriteLine(a);
//Console.WriteLine(b);

//// Usage of ref parameter


//// Usage of out parameter 

//int GetParts(double n, out double frac)
//{
//    int whole;

//    whole = (int)n;

//    frac = n - whole;

//    return whole;
//}

//int i;
//double f;

//i = GetParts(10.125, out f);

//Console.WriteLine("Integer portion is " + i);
//Console.WriteLine("Fractional part is " + f);


//// Usage of out parameter 


//// params



//int TotalMarks(params int[] list)
//{
//    int total = 0;
//    for (int i = 0; i < list.Length; i++)
//        total += list[i];
//    return total;
//}

//TotalMarks(2, 24, 2, 2);

//// params



//  linearSearch

//int[] arr = { 12, 423, 23, 12, 54, 54, 3, 2, 1, 5, 4 };


//void linearSearch(int[] arr, int num)
//{

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == num)
//        {
//            Console.WriteLine("Number found");
//            break;
//        }

//    }

//}
//linearSearch(arr, 5);

int[] sortedArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


//int binarySearch(int[] arr, int num)
//{

//    int left = 0;
//    int right = arr.Length - 1;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        int mid = (left + right) / 2;

//        if (num == arr[mid])
//        {
//            return mid;

//        }
//        else if (num > arr[mid])
//        {
//            left = mid + 1;
//        }
//        else if (num < arr[mid])
//        {
//            right = mid - 1;
//        }


//    }

//    return -1;
//}



int binary(int[] arr, int num)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = (left + right) / 2;

        if (num == arr[mid])
            return mid;
        else if (num > arr[mid])
            right = mid - 1;
        else if (num < arr[mid])
            left = mid + 1;
    }

    return -1;
}





binary(sortedArr, 2);






















































































































