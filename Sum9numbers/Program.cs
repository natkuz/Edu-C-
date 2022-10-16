int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

int a1 = 5, a2 = 12, a3 = -21, b1 = 0, b2 = 6, b3 = 10, c1 = 3, c2 = 60, c3 = 99;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));//каждый аргумент - метод 

Console.WriteLine(max);