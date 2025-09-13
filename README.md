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
⚡ Performance Comparison of Common C# Structures
Structure	    Remove from Start	    Remove from Middle	    Remove from End	          Notes
List<T>	      ❌ O(n)	                  ❌ O(n)	                ✅ O(1)	            Shifts elements after removal
Array (T[])	  ❌ O(n)	                  ❌ O(n)	                ❌ O(n)	            Fixed size; must copy manually
LinkedList<T>	✅ O(1)	                  ✅ O(1) (with node)	    ✅ O(1)	            Best for frequent insert/remove
Queue<T>	    ✅ O(1) (front)	          ❌ Not supported	        ❌ Not supported	  FIFO only
Stack<T>	    ❌ Not supported	        ❌ Not supported	        ✅ O(1) (top)	    LIFO only

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
Want help choosing the right structure for a specific use case?
If you're removing just one element from a dataset in C#, the best-performing structure depends on where you're removing it from and how often you do it. Here's a quick breakdown:

🧠 If You Remove from the End
Best choice: List<T>
Performance: O(1) — no shifting, just update the count.
list.RemoveAt(list.Count - 1); // Fast and efficient

🧠 If You Remove from the Start or Middle
Best choice: LinkedList<T>
Performance: O(1) if you already have the node reference.
var node = linkedList.Find(value);
linkedList.Remove(node); // No shifting
List<T> will work too, but it's O(n) due to element shifting.

🧠 If You're Using an Array
Arrays are fixed-size, so removal means copying or shifting manually:
int[] arr = {1, 2, 3, 4};
int[] newArr = arr.Where((val, idx) => idx != 1).ToArray(); // Removes index 1
Performance: Worst among the three for dynamic removal.

🏁 Final Verdict
Scenario	Best Structure	Performance
Remove from end	List<T>	✅ O(1)
Remove from start/mid	LinkedList<T>	✅ O(1)
Fixed-size array	Manual copy needed	❌ O(n)
If you're doing this frequently, LinkedList<T> is your friend. If it's occasional and mostly at the end, stick with List<T>.
