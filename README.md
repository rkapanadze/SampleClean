<h1><strong>.NET Clean Architecture Application</strong></h1>

<p>This project is a demonstration of a .NET application built following the Clean Architecture principles. It embraces SOLID principles and Object-Oriented Programming (OOP) paradigms, fostering maintainability and extensibility. The application consists of different layers, each serving a specific purpose in maintaining a clean and scalable codebase.</p>

<h2><strong>Domain Layer</strong></h2>
<p>The Domain layer encapsulates enterprise business rules. It serves as the heart of the application, containing the core logic that represents the business domain.</p>

<h2><strong>Application Layer</strong></h2>
<p>The Application layer encapsulates application-specific business rules and orchestrates the flow of data and operations within the system.</p>

<h2><strong>API Layer</strong></h2>
<p>The API layer serves as the presentation layer of the application, providing HTTP endpoints for interacting with the system.</p>

<h2><strong>Persistence Layer</strong></h2>
<p>The Persistence layer is responsible for data access and storage.</p>

<h2><strong>Design Patterns and Technologies</strong></h2>
<ul>
  <li><strong>CQRS (Command Query Responsibility Segregation)</strong> facilitates a clear separation between commands and queries, enhancing scalability and maintainability.</li>
  <li><strong>The Repository pattern</strong> abstracts data access logic, promoting a flexible and modular approach to data handling.</li>
  <li><strong>MediatR</strong> enables the decoupled handling of commands and queries, fostering cleaner code organization.</li>
  <li><strong>Entity Framework (EF) and Dapper</strong> serve as ORMs, offering different options for data access depending on specific requirements.</li>
  <li><strong>SQLite</strong> provides lightweight data storage solutions, ideal for development and testing environments.</li>
  <li><strong>Interceptors</strong> intercept and modify SQL commands before execution, adding a layer of customization to data access operations.</li>
  <li><strong>Middleware</strong> aids in handling cross-cutting concerns, ensuring a consistent approach to aspects like exception handling and logging.</li>
  <li><strong>AutoMapper</strong> simplifies the mapping between Data Transfer Objects (DTOs) and domain entities, streamlining data transformation tasks.</li>
</ul>

<h2><strong>Getting Started</strong></h2>
<p>To run the application, follow these simple steps:</p>

<ol>
  <li>Clone the repository to your local machine.</li>
  <li>Ensure you have the .NET SDK installed.</li>
  <li>Navigate to the root directory of the project.</li>
  <li>Build the solution using <code>dotnet build</code>.</li>
  <li>Run the application using <code>dotnet run</code>.</li>
</ol>
