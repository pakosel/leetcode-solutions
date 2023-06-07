# 1232. Check If It Is a Straight Line

You are given an array `coordinates`, `coordinates[i] = [x, y]`, where `[x, y]` represents the coordinate of a point. Check if these points make a straight line in the XY plane.

**Constraints**:
- `2 <= coordinates.length <= 1000`
- `coordinates[i].length == 2`
- <code>-10<sup>4</sup> <= coordinates[i][0], coordinates[i][1] <= 10<sup>4</sup></code>
- `coordinates` contains no duplicate point.

### Example 1:
```
Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
Output: true
```

### Example 2:
```
Input: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
Output: false
```

[more info](https://leetcode.com/problems/check-if-it-is-a-straight-line/)