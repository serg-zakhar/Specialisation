// Программа из имеющегося массива строк формирует массив,
// длина элементов которого меньше или равна 3

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество символов, меньше или равно которому нужно вывести: ");
int numChars = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} строку: ");
    array[i] = Console.ReadLine();
}

int GetArrayCharNum(int numChars, string[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numChars)
        {
            result++;
        }
    }
    return result;
}


string[] GetArrayCharLimit(int size, int numChars, string[] array)
{
    string[] result = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numChars)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("}");
}

string[] newArray = GetArrayCharLimit(GetArrayCharNum(numChars, array), numChars, array);
PrintArray(newArray);