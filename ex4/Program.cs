//ex4
void FillArray(int[] collection) //метод, кот ничего не возвращает
{
    int length = collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[]col)
{
    int count = col.Length;
    int position = -1;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    
}

int IndexOf(int[]collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position=0;
    while (index<count)
    {
        if (collection[index]==find)
        {
           position=index;
           break;
        }
        index++;
    }
    return position;//при эвойд для вывода
}
int[]array=new int[10]; //create new array with new elements, there only zeroes

FillArray(array); //заполняет массив
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array,4);
Console.WriteLine(pos);