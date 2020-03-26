# managment-app

## Technologies
* .NET Core 3
* ASP .NET Core 3
* Entity Framework Core 3
* React

## Getting Started

1. Install the latest [.NET Core SDK](https://dotnet.microsoft.com/download)
2. Run `dotnet new --install Clean.Architecture.Solution.Template` to install the project template
3. Run `dotnet new ca-sln` to create a new project
4. Navigate to `src/WebUI` and run `dotnet run` to launch the project

## Overview

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.


### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.


### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

### WebUI

This layer is a single page application based on React and ASP.NET Core 3. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only *Startup.cs* should reference Infrastructure.

