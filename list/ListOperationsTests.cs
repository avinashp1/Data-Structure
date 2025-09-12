using System;
using System.Collections.Generic;
using Xunit;

public class ListOperationsTests
{
    [Fact]
    public void InsertElement_ShouldInsertAtCorrectIndex()
    {
        var list = new List<int> { 1, 2, 3 };
        ListOperations.InsertElement(list, 10, 1);
        Assert.Equal(new List<int> { 1, 10, 2, 3 }, list);
    }

    [Fact]
    public void RemoveElement_ShouldRemoveAtCorrectIndex()
    {
        var list = new List<int> { 1, 2, 3 };
        ListOperations.RemoveElement(list, 1);
        Assert.Equal(new List<int> { 1, 3 }, list);
    }

    [Fact]
    public void InsertInMiddle_ShouldInsertElementInMiddle()
    {
        var list = new List<int> { 1, 2, 3, 4 };
        ListOperations.InsertInMiddle(list, 99);
        Assert.Equal(new List<int> { 1, 2, 99, 3, 4 }, list);
    }

    [Fact]
    public void PrintList_ShouldOutputElements()
    {
        var list = new List<string> { "a", "b", "c" };
        // Just ensure no exception is thrown
        ListOperations.PrintList(list);
    }
}
