int AmountOfElements()
{
    Console.Write("Сколько элементов Вы хотите ввести? ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

string[] FillArray(int size)
{
    string[] arrayStrings = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine());
        arrayStrings[i] = element;
    }
    return arrayStrings;
}

string[] FinalArray(string[] arrayStrings, int length, int size)
{
    string[] finalArray = new string[size];
    int position = 0;

    for (int i = 0; i < size; i++)
    {
        if (arrayStrings[i].Length <= length)
        {
            finalArray[position] = arrayStrings[i];
            position++;
        }
    }
    return finalArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int size = AmountOfElements();
string[] arrayStrings = FillArray(size);
string[] finalArray = FinalArray(arrayStrings, 3, size);
Console.WriteLine();
PrintArray(finalArray);


