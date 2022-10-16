void FillArray(int[] collection)
{
    int length = collection.Length;//получить длину массива и записать в переменную
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);//заполнить массив collection случаными числами от 1 до 9
        index++;//аналогично записи index = index + 1
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//если не будет find в массиве, то выведется -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position; 
}

int[] array = new int[10];//создаем массив из 10 целочисленных элементов. По умолчанию заполняется нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);