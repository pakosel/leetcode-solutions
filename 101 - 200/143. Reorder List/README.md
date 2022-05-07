# 143. Reorder List

You are given the head of a singly linked-list. The list can be represented as:

<code>
L<sub>0</sub> → L<sub>1</sub> → … → L<sub>n-1</sub> → L<sub>n</sub>
</code>

*Reorder the list to be on the following form*:

<code>
L<sub>0</sub> → L<sub>n</sub> → L<sub>1</sub> → L<sub>n-1</sub> → L<sub>2</sub> → L<sub>n-2</sub> → …
</code>

You may not modify the values in the list's nodes. Only nodes themselves may be changed.

**Constraints**:

- The number of nodes in the list is in the range <code>[1, 5 * 10<sup>4</sup>]</code>.
- `1 <= Node.val <= 1000`

### Example 1:
```
Input: head = [1,2,3,4]
Output: [1,4,2,3]
```

### Example 2:
```
Input: head = [1,2,3,4,5]
Output: [1,5,2,4,3]
```
