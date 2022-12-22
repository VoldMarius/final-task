// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] arrayRandom = { "hello", "2", "world", ":-)" };
int FindLength(string[] array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        string[] oneEllementArray = new string[array[i].Length];
        for (int j = 0; j < array[i].Length; j++)
            count++;
        if (count < 4)
            length++;
    }
    return length;
}
string[] ArrayToThreeChar(string[] array, int length)
{
    string[] arrayToThreeChar = new string[length];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        string[] oneCharArray = new string[array[i].Length];
        for (int j = 0; j < array[i].Length; j++)
            count++;
        if (count < 4)
        {
            arrayToThreeChar[k] = array[i];
            k++;
        }
    }
    return arrayToThreeChar;
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]},");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
string[] arrayNormolized = ArrayToThreeChar(arrayRandom, FindLength(arrayRandom));
PrintArray(arrayRandom);
Console.Write("->");  
PrintArray(arrayNormolized);

