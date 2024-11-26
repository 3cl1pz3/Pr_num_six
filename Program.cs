using System;
using System.Linq;

public class ArraySorter
{
    public static void SortAscending(int[] arr)
    {
        // Используем LINQ для сортировки по возрастанию
        Array.Sort(arr);
        Console.WriteLine("Отсортированный массив по возрастанию:");
        PrintArray(arr);
    }

    public static void SortDescending(int[] arr)
    {
        // Используем LINQ для сортировки по убыванию
        Array.Sort(arr, (x, y) => y.CompareTo(x));
        Console.WriteLine("Отсортированный массив по убыванию:");
        PrintArray(arr);
    }

    public static int[] ConcatenateArrays(int[] arr1, int[] arr2)
    {
        // Используем LINQ для объединения массивов
        return arr1.Concat(arr2).ToArray();
    }

    // Вспомогательный метод для вывода массива на консоль
    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }

    public static void Main(string[] args)
    {
        int[] arr1 = { 5, 2, 9, 1, 5, 6 };
        int[] arr2 = { 8, 3, 7, 4 };

        Console.WriteLine("Исходный массив:");
        PrintArray(arr1);

        SortAscending(arr1.ToArray()); // Создаем копию массива, чтобы не менять оригинал

        SortDescending(arr1.ToArray());

        int[] concatenatedArray = ConcatenateArrays(arr1, arr2);
        Console.WriteLine("Объединенный массив:");
        PrintArray(concatenatedArray);
    }
}
