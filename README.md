[![Gitpod ready-to-code](https://img.shields.io/badge/Gitpod-ready--to--code-blue?logo=gitpod)](https://gitpod.io/#https://github.com/pakosel/leetcode-solutions)
[![CircleCI](https://circleci.com/gh/pakosel/leetcode-solutions.svg?style=svg)](https://circleci.com/gh/pakosel/leetcode-solutions)

# leetcode-solutions
My solutions for the Leetcode problems. Full list of problems available here: https://leetcode.com/problemset/all/


## Prerequisites
In order to run the solutions, install .net SDK from [Microsoft .NET download page](https://dotnet.microsoft.com/en-us/download).
For Linux the detailed instruction is on [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-2004)

Alternatively you can run and develop the code using Gitpod (see below)

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

***Gitpod*** is web-based IDE and runtime environment which is an easy to use alternative to downloading the code from GitHub and setting up the development environment. Please use [this link](https://gitpod.io/#https://github.com/pakosel/leetcode-solutions) to start a new **Gitpod Workspace** with pre-installed .net core SDK (you will need to login with GitHub account). 
After the workspace is started modify the code or execute unit test commands, as described above.