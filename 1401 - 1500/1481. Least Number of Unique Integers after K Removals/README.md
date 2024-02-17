# 1481. Least Number of Unique Integers after K Removals

Given an array of integers `arr` and an integer `k`. Find the least number of unique integers after removing **exactly** `k` elements.

**Constraints**:
- <code>1 <= arr.length <= 10<sup>5</sup></code>
- <code>1 <= arr[i] <= 10<sup>9</sup></code>
- `0 <= k <= arr.length`

### Example 1:
```
Input: arr = [5,5,4], k = 1
Output: 1
Explanation: Remove the single 4, only 5 is left.
```

### Example 2:
```
Input: arr = [4,3,1,1,3,3,2], k = 3
Output: 2
Explanation: Remove 4, 2 and either one of the two 1s or three 3s. 1 and 3 will be left.
```
