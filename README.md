# leetcode-solutions
My solutions of the Leetcode problems. Full list of problems available here: https://leetcode.com/problemset/all/

## Build
```
dotnet build
```

## Run tests
```
dotnet test --framework <selected_framework>
```
e.g.
```
dotnet test --framework netcoreapp3.1
```

## Run tests for the specific problem only
```
dotnet test --framework <selected_framework> --filter <problemNamespace>
```
e.g.
```
dotnet test --framework "netcoreapp3.1" --filter "Atoi"
```
