using System;
using Xunit;

public class ArrayOperationsTests
{
    [Fact]
    public void InsertElement_ShouldThrow_WhenIndexOutOfRange()
    {
        int[] arr = { 1, 2, 3 };
        Assert.Throws<ArgumentOutOfRangeException>(() => ArrayOperations.InsertElement(arr, 10, 5));
    }

    [Fact]
    public void RemoveElement_ShouldThrow_WhenIndexOutOfRange()
    {
        int[] arr = { 1, 2, 3 };
        Assert.Throws<ArgumentOutOfRangeException>(() => ArrayOperations.RemoveElement(arr, 3));
    }

    [Fact]
    public void InsertElement_ShouldReturnNewArrayWithElementInserted()
    {
        int[] arr = { 1, 2, 3 };
        int[] result = ArrayOperations.InsertElement(arr, 10, 1);
        Assert.Equal(new int[] { 1, 10, 2, 3 }, result);
    }

    [Fact]
    public void RemoveElement_ShouldReturnNewArrayWithElementRemoved()
    {
        int[] arr = { 1, 2, 3 };
        int[] result = ArrayOperations.RemoveElement(arr, 1);
        Assert.Equal(new int[] { 1, 3 }, result);
    }

    [Fact]
    public void InsertInMiddle_ShouldInsertElementInMiddle()
    {
        int[] arr = { 1, 2, 3, 4 };
        int[] result = ArrayOperations.InsertInMiddle(arr, 99);
        Assert.Equal(new int[] { 1, 2, 99, 3, 4 }, result);
    }

    [Fact]
    public void CannotIncreaseArraySizeInPlace()
    {
        int[] arr = { 1, 2, 3 };
        int[] newArr = ArrayOperations.InsertElement(arr, 4, 1);
        // The original array should remain unchanged
        Assert.Equal(3, arr.Length);
        // The new array should have increased size
        Assert.Equal(4, newArr.Length);
    }
}
