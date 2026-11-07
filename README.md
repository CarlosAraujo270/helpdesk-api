# helpdesk-api

Help desk ticketing REST API built with ASP.NET Core, EF Core and PostgreSQL

# HelpDesk API

A REST API for managing IT support tickets, built with ASP.NET Core. Users report problems as tickets, and technicians pick them up, comment on them and resolve them.

> **Status:** MVP in progress. Only the project setup and a health-check endpoint are done so far. See the [Roadmap](#roadmap) below.

## Tech stack

- C#
- .NET 10 and ASP.NET Core Web API (controllers)
- Git and GitHub

Planned: Entity Framework Core, PostgreSQL, JWT authentication, xUnit, Docker and GitHub Actions.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/downloads)

## Getting started

Clone the repository and run the API:

```bash
git clone https://github.com/CarlosAraujo270/helpdesk-api.git
cd helpdesk-api
dotnet run --project HelpDesk.Api
```

The terminal shows the address the API is listening on (for example `http://localhost:5204`). Open `/api/health` on that address to check that it is running.

## API endpoints

| Method | Route         | Description                        |
| ------ | ------------- | ---------------------------------- |
| GET    | `/api/health` | Returns a message if the API is up |

## Roadmap

- [x] Project setup (solution and Web API project)
- [x] Health-check endpoint
- [ ] Database and entities (PostgreSQL and Entity Framework Core)
- [ ] Tickets and comments (layered architecture, DTOs, validation)
- [ ] Authentication and role-based authorization (JWT)
- [ ] Unit and integration tests (xUnit)
- [ ] Docker and CI (GitHub Actions)
- [ ] Swagger documentation

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
