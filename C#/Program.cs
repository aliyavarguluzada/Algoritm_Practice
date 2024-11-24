
using C_.Leetcode;

int[][] arr = [[ 1, 2, 3, 4 ],
                [ 5, 1, 2, 3 ],
                [ 9, 5, 1, 2]];

int[][] aee = [[1,2],
               [2,2]];


bool a = ToeplitzMatrix.IsToeplitzMatrix(arr);
bool b = ToeplitzMatrix.IsToeplitzMatrix(aee);

Console.WriteLine(b);


