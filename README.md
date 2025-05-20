A clean and scalable .NET solution based on **Onion Architecture** with full support for repository pattern, AutoMapper, and domain-driven design principles.

## 🏗️ Architecture Overview

The project is structured into clean layers:

- **Presentation**: API Controllers
- **Application**: DTOs, Mapping, Managers
- **Domain**: Entities, Enums, Interfaces
- **Contract**: Repository Interfaces
- **Infrastructure**
  - `InnerInfrastructure`: Manager Implementations
  - `Persistence`: EF Core Context, Migrations, Configurations

## ⚙️ Technologies Used

- ASP.NET Core 8 WebAPI
- Entity Framework Core
- AutoMapper
- Generic Repository & Manager Pattern
- Onion Architecture
- SQL Server
- Dependency Injection
- Soft Delete Mechanism
- Dependency Resolvers

