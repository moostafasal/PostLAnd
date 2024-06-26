PostLand Application
This repository demonstrates the implementation of a simple blogging platform using ASP.NET Core with a focus on CQRS (Command Query Responsibility Segregation) and MediatR patterns. The application includes basic CRUD operations for posts and categories, with a clean architecture approach.

Key Features
CQRS Pattern
The CQRS pattern is employed to separate read and write operations, enhancing the scalability and maintainability of the application. Queries are used to handle read operations, while commands handle write operations.

MediatR Library
MediatR is used to decouple the application layers by implementing a mediator pattern. This ensures that requests and notifications are processed through a central mediator, promoting loose coupling and single responsibility principles.

Entity Framework Core
Entity Framework Core is used as the ORM (Object-Relational Mapper) for database operations. The context is configured to use SQL Server with options to include related entities when needed.

AutoMapper
AutoMapper is integrated to handle object-object mapping, simplifying the transformation between domain models and view models.

Project Structure
Domain Layer
Contains the core entities and interfaces. These include Post and Category entities, along with repository interfaces such as IAsyncRepository and IPostRepository.

Application Layer
Contains the business logic, including:

Commands: For handling create, update, and delete operations.
Queries: For handling read operations.
Handlers: Implementations of MediatR handlers for commands and queries.
View Models: Data transfer objects used by queries to return data.
Persistence Layer
Contains the implementation of the repository pattern using Entity Framework Core. This includes:

DbContext: The EF Core database context for PostLandDb.
Repositories: Concrete implementations of IAsyncRepository and IPostRepository.
PersistenceContainer: Extension method for setting up dependency injection for the persistence layer.
API Layer
The entry point of the application, containing controllers and the main program setup. It configures services, middleware, and routing.

Example Implementations
Command: CreatePostCommand
Defines the data and logic required to create a new post.

Query: GetPostsListQuery
Defines the data and logic required to retrieve a list of posts.

Validation
FluentValidation is used to ensure data integrity and validation logic for commands.


