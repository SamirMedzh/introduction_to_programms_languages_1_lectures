﻿// Упорядочить массив, самый певый элемент массива нужно поменять местами с минимальным 

// 1 Найти позицию минимального элемента в неотсортиров части массива
// 2 Произвести обмен этого значения со значением первой неотсортир позиции
// 3 повторять пока есть неотсортирован элементы

int[] arr = { 1, 3, 6, 2, 7, 9, 5, 6 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);


PrintArray(arr);