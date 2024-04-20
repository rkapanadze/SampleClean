Simple .NET Clean Architecture Application. Consist of difference layers.

Domain - Encapsulates Enterprise business rules.
Application - Encapsulates Application Business rules. Implements CQRS/AutoMapper/MediatR
API - Presentation Layer. Implements Swagger/Middleware
Persistence - Data access Layer. Implements Repository pattern/UOW/Sqlite/Interceptors ORM-EF/Dapper
