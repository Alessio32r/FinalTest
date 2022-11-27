// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i] + " "}");
    }
}

Console.Write("Введите желаемое количество элементов: ");
int size = int.Parse(Console.ReadLine()!);

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");         //поочерёдный ввод элементов
    string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}

string[] arrayResult = new string[size];
int length = 3;
int position = 0;
for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= length)
    {
        arrayResult[position] = arrayStrings[j];
        position++;
    }
}

Console.WriteLine();
PrintArray(arrayResult);