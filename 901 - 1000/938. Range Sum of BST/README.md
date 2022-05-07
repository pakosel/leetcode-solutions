# 938. Range Sum of BST

Given the root node of a binary search tree, return *the sum of values of all nodes with a value in the range `[low, high]`*.

**Constraints**:
- The number of nodes in the tree is in the range <code>[1, 2 * 10<sup>4</sup>]</code>.
- <code>1 <= Node.val <= 10<sup>5</sup></code>
- <code>1 <= low <= high <= 10<sup>5</sup></code>
- All `Node.val` are **unique**.

### Example 1:
```
    10
   /  \
  5    15
 / \    \
3   7    18

Input: root = [10,5,15,3,7,null,18], low = 7, high = 15
Output: 32
```

### Example 2:
```
       10
      /  \
     5    15
    / \   / \
   3   7 13 18
  /   / 
 1   6

Input: root = [10,5,15,3,7,13,18,1,null,6], low = 6, high = 10
Output: 23
```
