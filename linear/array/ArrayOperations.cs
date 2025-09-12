using System;

public static class ArrayOperations
{
    // Generic print for any array type
    public static void PrintArray<T>(T[] arr)
    {
        if (arr == null) throw new ArgumentNullException(nameof(arr));
        Console.WriteLine("Array elements:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Generic insert using Array.Copy for performance
    public static T[] InsertElement<T>(T[] arr, T element, int index)
    {
        if (arr == null) throw new ArgumentNullException(nameof(arr));
        if (index < 0 || index > arr.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        var newArr = new T[arr.Length + 1];
        if (index > 0)
            Array.Copy(arr, 0, newArr, 0, index);
        newArr[index] = element;
        if (index < arr.Length)
            Array.Copy(arr, index, newArr, index + 1, arr.Length - index);
        return newArr;
    }

    // Generic remove at index
    public static T[] RemoveElement<T>(T[] arr, int index)
    {
        if (arr == null) throw new ArgumentNullException(nameof(arr));
        if (index < 0 || index >= arr.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        var newArr = new T[arr.Length - 1];
        if (index > 0)
            Array.Copy(arr, 0, newArr, 0, index);
        if (index < arr.Length - 1)
            Array.Copy(arr, index + 1, newArr, index, arr.Length - index - 1);
        return newArr;
    }

    // Insert element in the middle
    public static T[] InsertInMiddle<T>(T[] arr, T element)
    {
        if (arr == null) throw new ArgumentNullException(nameof(arr));
        int mid = arr.Length / 2;
        return InsertElement(arr, element, mid);
    }

    // Note: Arrays in C# are fixed-size; these methods return new arrays when modifying size.
}
