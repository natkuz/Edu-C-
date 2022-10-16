int[] array={5, 12, -21, 365, 6, 10, 3, 60, 10};

int n = array.Length;
int find = 10;
int i = 0;

while (i < n)
{
    if (array[i] == find) 
    {
        Console.WriteLine(i);
        break;
    }
    i = i + 1;
}

