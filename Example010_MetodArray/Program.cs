int[] array = { 1, 12, 23, 34, 43, 43, 33, 66 };

int n = array.Length;
int find = 43;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


