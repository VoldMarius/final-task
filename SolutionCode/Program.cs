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
