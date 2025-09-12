![Diagram](diagram.png)

```
+---+---+---+---+---+
| 1 | 2 | 3 | 4 | 5 |
+---+---+---+---+---+
 0   1   2   3   4
```

Definition of array:
An array is a collection of items stored at contiguous memory locations. The idea is to store multiple items of the same type together.

Advantages:
- Fast access by index (O(1)).
- Simple and memory-efficient for fixed-size collections.
- Good locality of reference which improves cache performance.

Disadvantages:
- Fixed size (cannot grow/shrink in place).
- Inserting or removing elements (except at the end) requires shifting elements (O(n)).
- Wastes memory if sized too large or requires reallocation if growth needed.
