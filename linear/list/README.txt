![Diagram](diagram.png)

```
+---+---+---+---+
| a | b | c | d |
+---+---+---+---+
 0   1   2   3
```

Definition of List:
A List in C# is a generic collection that can dynamically grow or shrink. It is part of the System.Collections.Generic namespace and provides methods for adding, removing, and accessing elements by index.

Advantages:
- Dynamic size (can grow and shrink as needed).
- Provides many useful methods for manipulation.
- Fast access by index (O(1)).
- Type-safe (generic).

Disadvantages:
- Insertions/removals (except at the end) require shifting elements (O(n)).
- Slightly more memory overhead compared to arrays.
- Not thread-safe by default.

**Real-life examples:**
- Managing a shopping cart in an e-commerce application.
- Keeping a dynamic list of search results.
- Storing undo/redo history in a text editor
