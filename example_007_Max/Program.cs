﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int [] array = { 15, 82, 53, 44, 59, 61, 77, 28, 90 };


int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[7], array[6], array[8])
);
Console.WriteLine(result);