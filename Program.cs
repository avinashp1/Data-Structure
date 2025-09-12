using System;

// Replaced top-level statements with an explicit Main method
internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Example usage of ArrayOperations
        int[] arr = { 1, 2, 3, 4, 5 };
        ArrayOperations.PrintArray(arr);
        // Insert element
        arr = ArrayOperations.InsertElement(arr, 99, 2);
        ArrayOperations.PrintArray(arr);
        // Remove element
        arr = ArrayOperations.RemoveElement(arr, 3);
        ArrayOperations.PrintArray(arr);
        // Insert in middle
        arr = ArrayOperations.InsertInMiddle(arr, 77);
        ArrayOperations.PrintArray(arr);

        string[] strArr = { "a", "b", "c", "d" };
        ArrayOperations.PrintArray(strArr);
        strArr = ArrayOperations.InsertElement(strArr, "z", 1);
        ArrayOperations.PrintArray(strArr);
        strArr = ArrayOperations.RemoveElement(strArr, 2);
        ArrayOperations.PrintArray(strArr);
        strArr = ArrayOperations.InsertInMiddle(strArr, "y");
        ArrayOperations.PrintArray(strArr);
    }
}
