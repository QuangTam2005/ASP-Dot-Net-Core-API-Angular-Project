# KnowledgeSpace (KwanTam Solution)
## Introduction
KnowledgeSpace is an open-source platform for developers to create knowledge records and share them with the community. For each record, users can engage by voting and leaving comments below.
## Architecture
This project implements a decoupled Client-Server architecture. The `KwanTam` solution consists of three main projects:

*   **KwanTam.BackendServer**: The core ASP.NET Core Web API layer. It handles business logic, database operations, security, and exposes RESTful endpoints.
*   **KwanTam.ViewModels**: A shared class library containing Data Transfer Objects (DTOs), request/response models, and validation logic used across the application.
*   **KwanTam.WebPortal**: The client-side user interface built with Angular, responsible for routing, state management, and consuming the backend APIs.
## How to run this project
### Prerequisites
*   [.NET 10.0 SDK](https://dotnet.microsoft.com/download) (or corresponding version)
*   [Node.js & npm](https://nodejs.org/)
*   SQL Server
### Setup & Run Steps
1.  **Clone the repository:**
    ```bash
    git clone https://github.com/QuangTam2005/ASP-Dot-Net-Core-API-Angular-Project.git
    cd KwanTam
    ```
2.  **Start the Backend (API):**
    *   Navigate to the backend directory: `cd KwanTam.BackendServer`
    *   Update the database connection string in `appsettings.json`.
    *   Apply migrations (if using EF Core): `dotnet ef database update`
    *   Run the server: `dotnet run`
3.  **Start the Frontend (WebPortal):**
    *   Open a new terminal instance.
    *   Navigate to the frontend directory: `cd KwanTam.WebPortal`
    *   Install dependencies: `npm install`
    *   Serve the application: `npm start`
    *   Access the portal at `http://localhost:4200`
## References
*   [ASP.NET Core Web API Documentation](https://learn.microsoft.com/en-us/aspnet/core/web-api)
*   [Angular Official Documentation](https://angular.io/docs)