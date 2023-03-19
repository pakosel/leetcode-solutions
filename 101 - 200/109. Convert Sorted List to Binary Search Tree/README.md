# 109. Convert Sorted List to Binary Search Tree

Given the `head` of a singly linked list where elements are sorted in **ascending order**, convert it to a **height-balanced binary** search tree.

**Constraints**:
- The number of nodes in head is in the range <code>[0, 2 * 10<sup>4</sup>]</code>.
- <code>-10<sup>5</sup> <= Node.val <= 10<sup>5</sup></code>

### Example 1:
```
-10 -> -3 -> 0 -> 5 -> 9

      ||
      \/

       3
      / \
    -3   9
    /   /
  -10  5
  
Input: head = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: One possible answer is [0,-3,9,-10,null,5], which represents the shown height balanced BST.
```

### Example 2:
```
Input: head = []
Output: []
```
