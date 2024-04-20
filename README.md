Simple .NET Clean Architecture Application  

This project is a demonstration of a .NET application built following the Clean Architecture principles. It consists of different layers, each serving a specific purpose in maintaining a clean and scalable codebase.


Domain Layer  
The Domain layer encapsulates enterprise business rules. It serves as the heart of the application, containing the core logic that represents the business domain. In this layer, you'll find entities, value objects, and domain services that model the fundamental concepts of the problem domain.

Application Layer  
The Application layer encapsulates application-specific business rules and orchestrates the flow of data and operations within the system. It implements the CQRS (Command Query Responsibility Segregation) pattern, utilizing AutoMapper for mapping between DTOs and domain entities, and MediatR for handling commands and queries in a decoupled manner.

API Layer  
The API layer serves as the presentation layer of the application, providing HTTP endpoints for interacting with the system. It implements Swagger for API documentation and utilizes middleware for cross-cutting concerns such as global exception handling.

Persistence Layer  
The Persistence layer is responsible for data access and storage. It implements the Repository pattern for abstracting data access logic, along with the Unit of Work pattern for managing transactions. This layer supports both both commonly used ORMS EF and Dapper, and also uses SQLite for lightweight development and testing environments. Additionally, it utilizes interceptors for intercepting and modifying SQL commands before they are sent to the database.

Getting Started
To run the application, follow these simple steps:

Clone the repository to your local machine.  
Ensure you have the .NET SDK installed.  
Navigate to the root directory of the project.  
Build the solution using dotnet build.  
Run the application using dotnet run.  