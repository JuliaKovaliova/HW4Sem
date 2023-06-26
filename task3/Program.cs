//  Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray (int size)
{
    int [] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(0, 12365479564289563);
    }
    return randomArray;
}

void PrintArray (int [] arrayToPrint)
{
    Console.WriteLine("Array is: ");
    for (int i=0; i<arrayToPrint.Lenght; i++)
        Console.Write (arrayToPrint[i] + " ");
}

int size = new Random().Next(1,1254862);
int [] firstArray = CreateArray;
PrintArray(firstArray);