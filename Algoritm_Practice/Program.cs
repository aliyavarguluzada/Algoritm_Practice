
//bool IsPrime(int number)
//{
//    // If the number is less than 2, it's not prime
//    if (number < 2)
//        return false;

//    // Check divisibility from 2 to the square root of the number
//    for (int i = 2; i <= Math.Sqrt(number); i++)
//    {
//        if (number % i == 0)
//            return false; // Number is divisible, not prime
//    }

//    return true; // If no divisor found, number is prime
//}

//Console.WriteLine(IsPrime(11));
using Algoritm_Practice.AlgosNDataStructures;
using Algoritm_Practice.EOlymp;
using Algoritm_Practice.Leetcode;

bool IsPrime(int number)
{
    // If the number is less than 2, it's not prime
    if (number < 2)
        return false;

    // Check divisibility from 2 to the square root of the number
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false; // Number is divisible, not prime
    }

    return true; // If no divisor found, number is prime
}

//Console.WriteLine(IsPrime(11));



int[] aa2 = [13, 34, 2, 34, 33, 1];
int[] a2 = [13, 34, 2, 0, 33, -1,-2];

int max(int[] arr)
{
    int max = Int32.MinValue;
    int secondMax = Int32.MinValue;

    for (int i = 0; i < arr.Length - 1; i++)
    {

        if (max < arr[i])
        {
            secondMax = max;
            max = arr[i];
        }
        else if (arr[i] > secondMax && arr[i] != max)
        {
            secondMax = arr[i];
        }
    }
    return secondMax;
}

int aa = max(aa2);

int a =FindMin.min(a2);
int b =FindMax.max(a2);
Console.WriteLine(b);


