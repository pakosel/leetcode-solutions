# 1584. Min Cost to Connect All Points

You are given an array `points` representing integer coordinates of some points on a 2D-plane, where <code>points[i] = [x<sub>i</sub>, y<sub>i</sub>]</code>.

The cost of connecting two points <code>[x<sub>i</sub>, y<sub>i</sub>]</code> and <code>[x<sub>j</sub>, y<sub>j</sub>]</code> is the manhattan distance between them: <code>|x<sub>i</sub> - x<sub>j</sub>| + |y<sub>i</sub> - y<sub>j</sub>|</code>, where `|val|` denotes the absolute value of `val`.

Return the minimum cost to make all points connected. All points are connected if there is **exactly one** simple path between any two points.

**Constraints**:
- `1 <= points.length <= 1000`
- <code>-10<sup>6</sup> <= xi, yi <= 10<sup>6</sup></code>
- All pairs <code>(x<sub>i</sub>, y<sub>j</sub>)</code> are distinct.

### Example 1:
```
Input: points = [[0,0],[2,2],[3,10],[5,2],[7,0]]
Output: 20
Explanation: 
```

### Example 2:
```
Input: points = [[3,12],[-2,5],[-4,1]]
Output: 18
```
