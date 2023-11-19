[![Gitpod ready-to-code](https://img.shields.io/badge/Gitpod-ready--to--code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/pakosel/leetcode-solutions)
[![CircleCI](https://circleci.com/gh/pakosel/leetcode-solutions.svg?style=svg)](https://circleci.com/gh/pakosel/leetcode-solutions)

# leetcode-solutions
My solutions to the LeetCode problems. The full list of problems is available here: https://leetcode.com/problemset/all/

## Prerequisites
To run the solutions, install the .NET SDK from the [Microsoft .NET download page](https://dotnet.microsoft.com/en-us/download).
For Linux, detailed instructions are available on the [Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu)

Alternatively, you can run and develop the code using Gitpod (see below).

## Build
```
dotnet build
```

## Test
```
dotnet test
```

## Run tests for the specific problem only
```
dotnet test --filter "<problemNamespace>"
```
e.g.
```
dotnet test --filter "Atoi"
```

## Run tests with framework
```
dotnet test --framework "<selected_framework>"
```
e.g.
```
dotnet test --framework "net6.0"
```

## Develop and run in Gitpod

[![Gitpod ready-to-code](https://img.shields.io/badge/Gitpod-ready--to--code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/pakosel/leetcode-solutions)

***Gitpod*** is a web-based IDE and runtime environment, providing an easy-to-use alternative to downloading code from GitHub and setting up the development environment. Please use [this link](https://gitpod.io/#https://github.com/pakosel/leetcode-solutions) to start a new **Gitpod Workspace** with the pre-installed .NET SDK (you will need to log in with your GitHub account). Once the workspace is started, modify the code or execute unit test commands, as described above.
