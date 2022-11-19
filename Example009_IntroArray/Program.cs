// Найти максимум из 9 чисел

int Max(int a, int b, int c)
{
    int z = a;
    if(b> z) z = b;
    if(c> z) z = c;
    return z;
}


int[] array = {11, 23, 33, 44, 55, 66, 77, 88, 99};

int result = Max(Max (array[0], array[1], array[2]), Max (array[3], array[4], array[5]), Max (array[6], array[7], array[8]));
Console.WriteLine(result); 
