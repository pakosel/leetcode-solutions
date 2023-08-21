# 459. Repeated Substring Pattern

Given a string `s`, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.

**Constraints**:
- <code>1 <= s.length <= 10<sup>4</sup></code>
- `s` consists of lowercase English letters.

### Example 1:
```
Input: "abab"
Output: True
Explanation: It's the substring "ab" twice.
```

### Example 2:
```
Input: "aba"
Output: False
```

### Example 3:
```
Input: "abcabcabcabc"
Output: True
Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)
```
