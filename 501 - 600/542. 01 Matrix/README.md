# 542. 01 Matrix

Given an `m x n` binary matrix `mat`, return the distance of the nearest `0` for each cell.

The distance between two adjacent cells is `1`.

**Constraints**:
- `m == mat.length`
- `n == mat[i].length`
- <code>1 <= m, n <= 10<sup>4</sup></code>
- <code>1 <= m * n <= 10<sup>4</sup></code>
- `mat[i][j]` is either `0` or `1`.
- There is at least one `0` in `mat`.

### Example 1:
```
0 0 0
0 1 0
0 0 0

Input: mat = [[0,0,0],[0,1,0],[0,0,0]]
Output: [[0,0,0],[0,1,0],[0,0,0]]
```

### Example 2:
```
0 0 0
0 1 0
1 1 1

Input: mat = [[0,0,0],[0,1,0],[1,1,1]]
Output: [[0,0,0],[0,1,0],[1,2,1]]
```
