//Заполняет массив
void FillArrey(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 20);
        index++;
    }
}
//Печатает массив
void PrintArrey(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
// Находит индекс элемента в массиве
int IndexOF(int[] collection, int find)
{
    int Length = collection.Length;
    int index = 0;
    int position = -1;
    while (index < Length)
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
//Определяет из скольки элементов создать массив
int[] arrey = new int[10];
FillArrey(arrey);
PrintArrey(arrey);
Console.WriteLine();
int pos = IndexOF(arrey, 5);
Console.WriteLine(pos);