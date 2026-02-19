## Description

This repository operates on `dotnet` version `8.0.124`.
It is a collection of OOP patterns usage presented at "Network and Internet technologies masters programme 2026" at Taras Shevchenko national university of Kyiv

## Cloning
Clone the repository via HTTP by this command
```
https://github.com/nikita-solomientsev-knu/oop-patterns.git
```

## Building & Testing

After cloning, navigate to the root folder of the project and build the binaries
```
dotnet restore
dotnet build
```

For testing, run the following command:
```
dotnet test
```

## Docker

Build docker image with the following command:
```
docker build -t oop-patterns:0.1.0 .
```
