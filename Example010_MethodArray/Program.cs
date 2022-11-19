int[] array = {11, 23, 33, 44, 55, 66, 77, 88, 99};

int n = array.Length;
int find = 88;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index ++;
}