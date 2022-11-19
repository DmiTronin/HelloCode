// Найти максимум из 9 чисел
int Max(int a, int b, int c)
{
    int z = a;
    if(b> z) z = b;
    if(c> z) z = c;
    return z;
}

int a1 = 13;
int b1 = 87;
int c1 = 982;
int a2 = 213;
int b2 = 187;
int c2 = 398;
int a3 = 513;
int b3 = 187;
int c3 = 298;

int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);

int max = Max(max1, max2, max3);
Console.WriteLine(max);