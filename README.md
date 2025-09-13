# DataStructure

This repository contains implementations and demonstrations of common data structures in C# (.NET 8).

Contents:
- linear/list - List related implementations and README
- linear/linkedlist - LinkedList related implementations

Build and run:
- dotnet build
- dotnet run

See individual folders for more details and examples.
-------------------------------------------------------------------------------------------------------------
Structure	Remove from Start	Remove from Middle	Remove from End	Notes
List<T>	❌ O(n)	❌ O(n)	✅ O(1)	Shifts elements after removal
Array (T[])	❌ O(n)	❌ O(n)	❌ O(n)	Fixed size; must copy manually
LinkedList<T>	✅ O(1)	✅ O(1) (with node)	✅ O(1)	Best for frequent insert/remove
Queue<T>	✅ O(1) (front)	❌ Not supported	❌ Not supported	FIFO only
Stack<T>	❌ Not supported	❌ Not supported	✅ O(1) (top)	LIFO only
🧠 Best for Performance
If you're removing from the end, List<T> is fast and efficient.

If you're removing from the start or middle, LinkedList<T> is better — no shifting required.

If you're using an array, any removal requires copying or shifting manually, which is slow for large data.

🔧 Example: Removing from a List
csharp
List<int> list = new List<int> {1, 2, 3, 4, 5};
list.RemoveAt(2); // Removes 3 — O(n) because elements shift
🔧 Example: Removing from a LinkedList
csharp
LinkedList<int> linked = new LinkedList<int>();
linked.AddLast(1);
linked.AddLast(2);
linked.AddLast(3);
var node = linked.Find(2);
linked.Remove(node); // O(1)
If you're working with large datasets and need frequent removals, especially from the middle or start, go with LinkedList<T>. Otherwise, List<T> is usually fine for general use.
