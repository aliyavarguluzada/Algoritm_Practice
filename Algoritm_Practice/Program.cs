
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

int[] a = [1, 2, 3, 4, 5];

int[] aa = ResizeArray.resize(a,7);

Console.WriteLine("a");
Console.ReadLine();