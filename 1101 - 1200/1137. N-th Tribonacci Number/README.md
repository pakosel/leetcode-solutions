# 1137. N-th Tribonacci Number

The Tribonacci sequence <code>T<sub>n</sub></code> is defined as follows: 

<code>T<sub>0</sub> = 0, T<sub>1</sub> = 1, T<sub>2</sub> = 1, T<sub>n+3</sub> = T<sub>n</sub> + T<sub>n+1</sub> + T<sub>n+2</sub> for n >= 0</code>

Given `n`, return the value of <code>T<sub>n</sub></code>.

**Constraints**:
- `0 <= n <= 37`
- The answer is guaranteed to fit within a 32-bit integer, ie. <code>answer <= 2<sup>31</sup> - 1</code>.

### Example 1:
```
Input: n = 4
Output: 4
Explanation:
T_3 = 0 + 1 + 1 = 2
T_4 = 1 + 1 + 2 = 4
```

### Example 2:
```
Input: n = 25
Output: 1389537
```
