using System;

int[] array = { 17, 92, 5, 33, 68, 7, 56, 40, 24, 87,
              2, 13, 61, 98, 35, 75, 11, 26, 47, 99,
              31, 82, 49, 74, 6, 19, 51, 89, 70, 44,
              16, 94, 30, 83, 1, 38, 71, 57, 41, 55,
              3, 22, 66, 72, 36, 14, 8, 69, 95, 46,
              15, 73, 21, 59, 9, 29, 85, 64, 77, 78,
              50, 28, 67, 34, 76, 62, 45, 79, 91, 10,
              60, 84, 20, 23, 4, 27, 18, 54, 25, 81,
              63, 86, 58, 80, 42, 93, 12, 48, 53, 88,
              37, 96, 52, 97, 32, 65, 90, 43, 39, 100 };

Console.WriteLine("Array non ordinato:");
PrintArray(array);

QuickSortAlgorithm(array, 0, array.Length - 1);

Console.WriteLine("\nArray ordinato:");
PrintArray(array);

static void QuickSortAlgorithm(int[] arr, int left, int right)
{
    if (left < right)
    {
        int pivotIndex = Partition(arr, left, right);
        QuickSortAlgorithm(arr, left, pivotIndex - 1);
        QuickSortAlgorithm(arr, pivotIndex + 1, right);
    }
}

static int Partition(int[] arr, int left, int right)
{
    int pivot = arr[right];
    int i = left - 1;

    for (int j = left; j < right; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            Swap(arr, i, j);
        }
    }

    Swap(arr, i + 1, right);
    return i + 1;
}

static void Swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

static void PrintArray(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}