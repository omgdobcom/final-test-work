// Написать Программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 = new string[arr1.Length];

void FindThreeChar(string[] arr, string[] arrNew)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        arrNew[count] = arr[i];
        count++;
        }
    }
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
FindThreeChar(arr1, arr2);
PrintArray(arr2);