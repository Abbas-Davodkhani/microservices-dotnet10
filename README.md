# Microservices with .NET 10

A learning project for building microservices step by step. The initial solution contains one service, CatalogService, with a single endpoint reporting that it is running.

## Technology stack

- .NET 10 SDK
- ASP.NET Core Web API using Minimal APIs
- C# with nullable reference types and implicit usings enabled
- No external NuGet packages

## Repository structure

```text
microservices-dotnet10/
├── src/
│   └── CatalogService/
│       ├── CatalogService.csproj
│       └── Program.cs
├── Microservices.slnx
├── README.md
├── LEARNING_PROGRESS.md
└── .gitignore
```

## Build and run

Install the .NET 10 SDK, then run these commands from the repository root:

```powershell
dotnet --version
dotnet restore Microservices.slnx
dotnet build Microservices.slnx
dotnet run --project src/CatalogService/CatalogService.csproj -- --urls http://localhost:5000
```

Open http://localhost:5000/ or verify it from another PowerShell window:

```powershell
Invoke-RestMethod http://localhost:5000/ | ConvertTo-Json
```

Expected response:

```json
{
  "service": "CatalogService",
  "status": "Running"
}
```

Press Ctrl+C to stop the service.
