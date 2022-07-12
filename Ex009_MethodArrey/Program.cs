int[] arrey = {22, 48, 12, 52, 67, 12, 69, 23, 78};
int n = arrey.Length;
int find = 12;
int index = 0;

while (index < n)
{
    if (arrey[index] == find )
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}