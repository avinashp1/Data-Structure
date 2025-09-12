using System;

public static class ArrayOperations
{
    // Example method: prints all elements of an integer array
    public static void PrintArray(int[] arr)
    {
        Console.WriteLine("Array elements:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Prints all elements of a string array
    public static void PrintArray(string[] arr)
    {
        Console.WriteLine("Array elements:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Insert an element at a specific index (returns new array)
    public static int[] InsertElement(int[] arr, int element, int index)
    {
        if (index < 0 || index > arr.Length)
            throw new ArgumentOutOfRangeException(nameof(index));
        int[] newArr = new int[arr.Length + 1];
        for (int i = 0, j = 0; i < newArr.Length; i++)
        {
            if (i == index)
                newArr[i] = element;
            else
                newArr[i] = arr[j++];
        }
        return newArr;
    }

    public static string[] InsertElement(string[] arr, string element, int index)
    {
        if (index < 0 || index > arr.Length)
            throw new ArgumentOutOfRangeException(nameof(index));
        string[] newArr = new string[arr.Length + 1];
        for (int i = 0, j = 0; i < newArr.Length; i++)
        {
            if (i == index)
                newArr[i] = element;
            else
                newArr[i] = arr[j++];
        }
        return newArr;
    }

    // Remove an element at a specific index (returns new array)
    public static int[] RemoveElement(int[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
            throw new ArgumentOutOfRangeException(nameof(index));
        int[] newArr = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i == index) continue;
            newArr[j++] = arr[i];
        }
        return newArr;
    }

    public static string[] RemoveElement(string[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
            throw new ArgumentOutOfRangeException(nameof(index));
        string[] newArr = new string[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i == index) continue;
            newArr[j++] = arr[i];
        }
        return newArr;
    }

    // Insert an element in the middle (returns new array)
    public static int[] InsertInMiddle(int[] arr, int element)
    {
        int mid = arr.Length / 2;
        return InsertElement(arr, element, mid);
    }

    public static string[] InsertInMiddle(string[] arr, string element)
    {
        int mid = arr.Length / 2;
        return InsertElement(arr, element, mid);
    }

    // Note: Arrays in C# have fixed size. All insert/remove operations return a new array.
}
