//Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int BigerDigit(int number)
{
    int digit1 = number % 10;
    int digit2 = number / 10;
    int max = digit1;
    if (digit2 > max) max = digit2;
    return max;
}

int number = new Random().Next(0, 100);
int maxDigit = BigerDigit(number);
Console.Write("Случайное число: ");
Console.WriteLine(number);
Console.Write("Наибольшая цифра числа: ");
Console.WriteLine(maxDigit);