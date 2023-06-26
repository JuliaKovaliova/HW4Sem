//  Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray (int size)
{
    int [] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next();
    }
    return randomArray;
}

void PrintArray (int [] arrayToPrint)
{
    Console.WriteLine("Array is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write (arrayToPrint[i] + " ");
}

int size = 8;
int [] firstArray = CreateArray(size);
PrintArray(firstArray);
